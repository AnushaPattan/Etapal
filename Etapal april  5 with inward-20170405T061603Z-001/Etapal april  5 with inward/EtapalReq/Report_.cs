using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace EtapalReq
{
    public partial class Report_ : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReq; integrated Security=true;");
        SqlCommand cmd;
        public Report_()
        {
            InitializeComponent();
        }

        private void Report__Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("select Ack_No,Inward_No from tblReceiver_", conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Columns[0].HeaderText = "SerialNo";

         //  DataGridView dataGridView2 = new DataGridView();
           

            ToolTip tooltip1 = new ToolTip();
            tooltip1.SetToolTip(this.btnPrint, "Print");
            tooltip1.SetToolTip(this.btnBack, "Back");

            //Load Section and Caseworker 
            SqlCommand cmd1 = new SqlCommand("select section from tblSectionManagement", conn);
            conn.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                string name = dr[0].ToString();
                ddlSection.Items.Add(name);
            }
            conn.Close();

            //add Case Worker

            SqlCommand cmd2 = new SqlCommand("select CaseWorker from tblUserMgnt", conn);
            conn.Open();
            SqlDataReader dr1 = cmd2.ExecuteReader();
            while (dr1.Read())
            {
                string name = dr1[0].ToString();
                ddlCaseWorker.Items.Add(name);
            }
            conn.Close();


            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            groupBox1.Visible = false;
            groupBox2.Visible = false;

            
           // dataGridView1.Columns.[1].Name = "GLNo";  
            //dataGridView1.Columns[4].HeaderText = "From Dept";
            //dataGridView1.Columns[5].HeaderText = "Subject";
            //dataGridView1.Columns[6].HeaderText = "From Office";
            //dataGridView1.Columns[7].HeaderText = "To Section";
            //dataGridView1.Columns[8].HeaderText = "To CaseWorker";
            //dataGridView1.Columns[9].HeaderText = "Sign";
        }

   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        Bitmap bitmap;
        //private void btnPrintPreview_Click_1(object sender, EventArgs e)
        //{
        //    //Add a Panel control.
        //    Panel panel = new Panel();
        //    this.Controls.Add(panel);

        //    //Create a Bitmap of size same as that of the Form.
        //    Graphics grp = panel.CreateGraphics();
        //    Size formSize = this.ClientSize;
        //    bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
        //    grp = Graphics.FromImage(bitmap);

        //    //Copy screen area that that the Panel covers.
        //    Point panelLocation = PointToScreen(panel.Location);
        //    grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

        //    //Show the Print Preview Dialog.
        //    printPreviewDialog1.Document = printDocument1;
        //    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
        //    printPreviewDialog1.ShowDialog();
        //}

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            //DataGridViewColumn columnn = dataGridView1.Columns[0];
            //columnn.Width = 400;


            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 5;
            pdfTable.WidthPercentage = 60;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 2;

            PdfPTable pdfTable1 = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable1.DefaultCell.Padding = 5;
            pdfTable1.WidthPercentage = 60;
            pdfTable1.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable1.DefaultCell.BorderWidth = 2;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }
            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }


            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
            //Exporting to PDF
            string folderPath = @"C:\New";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }

            //Exporting to PDF
            string folderPath1 = @"D:\New folder (2)";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath1);
            }
            using (FileStream stream = new FileStream(folderPath1 + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable1);
                pdfDoc.Close();
                stream.Close();
            }

            ////// Show the Print Dialog.
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var Back = new Home1();
            Back.Show();
            this.Hide();
        }

        private void SearchDate()
        {
            string Date = "select Ack_No,GL_No,Received_Date,Letter_Date,FromDept,Subject,FromOffice,ToSection,ToCaseWorker,Signature from tblReceiver_ where Received_Date Between @p1 and @p2";
            cmd = new SqlCommand(Date, conn);
            cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.ToShortDateString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;

            dataGridView1.Columns[0].HeaderText = "Serial No";
            dataGridView1.Columns[1].HeaderText = "GL No";
            dataGridView1.Columns[2].HeaderText = "Received Date";
            dataGridView1.Columns[3].HeaderText = "Letter Date";
            dataGridView1.Columns[4].HeaderText = "FromDept";
            dataGridView1.Columns[5].HeaderText = "Subject";
            dataGridView1.Columns[6].HeaderText = "FromOffice";
            dataGridView1.Columns[7].HeaderText = "ToSection";
            dataGridView1.Columns[8].HeaderText = "ToCaseWorker";
           // dataGridView1.Columns[9].HeaderText = "Sign";


            dataGridView1.ForeColor = Color.Black;
        }
        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            SearchDate();

        }

       

        private void optDateWise_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void optCaseWorker_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {

        //        if (dataGridView1.Columns[e.ColumnIndex].Name == "GLNo")
        //        {
        //            dataGridView1.Rows[e.RowIndex].ReadOnly = true;
        //            //string id = "";/* dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();*/
        //            string GLNo = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //            string InwardNo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        //            string ACKNo = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        //            string ReciveDate = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        //            string LetterDate = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        //            string FromDept = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        //            string OtherDept = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        //            string FromOffice = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        //            string Sub = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        //            string ToSection = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        //            string ToCaseWorker = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
        //            string message = "\nGL NO : " + GLNo + "\nInward No : " + InwardNo + "\nAck No : " + ACKNo + "\nReceived Date : " + ReciveDate + "\nLetter Date : " + LetterDate + "\nFrom Department : " + FromDept + "\nOther Dept : " + OtherDept + "\nFrom Office : " + FromOffice + "\nSubject : " + Sub + "\nTo Section : " + ToSection + "\nTo Casee Worker : " + ToCaseWorker;
        //            MessageBox.Show(message);
        //        }
        //    }
        //    catch (IndexOutOfRangeException)
        //    {
        //        MessageBox.Show("Please click on Reference Link to View Details......");
        //    }
        //    catch (Exception)
        //    {
        //        // MessageBox.Show("Please Enter valid Reference Number.......");
        //    }
        //}

        //private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (dataGridView2.Columns[e.ColumnIndex].Name == "GLNoCase")
        //        {
        //            dataGridView2.Rows[e.RowIndex].ReadOnly = true;
        //            //  string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //            string GLNo = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        //            string InwardNo = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        //            string ACKNo = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        //            string ReciveDate = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
        //            string LetterDate = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
        //            string FromDept = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
        //            string OtherDept = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
        //            string FromOffice = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
        //            string Sub = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
        //            string ToSection = dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString();
        //            string ToCaseWorker = dataGridView2.Rows[e.RowIndex].Cells[11].Value.ToString();
        //            string message = "\nGL NO : " + GLNo + "\nInward No : " + InwardNo + "\nAck No : " + ACKNo + "\nReceived Date : " + ReciveDate + "\nLetter Date : " + LetterDate + "\nFrom Department : " + FromDept + "\nOther Dept : " + OtherDept + "\nFrom Office : " + FromOffice + "\nSubject : " + Sub + "\nTo Section : " + ToSection + "\nTo Casee Worker : " + ToCaseWorker;
        //            MessageBox.Show(message);
        //        }
        //    }
        //    catch (IndexOutOfRangeException)
        //    {
        //        MessageBox.Show("Please click on Reference Link to View Details......");
        //    }
        //    catch (Exception)
        //    {
        //        // MessageBox.Show("Please Enter valid Reference Number.......");
        //    }
        //}

        private void btnSearchCaseWorker_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    SqlCommand cmd = new SqlCommand("select Ack_No,GL_No,Received_Date,Letter_Date,FromDept,Subject,FromOffice,ToSection,ToCaseWorker,Signature from tblReceiver_ where ToSection='" + ddlSection.Text + "' and ToCaseWorker='" + ddlCaseWorker.Text + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns[0].HeaderText = "Serial No";
                    dataGridView2.Columns[1].HeaderText = "GL No";
                    dataGridView2.Columns[2].HeaderText = "Received Date";
                    dataGridView2.Columns[3].HeaderText = "Letter Date";
                    dataGridView2.Columns[4].HeaderText = "FromDept";
                    dataGridView2.Columns[5].HeaderText = "Subject";
                    dataGridView2.Columns[6].HeaderText = "FromOffice";
                    dataGridView2.Columns[7].HeaderText = "ToSection";
                    dataGridView2.Columns[8].HeaderText = "ToCaseWorker";
                    dataGridView2.Columns.Add("Column", "Test");


                    dataGridView2.ForeColor = Color.Black;
                    //  
                }
                else
                {
                    MessageBox.Show("Please Select Both Section And CaseWorker To Search..!!");
                }
            }
            catch(Exception )
            {
                
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

    }
}
