using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using EtapalReq;
using DGVPrinterHelper;


namespace EtapalUpdatedNew
{
    public partial class CaseWorker : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS;initial catalog=EtapalReq;integrated security=true");
        //SqlCommand cmd;
        public CaseWorker()
        {
            InitializeComponent();
        }


        // To make datagridview columns uneditable
        private void UneditableGridColumn()
        {
            this.dataGridView2.Columns[0].ReadOnly = true;
            this.dataGridView2.Columns[1].ReadOnly = true;
            this.dataGridView2.Columns[2].ReadOnly = true;
            this.dataGridView2.Columns[3].ReadOnly = true;
            this.dataGridView2.Columns[4].ReadOnly = true;
            this.dataGridView2.Columns[5].ReadOnly = true;
            this.dataGridView2.Columns[6].ReadOnly = true;
            this.dataGridView2.Columns[7].ReadOnly = true;
            this.dataGridView2.Columns[8].ReadOnly = true;
            this.dataGridView2.Columns[9].ReadOnly = true;
            this.dataGridView2.Columns[10].ReadOnly = true;
            this.dataGridView2.Columns[11].ReadOnly = true;
            this.dataGridView2.Columns[12].ReadOnly = true;
            //this.dataGridView2.Columns[12].ReadOnly = true;
            //this.dataGridView2.Columns[13].ReadOnly = true;
            //this.dataGridView2.Columns[14].ReadOnly = true;
           // this.dataGridView2.Columns[15].ReadOnly = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //DataGridViewColumn columnn = dataGridView1.Columns[0];
            //    //columnn.Width = 400;


            //    //Creating iTextSharp Table from the DataTable data
            //    PdfPTable pdfTable = new PdfPTable(dataGridView2.ColumnCount);
            //    pdfTable.DefaultCell.Padding = 5;
            //    pdfTable.WidthPercentage = 90;
            //    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            //    pdfTable.DefaultCell.BorderWidth = 2;

            //    //Adding Header row
            //    foreach (DataGridViewColumn column in dataGridView2.Columns)
            //    {
            //        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
            //        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            //        pdfTable.AddCell(cell);
            //    }
            //    //Adding DataRow
            //    foreach (DataGridViewRow row in dataGridView2.Rows)
            //    {
            //        foreach (DataGridViewCell cell in row.Cells)
            //        {
            //            pdfTable.AddCell(cell.Value.ToString());
            //        }
            //    }
            //    //Exporting to PDF
            //    string folderPath = @"D:\New Folder\";
            //    if (!Directory.Exists(folderPath))
            //    {
            //        Directory.CreateDirectory(folderPath);
            //    }
            //    using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            //    {
            //        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
            //        PdfWriter.GetInstance(pdfDoc, stream);
            //        pdfDoc.Open();
            //        pdfDoc.Add(pdfTable);
            //        pdfDoc.Close();
            //        stream.Close();
            //    }
                ////// Show the Print Dialog.
                //PrintDialog printDlg = new PrintDialog();
                //PrintDocument printDoc = new PrintDocument();
                //printDoc.DocumentName = "Print Document";
                //printDlg.Document = printDoc;
                //printDlg.AllowSelection = true;
                //printDlg.AllowSomePages = true;
                ////Call ShowDialog
                //if (printDlg.ShowDialog() == DialogResult.OK)
                //    printDoc.Print();

            //}
            //catch (Exception)
            //{

            //}
              Label lblSubtitle = new Label();
       

             int CurrentYear = DateTime.Today.Year;
                int PreviousYear = DateTime.Today.Year - 1;
                int NextYear = DateTime.Today.Year + 1;
                string PreYear = PreviousYear.ToString();
                string NexYear = NextYear.ToString();
                string CurYear = CurrentYear.ToString();


                if (DateTime.Today.Month > 3)
                    lblSubtitle.Text= CurYear + "-" + NexYear;
                else
                    lblSubtitle.Text = PreYear + "-" + CurYear;  

          
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "General Register";
                printer.SubTitle = lblSubtitle.Text;
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView2);


