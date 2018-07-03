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
using EtapalReq;
using DGVPrinterHelper;
//using EtapalUpdatedNew;
using System.Configuration;

namespace EtapalReq
{
    public partial class DateWise_IN : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        SqlCommand cmd;

        public DateWise_IN()
        {
            InitializeComponent();
        }

        private void DateWise_IN_Load(object sender, EventArgs e)
        {
            try
            {
                radCourtCaseLetter.Checked = true;
                dataGridViewSearchCourt.Visible = false;

                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                //Tooltips
                ToolTip tooltip1 = new ToolTip();
                tooltip1.SetToolTip(this.btnSearchCaseWorker, "Search");
                tooltip1.SetToolTip(this.btnBack, "Back to Report");
                tooltip1.SetToolTip(this.btnPrint, "Print");
                tooltip1.SetToolTip(this.btnBackHome, "Back to Home");

                //Today Date
                DateTime Today = DateTime.Now;
                lblTodayDateValue.Text = Today.ToString();

                // Label for Financial Year

                int CurrentYear = DateTime.Today.Year;
                int PreviousYear = DateTime.Today.Year - 1;
                int NextYear = DateTime.Today.Year + 1;
                string PreYear = PreviousYear.ToString();
                string NexYear = NextYear.ToString();
                string CurYear = CurrentYear.ToString();


                if (DateTime.Today.Month > 3)
                    lblFinYearValue.Text = CurYear + "-" + NexYear;
                else
                    lblFinYearValue.Text = PreYear + "-" + CurYear;


                //Load Fin Year
                LoadFinYear();

                //Default Check GL No
                optDOLetter.Checked = true;

                lblLetterDetails.Visible = false;


            }
            catch (Exception)
            {

            }
        }
        private void btnSearchCaseWorker_Click(object sender, EventArgs e)
        {
            try
            {
                if (optDOLetter.Checked == true || optGeneralLetter.Checked == true || optRightToInformationLetter.Checked == true || radLokayuktaLetter.Checked == true || optGovtLetter.Checked == true)
                {
                    Search_Government_2017();
                }
                else if (radCourtCaseLetter.Checked == true)
                {
                    Search_Court_2017();
                }
                else if (optAllGovt.Checked == true)
                {
                    Search_All_2017();
                }
            }
            catch (Exception)
            {

            }
        }


        //// To Search Datewise function

        //private void Search_DOLetter()
        //{
        //    try
        //    {
        //        string Date = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Letter_Date, 103) as LetterDate,FromDept,Subject,ToSection,ToCaseWorker,Signature,Inward_No from tblGovernmentLetter_IN  where DO_Letter='DoLetter' and Entry_Date Between @p1 and @p2 Order by GL_No_Id";

        //        //      SELECT  CONVERT(varchar, DateColumn, 103) from TableName 

        //        // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
        //        cmd = new SqlCommand(Date, conn);
        //        cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
        //        cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridViewSearchGovt.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found");
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the Details of DO Letters";
        //        }
        //        dataGridViewSearchGovt.ForeColor = Color.Black;

        //    }

        //    catch (Exception)
        //    {

        //    }
        //}


        //private void Search_Government_Letter()
        //{
        //    try
        //    {
        //        //  UneditableGridColumn();
        //        string Date = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Letter_Date, 103) as LetterDate,FromDept,Subject,ToSection,ToCaseWorker,Signature,Inward_No from tblGovernmentLetter_IN   where Government_Letter='GovernmentLetter' and Entry_Date Between @p1 and @p2 Order by GL_No_Id";
        //        // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
        //        cmd = new SqlCommand(Date, conn);
        //        cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
        //        cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridViewSearchGovt.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found");
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the Details of Government Letters";
        //        }

