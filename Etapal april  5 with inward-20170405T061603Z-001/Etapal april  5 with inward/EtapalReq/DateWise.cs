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
    public partial class Datewise : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS;initial catalog=EtapalReq;integrated security=true");
        SqlCommand cmd;
        public Datewise()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // To make datagridview columns uneditable
        private void UneditableGridColumn()
        {
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].ReadOnly = true;
            this.dataGridView1.Columns[2].ReadOnly = true;
            this.dataGridView1.Columns[3].ReadOnly = true;
            this.dataGridView1.Columns[4].ReadOnly = true;
            this.dataGridView1.Columns[5].ReadOnly = true;
            this.dataGridView1.Columns[6].ReadOnly = true;
            this.dataGridView1.Columns[7].ReadOnly = true;
            this.dataGridView1.Columns[8].ReadOnly = true;
            this.dataGridView1.Columns[9].ReadOnly = true;
            this.dataGridView1.Columns[10].ReadOnly = true;
            this.dataGridView1.Columns[11].ReadOnly = true;
            this.dataGridView1.Columns[12].ReadOnly = true;
            //this.dataGridView1.Columns[12].ReadOnly = true;
            //this.dataGridView1.Columns[13].ReadOnly = true;
            //this.dataGridView1.Columns[14].ReadOnly = true;
            //this.dataGridView1.Columns[15].ReadOnly = true;
        }

        // To Search Datewise function

        private void SearchDate()
        {
            try
            {
                // dataGridView1.AutoGenerateColumns = false;
                // string Date = "select Ack_No,Gl_No,Received_Date,Letter_Date,FromDept,Subject,FromOffice,ToSection,ToCaseWorker,Signature from tblReceiverNew where Received_Date Between @p1 and @p2";
               
               // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
                
                //string Date = "Select isnull(DO_Letter,'-'),isnull(General_Letter,'-'),isnull(Court_Case_Letter,'-'),isnull(Right_To_Info_Letter,'-'),isnull(Inward_No,'-')," +
                //    "isnull(Letter_No,'-'),Received_Date,Letter_Date,isnull(FromDept,'-'),isnull(Other_Dept,'-'),isnull(FromOffice,'-')," +
                //    "isnull(Subject,'-'),isnull(ToSection,'-'),isnull(DO_Letter,'-'),isnull(DO_Letter,'-'),isnull(DO_Letter,'-')" +   
                //    " from tblReceiverNew where Received_Date Between @p1 and @p2";

                //IMPORTANT

               //SqlCommand cmd = new SqlCommand("Select Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,isnull(Other_Dept, '-'),FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew where Received_Date Between @p1 and @p2" ,conn); 
              //  SqlCommand cmd = new SqlCommand("Select Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew where Received_Date Between @p1 and @p2", conn); 

                string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
                cmd = new SqlCommand(Date, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }


                //dataGridView1.Columns[0].HeaderText = "Serial No";
                //dataGridView1.Columns[1].HeaderText = "GL No";
                //dataGridView1.Columns[2].HeaderText = "Received Date";
                //dataGridView1.Columns[3].HeaderText = "Letter Date";
                //dataGridView1.Columns[4].HeaderText = "FromDept";
                //dataGridView1.Columns[5].HeaderText = "Subject";
                //dataGridView1.Columns[6].HeaderText = "FromOffice";
                //dataGridView1.Columns[7].HeaderText = "ToSection";
                //dataGridView1.Columns[8].HeaderText = "ToCaseWorker";
                //dataGridView1.Columns[9].HeaderText = "Sign";
                // dataGridView1.Columns[9].HeaderText = "Sign";


                dataGridView1.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }
        
        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            try
            {
                UneditableGridColumn();
                SearchDate();
            }
            catch (Exception)
            {

            }
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

                //DataGridViewColumn columnn = dataGridView1.Columns[0];
                //columnn.Width = 400;

                //Creating iTextSharp Table from the DataTable data
                //PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                //pdfTable.DefaultCell.Padding = 5;
                //pdfTable.WidthPercentage = 90;
                //pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                //pdfTable.DefaultCell.BorderWidth = 1;

                ////Adding Header row
                //foreach (DataGridViewColumn column in dataGridView1.Columns)
                //{
                //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                //    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                //    pdfTable.AddCell(cell);
                //}

                ////Adding DataRow
                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    foreach (DataGridViewCell cell in row.Cells)
                //    {
                //        pdfTable.AddCell(cell.Value.ToString());
                //    }
                //}

                ////Exporting to PDF
                //string folderPath = @"C:\New Folder\";
                //if (!Directory.Exists(folderPath))
                //{
                //    Directory.CreateDirectory(folderPath);
                //}
                //using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
                //{
                //    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                //    PdfWriter.GetInstance(pdfDoc, stream);
                //    pdfDoc.Open();
                //    pdfDoc.Add(pdfTable);
                //    pdfDoc.Close();
                //    stream.Close();
                //}

                //////// Show the Print Dialog.
                //PrintDialog printDlg = new PrintDialog();
                //PrintDocument printDoc = new PrintDocument();
                //printDoc.DocumentName = "Print Document";
                //printDlg.Document = printDoc;
                //printDlg.AllowSelection = true;
                //printDlg.AllowSomePages = true;
                ////Call ShowDialog
                //if (printDlg.ShowDialog() == DialogResult.OK)
                //    printDoc.Print();


                //DGVPrinter printer = new DGVPrinter();
                //printer.Title = "General Register";
                //printer.SubTitle = " Sub topic";
                //printer.ShowTotalPageNumber = true;
                //printer.ShowTotalPageNumber = true;
                //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                //printer.PageNumbers = true;
                //printer.PageNumberInHeader = false;
                //printer.PorportionalColumns = true;
                //printer.HeaderCellAlignment = StringAlignment.Near;
                //printer.Footer = "Page";
                //printer.FooterSpacing = 15;
                //printer.PrintDataGridView(dataGridView1);


                 //Open the print dialog
    PrintDialog printDialog = new PrintDialog();            
    printDialog.Document = printDocument1;
    printDialog.UseEXDialog = true;    
    //Get the document
    if (DialogResult.OK == printDialog.ShowDialog())
    {
        printDocument1.DocumentName = "Test Page Print";                
        printDocument1.Print();
    }
    

            }
            catch (Exception)
            {

            }
        }


        private void Datewise_Load(object sender, EventArgs e)
        {
            try
            {
                UneditableGridColumn();

                dataGridView1.AutoGenerateColumns = false;
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            catch (Exception)
            {

            }
        }

        private void lblFromDate_Click(object sender, EventArgs e)
        {

        }

        private void lblToDate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dataGridView1.Rows[e.RowIndex].Cells["SlNo"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Gl_No")
                {
                    dataGridView1.Rows[e.RowIndex].ReadOnly = true;

                    string Gl_No = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string InwardNo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string LetterNo = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string ReceiveDate = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string LetterDate = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string FromDept = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string OtherDept = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string FromOffice = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string Sub = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string ToSection = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string ToSubSection = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string ToCaseWorker = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();

                    string message = "GL NO : " + Gl_No + "\nInward No : " + InwardNo + "\nLetter No : " + LetterNo + "\nReceived Date : " + ReceiveDate + "\nLetter Date : " + LetterDate + "\nFrom Department : " + FromDept + "\nOther Dept : " + OtherDept + "\nFrom Office : " + FromOffice + "\nSubject : " + Sub + "\nTo Section : " + ToSection + "\nTo Sub Section : " + ToSubSection + "\nTo Case Worker : " + ToCaseWorker;
                    // +"\nDO Letter : " + DOLetter + "\nGl Letter : " + GeneralLetter + "\nCourt Case Letetr : " + CourtCaseLetter + "\nRTI Letter : " + RightToInfoLetter;
                    //string message = "GL NO : " + GLNo + "\nInward No : " + InwardNo + "\nSubject : " + Sub ;

                    MessageBox.Show(message);
                }

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                            (double)iTotalWidth * (double)iTotalWidth *
                            ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                            GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headers
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView1.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allows more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Customer Summary",
                                new Font(dataGridView1.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left,
                                e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary",
                                new Font(dataGridView1.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " +
                                DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate,
                                new Font(dataGridView1.Font, FontStyle.Bold), Brushes.Black,
                                e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font(dataGridView1.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary",
                                new Font(new Font(dataGridView1.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(),
                                    Cel.InheritedStyle.Font,
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount],
                                    (float)iTopMargin,
                                    (int)arrColumnWidths[iCount], (float)iCellHeight),
                                    strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iCellHeight));
                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }
                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iCount = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView1.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