                // Label for Financial Year

               


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var back = new ReportNew();
                back.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnSearchCaseWorker_Click(object sender, EventArgs e)
        {
            try
            {
                UneditableGridColumn();

                if (ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                   // SqlCommand cmd = new SqlCommand("select Ack_No,Gl_No,Received_Date,Letter_Date,FromDept,Subject,FromOffice,ToSection,ToCaseWorker,Signature from tblReceiverNew where ToSection='" + ddlSection.Text + "' and ToCaseWorker='" + ddlCaseWorker.Text + "'", conn);
                   // SqlCommand cmd = new SqlCommand("Select * from tblReceiverNew where ToSection = '" +ddlSection.Text+ "' and ToCaseWorker = '" +ddlCaseWorker.Text+"'",conn);

                    SqlCommand cmd = new SqlCommand("Select Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew where ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);
                   


                    //SqlCommand cmd = new SqlCommand("Select Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew where ToSection = '" + ddlSection.Text + "' and ToCaseWorker = '" + ddlCaseWorker.Text + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No Document's Found");
                    }
                    dataGridView2.DataSource = dt;
                    //dataGridView2.Columns[0].HeaderText = "Serial No";
                    //dataGridView2.Columns[1].HeaderText = "GL No";
                    //dataGridView2.Columns[2].HeaderText = "Received Date";
                    //dataGridView2.Columns[3].HeaderText = "Letter Date";
                    //dataGridView2.Columns[4].HeaderText = "FromDept";
                    //dataGridView2.Columns[5].HeaderText = "Subject";
                    //dataGridView2.Columns[6].HeaderText = "FromOffice";
                    //dataGridView2.Columns[7].HeaderText = "ToSection";
                    //dataGridView2.Columns[8].HeaderText = "ToCaseWorker";
                    //dataGridView2.Columns[9].HeaderText = "Sign";
                    //dataGridView2.Columns.Add("Column", "Test");


                    dataGridView2.ForeColor = Color.Black;
                    //  
                }
                else
                {
                    MessageBox.Show("Please Select Both Section And CaseWorker To Search..!!");
                }
            }
            catch (Exception)
            {

            }
        }

        private void CaseWorker_Load(object sender, EventArgs e)
        {
            try
            {
                

                UneditableGridColumn();

                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

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
            }
            catch (Exception)
            {

            }
        }


        private void dataGridView2_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {

                this.dataGridView2.Rows[e.RowIndex].Cells["SlNo"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.Columns[e.ColumnIndex].Name == "Gl_No")
                {
                    dataGridView2.Rows[e.RowIndex].ReadOnly = true;

                    string Gl_No = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string InwardNo = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string LetterNo = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string ReceiveDate = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string LetterDate = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string FromDept = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string OtherDept = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string FromOffice = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string Sub = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string ToSection = dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string ToSubSection = dataGridView2.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string ToCaseWorker = dataGridView2.Rows[e.RowIndex].Cells[12].Value.ToString();
                    string Signature = dataGridView2.Rows[e.RowIndex].Cells[13].Value.ToString();
                   // string ToSection = dataGridView2.Rows[e.RowIndex].Cells[13].Value.ToString();
                    //string ToSubSection = dataGridView2.Rows[e.RowIndex].Cells[14].Value.ToString();
                    //string ToCaseWorker = dataGridView2.Rows[e.RowIndex].Cells[15].Value.ToString();
                    //string GLNo = dataGridView2.Rows[e.RowIndex].Cells[16].Value.ToString();

                    string message = "GL NO : " + Gl_No + "\nInward No : " + InwardNo + "\nLetter No : " + LetterNo + "\nReceived Date : " + ReceiveDate + "\nLetter Date : " + LetterDate + "\nFrom Department : " + FromDept + "\nOther Dept : " + OtherDept + "\nFrom Office : " + FromOffice + "\nSubject : " + Sub + "\nTo Section : " + ToSection + "\nTo Sub Section : " + ToSubSection + "\nTo Case Worker : " + ToCaseWorker + "\nSignature : " + Signature;
                    // +"\nDO Letter : " + DOLetter + "\nGl Letter : " + GeneralLetter + "\nCourt Case Letetr : " + CourtCaseLetter + "\nRTI Letter : " + RightToInfoLetter;
                    //string message = "GL NO : " + GLNo + "\nInward No : " + InwardNo + "\nSubject : " + Sub ;

                    MessageBox.Show(message);
                }
            
            }
            catch (Exception)
            {

            }
        }

    }
}