        //        dataGridViewSearchGovt.ForeColor = Color.Black;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //private void Search_Court_Case_Letter()
        //{
        //    try
        //    {
        //        //UneditableGridColumn();
        //        string Date = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Letter_Date, 103) as LetterDate,FromDept,Subject,ToSection,ToCaseWorker,Signature,Inward_No from tblCourtCaseLetter_IN   where Court_Case_Letter='CourtCaseLetter' and Entry_Date Between @p1 and @p2 Order by GL_No_Id";
        //        // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
        //        cmd = new SqlCommand(Date, conn);
        //        cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
        //        cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridViewSearchGovt.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found");
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the Details of Court Case Letters";
        //        }
        //        dataGridViewSearchGovt.ForeColor = Color.Black;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //private void Search_Right_To_Info_Letter()
        //{
        //    try
        //    {
        //        //   UneditableGridColumn();
        //        string Date = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Letter_Date, 103)as LetterDate,FromDept,Subject,ToSection,ToCaseWorker,Signature,Inward_No from tblGovernmentLetter_IN   where Right_To_Info_Letter='RightToInfoLetter' and Entry_Date Between @p1 and @p2 Order by GL_No_Id";
        //        // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
        //        cmd = new SqlCommand(Date, conn);
        //        cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
        //        cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridViewSearchGovt.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found");
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the Details of Right to Information Letters";
        //        }
        //        dataGridViewSearchGovt.ForeColor = Color.Black;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}


