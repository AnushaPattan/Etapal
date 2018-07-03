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
    public partial class Report : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReq; integrated Security=true;");
        SqlCommand cmd;
        // SqlDataAdapter da;
        public Report()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var Back = new Home1();
            Back.Show();
            this.Hide();
        }


        private void Report_Load(object sender, EventArgs e)
        {
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
        }

        private void optDateWise_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }
        private void optCaseWorker_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void SearchDate()
        {
            string Date = "Select * from tblReceiver_ where Received_Date Between @p1 and @p2";
            cmd = new SqlCommand(Date, conn);
            cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.ToShortDateString());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchDate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblReceiver_ where ToSection='" + ddlSection.SelectedText + "'  and ToCaseWorker='" + ddlCaseWorker.SelectedText + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Print Document
        //Bitmap bitmap;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

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
            //Exporting to PDF
            string folderPath = @"C:\New folder\";
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

            ////CaptureScreen();


            ////Process proc = new Process();
            ////proc.StartInfo.FileName = @"C:\\xps2pdf.exe";
            ////string strArguments = "";
            ////strArguments += " D:\\temp\\sample.xps D:\\temp\\out.pdf";


            ////// Show the Print Dialog.
            ////PrintDialog printDlg = new PrintDialog();
            ////PrintDocument printDoc = new PrintDocument();
            ////printDoc.DocumentName = "Print Document";
            ////printDlg.Document = printDoc;
            ////printDlg.AllowSelection = true;
            ////printDlg.AllowSomePages = true;
            //////Call ShowDialog
            ////if (printDlg.ShowDialog() == DialogResult.OK)
            ////    printDoc.Print();

            ////Resize DataGridView to full height.
            //int height = dataGridView2.Height;
            //dataGridView2.Height = dataGridView2.RowCount * dataGridView2.RowTemplate.Height;

            ////Create a Bitmap and draw the DataGridView on it.
            //bitmap = new Bitmap(this.dataGridView2.Width, this.dataGridView2.Height);
            //dataGridView2.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView2.Width, this.dataGridView2.Height));

            ////Resize DataGridView back to original height.
            //dataGridView2.Height = height;

            ////Show the Print Preview Dialog.
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //printPreviewDialog1.ShowDialog();




            //Creating iTextSharp Table from the DataTable data
        }


        // Bitmap bitmap;

        //private void CaptureScreen()
        //{
        //    Graphics myGraphics = this.CreateGraphics();
        //    Size s = this.Size;
        //    Graphics memoryGraphics = Graphics.FromImage(bitmap);
        //    bitmap = new Bitmap(s.Width, s.Height, myGraphics);
        //    memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        //}
        //     Bitmap MemoryImage = new Bitmap;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Print the contents.
            // e.Graphics.DrawImage(bitmap, 0, 0);


            //Print the contents.
            //e.Graphics.DrawImage(bitmap, 20, 40);

            // calculate width and height scalings taking page margins into account
            // var wScale = e.MarginBounds.Width / (float)MemoryImage.Width;
            // var hScale = e.MarginBounds.Height / (float)MemoryImage.Height;

            // choose the smaller of the two scales
            // var scale = wScale < hScale ? wScale : hScale;

            // apply scaling to the image
            //  e.Graphics.ScaleTransform(scale, scale);

            // print to default printer's page
            //e.Graphics.DrawImage(MemoryImage, 0, 0);

        }



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.Columns[e.ColumnIndex].Name == "GLNoCase")
                {
                    dataGridView2.Rows[e.RowIndex].ReadOnly = true;
                    //  string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string GLNo = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string InwardNo = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string ACKNo = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string ReciveDate = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string LetterDate = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string FromDept = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string OtherDept = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string FromOffice = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string Sub = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string ToSection = dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string ToCaseWorker = dataGridView2.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string message = "\nGL NO : " + GLNo + "\nInward No : " + InwardNo + "\nAck No : " + ACKNo + "\nReceived Date : " + ReciveDate + "\nLetter Date : " + LetterDate + "\nFrom Department : " + FromDept + "\nOther Dept : " + OtherDept + "\nFrom Office : " + FromOffice + "\nSubject : " + Sub + "\nTo Section : " + ToSection + "\nTo Casee Worker : " + ToCaseWorker;
                    MessageBox.Show(message);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please click on Reference Link to View Details......");
            }
            catch (Exception)
            {
                // MessageBox.Show("Please Enter valid Reference Number.......");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.Columns[e.ColumnIndex].Name == "GLNo")
                {
                    dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                    //string id = "";/* dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();*/
                    string GLNo = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string InwardNo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string ACKNo = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string ReciveDate = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string LetterDate = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string FromDept = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string OtherDept = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string FromOffice = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string Sub = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string ToSection = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string ToCaseWorker = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string message = "\nGL NO : " + GLNo + "\nInward No : " + InwardNo + "\nAck No : " + ACKNo + "\nReceived Date : " + ReciveDate + "\nLetter Date : " + LetterDate + "\nFrom Department : " + FromDept + "\nOther Dept : " + OtherDept + "\nFrom Office : " + FromOffice + "\nSubject : " + Sub + "\nTo Section : " + ToSection + "\nTo Casee Worker : " + ToCaseWorker;
                    MessageBox.Show(message);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please click on Reference Link to View Details......");
            }
            catch (Exception)
            {
                // MessageBox.Show("Please Enter valid Reference Number.......");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            // Show the Print Preview Dialog.
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //printPreviewDialog1.ShowDialog();
        }

        //private void btnPrintPreview_Click(object sender, EventArgs e)
        //{
        //    ////Show the Print Preview Dialog.
        //    //printPreviewDialog1.Document = printDocument1;
        //    //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
        //    //printPreviewDialog1.ShowDialog();
        //}

    }
}
