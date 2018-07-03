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
using System.Configuration;
//using System.Drawing.Text;


namespace EtapalReq
{
    public partial class DateWiseWO : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        //SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
        //SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");

        // SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        SqlCommand cmd;
        public DateWiseWO()
        {
            InitializeComponent();
        }

        // To make datagridview columns uneditable
        //private void UneditableGridColumn()
        //{
        //    try
        //    {
        //        this.dataGridView1.Columns[0].ReadOnly = true;
        //        this.dataGridView1.Columns[1].ReadOnly = true;
        //        this.dataGridView1.Columns[2].ReadOnly = true;
        //        this.dataGridView1.Columns[3].ReadOnly = true;
        //        this.dataGridView1.Columns[4].ReadOnly = true;
        //        this.dataGridView1.Columns[5].ReadOnly = true;
        //        this.dataGridView1.Columns[6].ReadOnly = true;
        //        this.dataGridView1.Columns[7].ReadOnly = true;
        //        this.dataGridView1.Columns[8].ReadOnly = true;
        //        this.dataGridView1.Columns[9].ReadOnly = true;
        //        this.dataGridView1.Columns[10].ReadOnly = true;
        //        this.dataGridView1.Columns[11].ReadOnly = true;


        //        this.dataGridView2.Columns[0].ReadOnly = true;
        //        this.dataGridView2.Columns[1].ReadOnly = true;
        //        this.dataGridView2.Columns[2].ReadOnly = true;
        //        this.dataGridView2.Columns[3].ReadOnly = true;
        //        this.dataGridView2.Columns[4].ReadOnly = true;
        //        this.dataGridView2.Columns[5].ReadOnly = true;
        //        this.dataGridView2.Columns[6].ReadOnly = true;
        //        this.dataGridView2.Columns[7].ReadOnly = true;
        //        this.dataGridView2.Columns[8].ReadOnly = true;
        //        this.dataGridView2.Columns[9].ReadOnly = true;
        //        this.dataGridView2.Columns[10].ReadOnly = true;
        //        this.dataGridView2.Columns[11].ReadOnly = true;


        //        this.dataGridView3.Columns[0].ReadOnly = true;
        //        this.dataGridView3.Columns[1].ReadOnly = true;
        //        this.dataGridView3.Columns[2].ReadOnly = true;
        //        this.dataGridView3.Columns[3].ReadOnly = true;
        //        this.dataGridView3.Columns[4].ReadOnly = true;
        //        this.dataGridView3.Columns[5].ReadOnly = true;
        //        this.dataGridView3.Columns[6].ReadOnly = true;
        //        this.dataGridView3.Columns[7].ReadOnly = true;
        //        this.dataGridView3.Columns[8].ReadOnly = true;
        //        this.dataGridView3.Columns[9].ReadOnly = true;
        //        this.dataGridView3.Columns[10].ReadOnly = true;
        //        this.dataGridView3.Columns[11].ReadOnly = true;


        //        this.dataGridView4.Columns[0].ReadOnly = true;
        //        this.dataGridView4.Columns[1].ReadOnly = true;
        //        this.dataGridView4.Columns[2].ReadOnly = true;
        //        this.dataGridView4.Columns[3].ReadOnly = true;
        //        this.dataGridView4.Columns[4].ReadOnly = true;
        //        this.dataGridView4.Columns[5].ReadOnly = true;
        //        this.dataGridView4.Columns[6].ReadOnly = true;
        //        this.dataGridView4.Columns[7].ReadOnly = true;
        //        this.dataGridView4.Columns[8].ReadOnly = true;
        //        this.dataGridView4.Columns[9].ReadOnly = true;
        //        this.dataGridView4.Columns[10].ReadOnly = true;
        //        this.dataGridView4.Columns[11].ReadOnly = true;


