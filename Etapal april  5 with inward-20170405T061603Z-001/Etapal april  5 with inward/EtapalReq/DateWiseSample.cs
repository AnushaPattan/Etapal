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
//using iTextSharp.text.pdf;
//using iTextSharp.text;
using System.IO;
using EtapalReq;
using DGVPrinterHelper;
using EtapalUpdatedNew;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.pdf.parser;

namespace EtapalReq
{
    public partial class DateWiseSample : Form
    {//SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
        SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");

        // SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        SqlCommand cmd;

        public DateWiseSample()
        {
            InitializeComponent();
        }

        private void DateWiseSample_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSerial();

                radDOLetter.Checked = true;

                dataGridView2.Visible = true;



                dataGridView2.AutoGenerateColumns = false;
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            catch (Exception)
            {

            }
        }

        private void radDOLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radDOLetter.Checked == true)
                {

                    dataGridView2.Visible = true;


                }
                else
                {

                    dataGridView2.Visible = false;

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            if (radDOLetter.Checked == true)
            {
                Search_DOLetter();
                dataGridView2.Visible = true;
                LoadSerial();
            }
        }

        // To Search Datewise function

        private void Search_DOLetter()
        {
            try
            {
                //  UneditableGridColumn();
                //string Date = "Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection,ToCaseWorker as ToCaseWorker,Signature as SignAndDate,Gl_No_Id,Letter_No,FromDept from tblGovernmentLetter_WO  where DO_Letter='DoLetter' and Received_Date Between @p1 and @p2";
                // Important
                //  string Date = "Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection,ToCaseWorker as ToCaseWorker,Signature as SignAndDate,Gl_No_Id,Letter_No,FromDept from tblGovernmentLetter_WO  where DO_Letter='DoLetter' and Received_Date Between @p1 and @p2";
                string Date = "Select Received_Date,Subject,ToSection ,ToCaseWorker ,Signature,Gl_No_Id,Letter_No,FromDept from tblGovernmentLetter_WO  where DO_Letter='DoLetter' and Received_Date Between @p1 and @p2";

                // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
                cmd = new SqlCommand(Date, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the DO Letters";
                }

                dataGridView2.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        //private void Print_DO()
        //{
        //    //int w = System.Math.Max(dataGridView1.Width);
        //    //int h = dataGridView1.Height + dataGridView1.Height;
        //    //Bitmap bmp = new Bitmap(w, h);
        //    //System.Drawing.Rectangle r = new System.Drawing.Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height);
        //    //dataGridView1.DrawToBitmap(bmp, r);
        //    //r.Y = dataGridView1.Height;
        //    //r.Width = dataGridView2.Width;
        //    //r.Height = dataGridView2.Height;
        //    //dataGridView2.DrawToBitmap(bmp, r);
        //    //e.Graphics.DrawImage(bmp, e.MarginBounds);

        //    //  ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
        //    // string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);
        //    //  FontFactory.DefaultEmbedding = true;

        //    //Creating iTextSharp Table from the DataTable data
        //    PdfPTable pdfTable = new PdfPTable(dataGridView2.ColumnCount);
        //    pdfTable.DefaultCell.Padding = 3;
        //    pdfTable.WidthPercentage = 90;
        //    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
        //    pdfTable.DefaultCell.BorderWidth = 2;



        //    //PdfReader reader = new PdfReader(GetTemplateBytes());
        //    //pst = new PdfStamper(reader, Response.OutputStream);

        //    //pst.Writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_4);
        //    //pst.Writer.PDFXConformance = PdfWriter.PDFA1A;

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
        //    string folderPath = @"C:\New Folder\";
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
        //}

        //Bitmap bitmap;
        //private void Print_DO()
        //{
        //    //Resize DataGridView to full height.
        //    int height = dataGridView1.Height;
        //    dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;

        //    //Create a Bitmap and draw the DataGridView on it.
        //    bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
        //    dataGridView1.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

        //    //Resize DataGridView back to original height.
        //    dataGridView1.Height = height;

        //    //Show the Print Preview Dialog.
        //    printPreviewDialog1.Document = printDocument1;
        //    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
        //    printPreviewDialog1.ShowDialog();
        //}


        private void Print_DO()
        {
            try
            {
                Label lblSubtitle = new Label();
                Label lblDate = new Label();

                string date = DateTime.Now.ToString("dd/MM/yyyy");
                lblDate.Text = date.ToString();

                int CurrentYear = DateTime.Today.Year;
                int PreviousYear = DateTime.Today.Year - 1;
                int NextYear = DateTime.Today.Year + 1;
                string PreYear = PreviousYear.ToString();
                string NexYear = NextYear.ToString();
                string CurYear = CurrentYear.ToString();


                if (DateTime.Today.Month > 3)
                    lblSubtitle.Text = CurYear + "-" + NexYear;
                else
                    lblSubtitle.Text = PreYear + "-" + CurYear;


                DGVPrinter printer = new DGVPrinter();
                printer.Title = "General Register : " + " " + lblSubtitle.Text; ;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : DO Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;



                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "DO Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView2);

                LoadSerial();

            }
            catch (Exception)
            {

            }
        }

        private PdfReader GetTemplateBytes()
        {
            throw new NotImplementedException();
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (radDOLetter.Checked == true)
            {
                Print_DO();
            }
        }

        // Method for Generating Serial Numbers 
        private void LoadSerial()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells["SlNo"].Value = i; i++;
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            LoadSerial();
        }


    }
}