        //private void Search_Lokayukta_ABS_Letter()
        //{
        //    try
        //    {
        //        //  UneditableGridColumn();
        //        string Date = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Letter_Date, 103)as LetterDate,FromDept,Subject,ToSection,ToCaseWorker,Signature,Inward_No from tblGovernmentLetter_IN   where Lokayukta_ABS_Letter='LokayuktaLetter' and Entry_Date Between @p1 and @p2 Order by GL_No_Id";
        //        // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
        //        cmd = new SqlCommand(Date, conn);
        //        cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
        //        cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridViewSearchGovt.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found");
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the Details of Lokayukta/ACB Letters";
        //        }
        //        dataGridViewSearchGovt.ForeColor = Color.Black;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //private void Search_General_Letter()
        //{
        //    try
        //    {
        //        // UneditableGridColumn();
        //        string Date = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Letter_Date, 103)as LetterDatee,Subject,ToSection,ToCaseWorker,Signature,Applicant_Name,Inward_No  from tblGovernmentLetter_IN  where General_Letter='GeneralLetter' and Entry_Date Between @p1 and @p2 Order by GL_No_Id";
        //        // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
        //        cmd = new SqlCommand(Date, conn);
        //        cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
        //        cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridView5.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found");
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the Details of General Letters";
        //        }
        //        dataGridView5.ForeColor = Color.Black;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (optDOLetter.Checked == true)
                {
                    Print_DO();
                }
                else if (optGovtLetter.Checked == true)
                {
                    Print_Government_Letter();
                }
                else if (radCourtCaseLetter.Checked == true)
                {
                    Print_Court_Case_Letter();
                }
                else if (optRightToInformationLetter.Checked == true)
                {
                    Print_Right_To_Info_Letter();
                }
                else if (radLokayuktaLetter.Checked == true)
                {
                    Print_Lokayukta_ABS_Letter();
                }
                else if (optGeneralLetter.Checked == true)
                {
                    Print_General_Letter();
                }
                else if (optAllGovt.Checked == true)
                {
                    Print_AllGovt_Letter();
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
                printer.Title = "Government Register : " + " " + lblSubtitle.Text; ;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : DO Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                //   printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridViewSearchGovt);
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
                //    printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridViewSearchGovt);
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
                printer.Title = "Court Case Register : " + " " + lblSubtitle.Text; ;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Court Case Letter ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                //   printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Page";
                printer.FooterSpacing = 30;
                printer.PrintDataGridView(dataGridViewSearchCourt);
                printer.CellAlignment = StringAlignment.Far;
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
                //   printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridViewSearchGovt);
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
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Lokayukta / ACB Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                // printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridViewSearchGovt);
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
                printer.Title = "Government Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : General Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                // printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridViewSearchGovt);
            }
            catch (Exception)
            {

            }
        }

        private void Print_AllGovt_Letter()
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
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : All Govt Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                // printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridViewSearchGovt);
            }
            catch (Exception)
            {

            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var back = new Report_IN();
                back.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

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


        // Method for Generating Serial Numbers for DO,,etc letters
        private void LoadSerialGovt()
        {
            try
            {
                int i = 1;
                foreach (DataGridViewRow row in dataGridViewSearchGovt.Rows)
                {
                    row.Cells["SlNoGovtDateIN"].Value = i;
                    i++;
                }
            }
            catch (Exception)
            {

            }
        }

        // Method for Generating Serial Numbers for Court letter
        private void LoadSerialCourt()
        {
            try
            {
                int i = 1;
                foreach (DataGridViewRow row in dataGridViewSearchCourt.Rows)
                {
                    row.Cells["SlNoCourtDateIN"].Value = i;
                    i++;
                }
            }
            catch (Exception)
            {

            }
        }

        //Search Government Letters from 2017
        private void Search_Government_2017()
        {
            try
            {
                //string following = " The following are the ";
                //string DO = " DO ";
                //string Government = " Government ";
                //string CourtCase = " CourtCase "; 
                //string Right_To_Information = " Right To Information ";
                //string Lokayukta = " Lokayukta ";
                //string Letters = " Letters Between ";
                //string C_2017_2018 = " 1st April 2017 and 31 March 2018 ";

                string s = "";
                string Govt = "";
                string Common1 = "Select Letter_No,CONVERT(varchar, Letter_Date, 103) as LetterDate,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,GL_No_Id,Applicant_Name,Signature as SignAndDate from ";
                string Common2 = " and Entry_Date Between @p1 and @p2 Order by GL_No_Id ";
                string Common_2017_2018 = "  tblGovernmentLetter_IN_2017_2018  where ";
                string Common_2018_2019 = "  tblGovernmentLetter_IN_2018_2019  where ";
                string Common_2019_2020 = "  tblGovernmentLetter_IN_2019_2020  where ";
                string Common_2020_2021 = "  tblGovernmentLetter_IN_2020_2021  where ";
                string Common_2021_2022 = "  tblGovernmentLetter_IN_2021_2022  where ";
                string Common_2022_2023 = "  tblGovernmentLetter_IN_2022_2023  where ";
                string Common_2023_2024 = "  tblGovernmentLetter_IN_2023_2024  where ";
                string Common_2024_2025 = "  tblGovernmentLetter_IN_2024_2025  where ";

                //  s = string.Concat(Common1, Common_2016_2017, Govt, Common2);
                lblLetterDetails.Visible = true;

                //2017-2018
                if (cbFinYear.Text == "2017-2018")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2017 and 31 March 2018";
                        // lblLetterDetails.Text = following + DO + Letters + C_2017_2018;
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2017 and 31 March 2018";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2017 and 31 March 2018";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Letters Between 1st April 2017 and 31 March 2018";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2017 and 31 March 2018";
                    }
                    s = string.Concat(Common1, Common_2017_2018, Govt, Common2);
                }

                //2018-2019
                else if (cbFinYear.Text == "2018-2019")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2018 and 31 March 2019";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2018 and 31 March 2019";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2018 and 31 March 2019";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Letters Between 1st April 2018 and 31 March 2019";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2018 and 31 March 2019";
                    }
                    s = string.Concat(Common1, Common_2018_2019, Govt, Common2);
                }

               //2019-2020
                else if (cbFinYear.Text == "2019-2020")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2019 and 31 March 2020";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2019 and 31 March 2020";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2019 and 31 March 2020";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2019 and 31 March 2020";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2019 and 31 March 2020";
                    }
                    s = string.Concat(Common1, Common_2019_2020, Govt, Common2);
                }

                 //2020-2021
                else if (cbFinYear.Text == "2020-2021")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2020 and 31 March 2021";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2020 and 31 March 2021";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2020 and 31 March 2021";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2020 and 31 March 2021";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2020 and 31 March 2021";
                    }
                    s = string.Concat(Common1, Common_2020_2021, Govt, Common2);
                }

                //2021-2022
                else if (cbFinYear.Text == "2021-2022")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2021 and 31 March 2022";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2021 and 31 March 2022";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2021 and 31 March 2022";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2021 and 31 March 2022";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2021 and 31 March 2022";
                    }
                    s = string.Concat(Common1, Common_2021_2022, Govt, Common2);
                }

               //2022-2023
                else if (cbFinYear.Text == "2022-2023")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2022 and 31 March 2023";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2022 and 31 March 2023";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2022 and 31 March 2023";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2022 and 31 March 2023";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2022 and 31 March 2023";
                    }
                    s = string.Concat(Common1, Common_2022_2023, Govt, Common2);
                }

               //2023-2024
                else if (cbFinYear.Text == "2023-2024")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2023 and 31 March 2024";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2023 and 31 March 2024";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2023 and 31 March 2024";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2023 and 31 March 2024";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2023 and 31 March 2024";
                    }
                    s = string.Concat(Common1, Common_2023_2024, Govt, Common2);
                }

                //2024-2025
                else if (cbFinYear.Text == "2024-2025")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2024 and 31 March 2025";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2024 and 31 March 2025";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2024 and 31 March 2025";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2024 and 31 March 2025";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2024 and 31 March 2025";
                    }
                    s = string.Concat(Common1, Common_2024_2025, Govt, Common2);
                }

                //Command 
                cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSearchGovt.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found,Select Different Date!");
                    lblLetterDetails.Visible = false;

                }

                else
                {
                    lblLetterDetails.Visible = true;
                }
                dataGridViewSearchGovt.Visible = true;
                dataGridViewSearchCourt.Visible = false;
                dataGridViewSearchGovt.ForeColor = Color.Black;
                LoadSerialGovt();

            }
            catch (Exception)
            {

            }
        }

        //Search ALL CourtCase Letters from 2017
        private void Search_Court_2017()
        {
            try
            {
                string s = "";
                string Common = "";
                string Common1 = "Select Letter_No,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,GL_No_Id,Signature as SignAndDate from ";
                string Common2 = "  where Entry_Date Between @p1 and @p2 Order by GL_No_Id ";

                lblLetterDetails.Visible = true;

                //2017-2018
                if (cbFinYear.Text == "2017-2018")
                {
                    Common = " tblCourtCaseLetter_IN_2017_2018 ";
                    lblLetterDetails.Text = "The following are the Details of All CourtCase Letters Between 1st April 2017 and 31 March 2018";
                }

                //2018-2019
                else if (cbFinYear.Text == "2018-2019")
                {
                    Common = " tblCourtCaseLetter_IN_2018_2019 ";
                    lblLetterDetails.Text = "The following are the Details of All CourtCase Letters Between 1st April 2018 and 31 March 2019";
                }

               //2019-2020
                else if (cbFinYear.Text == "2019-2020")
                {
                    Common = " tblCourtCaseLetter_IN_2019_2020 ";
                    lblLetterDetails.Text = "The following are the Details of All CourtCase Letters Between 1st April 2019 and 31 March 2020";
                }
                //2020-2021
                else if (cbFinYear.Text == "2020-2021")
                {
                    Common = " tblCourtCaseLetter_IN_2020_2021 ";
                    lblLetterDetails.Text = "The following are the Details of All CourtCase Letters Between 1st April 2020 and 31 March 2021";
                }
                //2021-2022
                else if (cbFinYear.Text == "2021-2022")
                {
                    Common = " tblCourtCaseLetter_IN_2021_2022 ";
                    lblLetterDetails.Text = "The following are the Details of All CourtCase Letters Between 1st April 2021 and 31 March 2022";
                }
                //2022-2023
                else if (cbFinYear.Text == "2022-2023")
                {
                    Common = " tblCourtCaseLetter_IN_2022_2023 ";
                    lblLetterDetails.Text = "The following are the Details of All CourtCase Letters Between 1st April 2022 and 31 March 2023";
                }
                //2023-2024
                else if (cbFinYear.Text == "2023-2024")
                {
                    Common = " tblCourtCaseLetter_IN_2023_2024 ";
                    lblLetterDetails.Text = "The following are the Details of All CourtCase Letters Between 1st April 2023 and 31 March 2024";
                }
                //2024-2025
                else if (cbFinYear.Text == "2024-2025")
                {
                    Common = " tblCourtCaseLetter_IN_2024_2025 ";
                    lblLetterDetails.Text = "The following are the Details of All CourtCase Letters Between 1st April 2024 and 31 March 2025";
                }

                //Command 
                s = string.Concat(Common1, Common, Common2);
                cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSearchCourt.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found for your value");
                    lblLetterDetails.Visible = false;
                }

                else
                {
                    lblLetterDetails.Visible = true;
                }
                dataGridViewSearchCourt.Visible = true;
                dataGridViewSearchGovt.Visible = false;
                dataGridViewSearchCourt.ForeColor = Color.Black;
                LoadSerialCourt();
            }
            catch (Exception)
            {

            }
        }

        //Save ALL Letters from 2017
        private void Search_All_2017()
        {
            try
            {
                //string Common1 = "Select Letter_No, "
                //+ " CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject, "
                //+ " GL_No_Id,"
                // + " isnull(Applicant_Name,'    -----------') as ApplicantName, "
                //+ " isnull(DO_Letter, '    ------') as DOletter, "
                //+ " isnull(Right_To_Info_Letter,'    -----') as RightToInfoLetter, "
                //+ " isnull(Government_Letter,'    -----') as GovernmentLetter, "
                //+ " isnull(Lokayukta_ABS_Letter,'    -----') as LokayuktaABSLetter, "
                //+ " isnull(General_Letter, '     -------') as General_Letter from ";

                string Common1 = "Select Letter_No,CONVERT(varchar, Letter_Date, 103) as LetterDate,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,GL_No_Id,Applicant_Name,Signature as SignAndDate from ";
                string s = "";
                string Common = "";
                // string Common1 = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,"
                //+ " Hobli,Village,GL_No_Id,Signature,isnull(DO_Letter, '    ------') as DOletter,isnull(Court_Case_Letter, '   ------') as CourtCaseLetter,"
                //+ " isnull(Right_To_Info_Letter,'    -----') as RightToInfoLetter, isnull(Government_Letter,'    -----') as GovernmentLetter,"
                //+ " isnull(Lokayukta_ABS_Letter,'    -----') as LokayuktaABSLetter  from ";

                string Common2 = " Entry_Date Between @p1 and @p2 Order by GL_No_Id ";
                lblLetterDetails.Visible = true;


                //2017-2018
                if (cbFinYear.Text == "2017-2018")
                {
                    Common = " tblGovernmentLetter_IN_2017_2018  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2017 and 31 March 2018";
                }

                //2018-2019
                else if (cbFinYear.Text == "2018-2019")
                {
                    Common = " tblGovernmentLetter_IN_2018_2019  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2018 and 31 March 2019";
                }

               //2019-2020
                else if (cbFinYear.Text == "2019-2020")
                {
                    Common = " tblGovernmentLetter_IN_2019_2020  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2019 and 31 March 2020";
                }

                 //2020-2021
                else if (cbFinYear.Text == "2020-2021")
                {
                    Common = " tblGovernmentLetter_IN_2020_2021  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2020 and 31 March 2021";
                }

               //2021-2022
                else if (cbFinYear.Text == "2021-2022")
                {
                    Common = " tblGovernmentLetter_IN_2021_2022  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2021 and 31 March 2022";
                }

               //2022-2023
                else if (cbFinYear.Text == "2022-2023")
                {
                    Common = " tblGovernmentLetter_IN_2022_2023  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2022 and 31 March 2023";
                }

               //2023-2024
                else if (cbFinYear.Text == "2023-2024")
                {
                    Common = " tblGovernmentLetter_IN_2023_2024  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2023 and 31 March 2024";
                }

               //2024-2025
                else if (cbFinYear.Text == "2024-2025")
                {
                    Common = " tblGovernmentLetter_IN_2024_2025  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2024 and 31 March 2025";
                }


                //Command 
                s = string.Concat(Common1, Common, Common2);
                cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSearchGovt.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found,Select different Date");
                    lblLetterDetails.Visible = false;
                }

                else
                {
                    lblLetterDetails.Visible = true;
                }
                dataGridViewSearchGovt.Visible = true;
                dataGridViewSearchCourt.Visible = false;
                dataGridViewSearchGovt.ForeColor = Color.Black;
                LoadSerialGovt();
            }
            catch (Exception)
            {

            }
        }

        private void radLokayuktaLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radLokayuktaLetter.Checked == true)
                {
                    dataGridViewSearchGovt.Visible = true;
                    dataGridViewSearchCourt.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'LOKAYUKTA/ACB LETTER'";
                }
                else
                {
                    dataGridViewSearchGovt.Visible = false;
                    dataGridViewSearchCourt.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optDOLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (optDOLetter.Checked == true)
                {
                    dataGridViewSearchGovt.Visible = true;
                    dataGridViewSearchCourt.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'DO LETTER'";
                }
                else
                {
                    dataGridViewSearchGovt.Visible = false;
                    dataGridViewSearchCourt.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optGeneralLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optGeneralLetter.Checked == true)
                {
                    dataGridViewSearchGovt.Visible = true;
                    dataGridViewSearchCourt.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'GENERAL LETTER'";
                }
                else
                {
                    dataGridViewSearchGovt.Visible = false;
                    dataGridViewSearchCourt.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optGovtLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optGovtLetter.Checked == true)
                {
                    dataGridViewSearchGovt.Visible = true;
                    dataGridViewSearchCourt.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'GOVERNMENT LETTER'";
                }
                else
                {
                    dataGridViewSearchGovt.Visible = false;
                    dataGridViewSearchCourt.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optRightToInformationLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRightToInformationLetter.Checked == true)
                {
                    dataGridViewSearchGovt.Visible = true;
                    dataGridViewSearchCourt.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'RTI LETTER'";
                }
                else
                {
                    dataGridViewSearchGovt.Visible = false;
                    dataGridViewSearchCourt.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optAllGovt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optAllGovt.Checked == true)
                {
                    dataGridViewSearchGovt.Visible = true;
                    dataGridViewSearchCourt.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'ALL GOVERNMENT's LETTER'";
                }
                else
                {
                    dataGridViewSearchGovt.Visible = false;
                    dataGridViewSearchCourt.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void radCourtCaseLetter_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (radCourtCaseLetter.Checked == true)
                {
                    dataGridViewSearchCourt.Visible = true;
                    dataGridViewSearchGovt.Visible = false;
                }
                else
                {
                    dataGridViewSearchCourt.Visible = false;
                    dataGridViewSearchGovt.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbFinYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFinYear.Text == "2017-2018")
                {
                    lblDateBetween.Text = "1st April 2017 and 31 March 2018";
                }
                else if (cbFinYear.Text == "2018-2019")
                {
                    lblDateBetween.Text = "1st April 2018 and 31 March 2019";
                }
                else if (cbFinYear.Text == "2019-2020")
                {
                    lblDateBetween.Text = "1st April 2019 and 31 March 2020";
                }
                else if (cbFinYear.Text == "2020-2021")
                {
                    lblDateBetween.Text = "1st April 2020 and 31 March 2021";
                }
                else if (cbFinYear.Text == "2021-2022")
                {
                    lblDateBetween.Text = "1st April 2021 and 31 March 2022";
                }
                else if (cbFinYear.Text == "2022-2023")
                {
                    lblDateBetween.Text = "1st April 2022 and 31 March 2023";
                }
                else if (cbFinYear.Text == "2023-2024")
                {
                    lblDateBetween.Text = "1st April 2023 and 31 March 2024";
                }
                else if (cbFinYear.Text == "2024-2025")
                {
                    lblDateBetween.Text = "1st April 2024 and 31 March 2025";
                }
                lblDateBetween.BackColor = System.Drawing.Color.Red;

            }
            catch (Exception)
            {

            }
        }


        private void LoadFinYear()
        {
            try
            {
                if (lblFinYearValue.Text == "2017-2018")
                {
                    cbFinYear.Text = "2017-2018";
                }
                else if (lblFinYearValue.Text == "2018-2019")
                {
                    cbFinYear.Text = "2018-2019";
                }
                else if (lblFinYearValue.Text == "2019-2020")
                {
                    cbFinYear.Text = "2019-2020";
                }
                else if (lblFinYearValue.Text == "2020-2021")
                {
                    cbFinYear.Text = "2020-2021";
                }
                else if (lblFinYearValue.Text == "2021-2022")
                {
                    cbFinYear.Text = "2021-2022";
                }
                else if (lblFinYearValue.Text == "2022-2023")
                {
                    cbFinYear.Text = "2022-2023";
                }
                else if (lblFinYearValue.Text == "2023-2024")
                {
                    cbFinYear.Text = "2023-2024";
                }
                else if (lblFinYearValue.Text == "2024-2025")
                {
                    cbFinYear.Text = "2024-2025";
                }

            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewSearchGovt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadSerialGovt();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewSearchCourt_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadSerialCourt();
            }
            catch (Exception)
            {

            }
        }
    }
}