        //        this.dataGridView5.Columns[0].ReadOnly = true;
        //        this.dataGridView5.Columns[1].ReadOnly = true;
        //        this.dataGridView5.Columns[2].ReadOnly = true;
        //        this.dataGridView5.Columns[3].ReadOnly = true;
        //        this.dataGridView5.Columns[4].ReadOnly = true;
        //        this.dataGridView5.Columns[5].ReadOnly = true;
        //        this.dataGridView5.Columns[6].ReadOnly = true;
        //        this.dataGridView5.Columns[7].ReadOnly = true;
        //        this.dataGridView5.Columns[8].ReadOnly = true;
        //        this.dataGridView5.Columns[9].ReadOnly = true;
        //        this.dataGridView5.Columns[10].ReadOnly = true;
        //        this.dataGridView5.Columns[11].ReadOnly = true;

        //        // this.dataGridView1.Columns[14].ReadOnly = true;
        //        //this.dataGridView1.Columns[13].ReadOnly = true;
        //        //this.dataGridView1.Columns[14].ReadOnly = true;
        //        //this.dataGridView1.Columns[15].ReadOnly = true;

        //        this.dataGridView_Lokayukta.Columns[0].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[1].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[2].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[3].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[4].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[5].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[6].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[7].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[8].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[9].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[10].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[11].ReadOnly = true;

        //        //this.dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 50);
        //        //this.dataGridView2.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 50);
        //        //this.dataGridView3.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 50);
        //        //this.dataGridView4.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 50);
        //        //this.dataGridView5.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 50);
        //        //this.dataGridView_Lokayukta.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 50);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}



        private void DateWiseWO_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSerial();
                LoadSerialGeneral();

                radDOLetter.Checked = true;
                dataGridView2.Visible = false;
                dataGridView5.Visible = false;


                //  UneditableGridColumn();

                dataGridView2.AutoGenerateColumns = false;
                dataGridView5.AutoGenerateColumns = false;
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
                    dataGridView5.Visible = false;

                }
                else
                {

                    dataGridView2.Visible = false;
                    dataGridView5.Visible = true;

                }
            }
            catch (Exception)
            {

            }
        }

        private void radGeneralLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radGeneralLetter.Checked == true)
                {
                    dataGridView2.Visible = false;
                    dataGridView5.Visible = true;

                }
                else
                {
                    dataGridView2.Visible =  true ;
                    dataGridView5.Visible = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void radCourtCaseLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radCourtCaseLetter.Checked == true)
                {
                    dataGridView2.Visible = true;
                    dataGridView5.Visible = false;

                }
                else
                {
                    dataGridView2.Visible = false;
                    dataGridView5.Visible = true;

                }
            }
            catch (Exception)
            {

            }
        }

        private void radRightToInformationLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radRightToInformationLetter.Checked == true)
                {
                    dataGridView2.Visible = true;
                    dataGridView5.Visible = false;

                }
                else
                {
                    dataGridView2.Visible = false;
                    dataGridView5.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void radGovtLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radGovtLetter.Checked == true)
                {
                    dataGridView2.Visible = true;
                    dataGridView5.Visible = false;

                }
                else
                {
                    dataGridView2.Visible = false;
                    dataGridView5.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }


        private void optLokayuktaLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optLokayuktaLetter.Checked == true)
                {
                    dataGridView2.Visible = true;
                    dataGridView5.Visible = false;

                }
                else
                {


                    dataGridView2.Visible = false;
                    dataGridView5.Visible = true;

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (radDOLetter.Checked == false && radGeneralLetter.Checked == false && radCourtCaseLetter.Checked == false && radRightToInformationLetter.Checked == false && radGovtLetter.Checked == false && optLokayuktaLetter.Checked == false)
                {
                    MessageBox.Show("Please Select category to Search..!!");
                }
                else if (radDOLetter.Checked == true)
                {
                    Search_DOLetter();
                    dataGridView2.Visible = true;
                    LoadSerial();

                }
                else if (radGovtLetter.Checked == true)
                {
                    Search_Government_Letter();
                    dataGridView2.Visible = true;
                    LoadSerial();
                }
                else if (radCourtCaseLetter.Checked == true)
                {
                    Search_Court_Case_Letter();
                    dataGridView2.Visible = true;
                    LoadSerial();
                }
                else if (radRightToInformationLetter.Checked == true)
                {
                    Search_Right_To_Info_Letter();
                    dataGridView2.Visible = true;
                    LoadSerial();
                }
                else if (optLokayuktaLetter.Checked == true)
                {
                    Search_Lokayukta_ABS_Letter();
                    dataGridView2.Visible = true;
                    LoadSerial();
                }
                else if (radGeneralLetter.Checked == true)
                {
                    Search_General_Letter();
                    dataGridView5.Visible = true;
                    LoadSerialGeneral();
                }
            }
            catch (Exception)
            {

            }
        }

        // To Search Datewise function

        private void Search_DOLetter()
        {
            try
            {
                // UneditableGridColumn();
                //string Date = "Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection,ToCaseWorker as ToCaseWorker,Signature as SignAndDate,Gl_No_Id,Letter_No,FromDept from tblGovernmentLetter_WO  where DO_Letter='DoLetter' and Received_Date Between @p1 and @p2";
                // Imp
                // "Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection,ToCaseWorker as ToCaseWorker,Signature as Signature,Gl_No_Id,Letter_No,FromDept from tblGovernmentLetter_WO  where DO_Letter='DoLetter' and Received_Date Between @p1 and @p2";


               // string Date = "Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection ,ToCaseWorker as ToCaseWorker,Gl_No_Id,FromDept,Letter_No,Signature as Signature from tblGovernmentLetter_WO where DO_Letter='DoLetter' and Received_Date Between @p1 and @p2";
             //   CONVERT(varchar, Received_Date, 103) as ReceivedDate,

                //  string Date = "Select * from tblGovernmentLetter_WO  where DO_Letter='DoLetter' and Received_Date Between @p1 and @p2";
                // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
                SqlCommand cmd = new SqlCommand("Select CONVERT(varchar, Received_Date, 103) as ReceivedDate, Subject as Subject,ToSection as ToSection ,ToCaseWorker as ToCaseWorker,Gl_No_Id,FromDept,Letter_No,Signature as Signature from tblGovernmentLetter_WO  where DO_Letter='DoLetter' and Received_Date Between @p1 and @p2 Order by GL_No_Id", conn);


                //cmd = new SqlCommand(conn);
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

        private void Search_Government_Letter()
        {
            try
            {
                //  UneditableGridColumn();
                //  string Date = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,FromDept,Subject,ToSection,ToCaseWorker,Signature from tblGovernmentLetter_WO  where Government_Letter='GovernmentLetter' and Received_Date Between @p1 and @p2";

                string Date = "Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection,ToCaseWorker as ToCaseWorker,Signature as SignAndDate,Gl_No_Id,FromDept,Letter_No from tblGovernmentLetter_WO  where Government_Letter='GovernmentLetter' and Received_Date Between @p1 and @p2 Order by GL_No_Id";

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
                    lblLetterDetails.Text = "The following are the Government Letters";
                }

                dataGridView2.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        private void Search_Court_Case_Letter()
        {
            try
            {
                //   UneditableGridColumn();
                string Date = "Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection,ToCaseWorker as ToCaseWorker,Signature as SignAndDate,Gl_No_Id,Letter_No,FromDept from tblGovernmentLetter_WO  where Court_Case_Letter='CourtCaseLetter' and Received_Date Between @p1 and @p2 Order by GL_No_Id";
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
                }

                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Court Case Letters";
                }

                dataGridView2.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        private void Search_Right_To_Info_Letter()
        {
            try
            {
                //   UneditableGridColumn();
                string Date = "Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection,ToCaseWorker as ToCaseWorker,Signature as SignAndDate,Gl_No_Id,Letter_No,FromDept from tblGovernmentLetter_WO  where Right_To_Info_Letter='RightToInfoLetter' and Received_Date Between @p1 and @p2 Order by GL_No_Id";
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
                }

                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Right to Information Letters";
                }

                dataGridView2.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        private void Search_Lokayukta_ABS_Letter()
        {
            try
            {
                //   UneditableGridColumn();
                string Date = "Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection,ToCaseWorker as ToCaseWorker,Signature as SignAndDate,Gl_No_Id,Letter_No,FromDept from tblGovernmentLetter_WO  where Lokayukta_ABS_Letter='LokayuktaLetter' and Received_Date Between @p1 and @p2 Order by GL_No_Id";
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
                }

                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Lokayukta/ACB Letters";
                }

                dataGridView2.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        private void Search_General_Letter()
        {
            try
            {
                //   UneditableGridColumn();
                string Date = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDatee,Subject,ToSection,ToCaseWorker,Signature,Applicant_Name from tblGeneralLetter_WO  where General_Letter='GeneralLetter' and Letter_Date Between @p1 and @p2 Order by GL_No_Id";
                // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
                cmd = new SqlCommand(Date, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }

                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the General Letters";
                }
                dataGridView5.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (radDOLetter.Checked == true)
                {
                    Print_DO();
                }
                else if (radGovtLetter.Checked == true)
                {
                    Print_Government_Letter();
                }
                else if (radCourtCaseLetter.Checked == true)
                {
                    Print_Court_Case_Letter();
                }
                else if (radRightToInformationLetter.Checked == true)
                {
                    Print_Right_To_Info_Letter();
                }
                else if (optLokayuktaLetter.Checked == true)
                {
                    Print_Lokayukta_ABS_Letter();
                }
                else if (radGeneralLetter.Checked == true)
                {
                    Print_General_Letter();
                }
            }
            catch (Exception)
            {

            }
        }

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
                printer.Title = "Government Register : " + " " + lblSubtitle.Text; 
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : DO Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;



                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "DO Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView2);

            }
            catch (Exception)
            {

            }
        }

        private void Print_Government_Letter()
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
                printer.Title = "Government Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Government Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
              //  printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Government Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView2);
            }
            catch (Exception)
            {

            }
        }

        private void Print_Court_Case_Letter()
        {
            try
            {
                Label lblSubtitle = new Label();
                Label lblDate = new Label();

                string date = DateTime.Now.ToString("dd/MM/yyyy");
                lblDate.Text = date.ToString();

                // Label lblTypeOfLetter = new Label();
                // lblTypeOfLetter.Text = " DO Letter";

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
                printer.Title = "Government Register : " + " " + lblSubtitle.Text; ;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Court Case Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Court Case Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView2);
                
                
            }
            catch (Exception)
            {

            }

        }

        private void Print_Right_To_Info_Letter()
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
                printer.Title = "Government Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Right to Information Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Right to Information Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView2);
            }
            catch (Exception)
            {

            }
        }

        private void Print_Lokayukta_ABS_Letter()
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
                printer.Title = "Government Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Lokayukta / ABS Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Lokayukta / ABS Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView2);
            }
            catch (Exception)
            {

            }
        }

        private void Print_General_Letter()
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
                printer.Title = "General Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : General Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "General Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView5);
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

        //private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //    try
        //    {

        //        this.dataGridView2.Rows[e.RowIndex].Cells["SlNoDODate"].Value = Convert.ToString((e.RowIndex + 1));
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //private void dataGridView5_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //    try
        //    {

        //        this.dataGridView5.Rows[e.RowIndex].Cells["SlNoGenDate"].Value = Convert.ToString((e.RowIndex + 1));
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            try
            {
                var BackHome = new Home();
                BackHome.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        // Method for Generating Serial Numbers for DO,Court,etc letters
        private void LoadSerial()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells["SlNoDODate"].Value = i; i++;
            }
        }

        // Method for Generating Serial Numbers for DO,Court,etc letters
        private void  LoadSerialGeneral()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                row.Cells["SlNoGenDate"].Value = i; i++;
            }
        }

        private void dataGridView5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            LoadSerial();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            LoadSerialGeneral();
        }

       

    }
}
