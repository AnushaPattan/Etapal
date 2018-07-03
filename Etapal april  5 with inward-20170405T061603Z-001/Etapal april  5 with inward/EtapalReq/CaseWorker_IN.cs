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
using System.Configuration;
//using EtapalUpdatedNew;


namespace EtapalReq
{
    public partial class CaseWorker_IN : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public CaseWorker_IN()
        {
            InitializeComponent();
        }


        private void CaseWorker_IN_Load(object sender, EventArgs e)
        {
            try
            {
                //INDI datagrid visible
                dataGridViewSearchGovt.Visible = true;

                //Default Indi check
                optIndividualCaseWorkerLetters.Checked = true;

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

                //   radDOLetter.Checked = true;


                // dataGridView2.Visible = false;

                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                ToolTip tooltip1 = new ToolTip();
                tooltip1.SetToolTip(this.btnPrint, "Print");
                tooltip1.SetToolTip(this.btnBack, "Back to Report");
                tooltip1.SetToolTip(this.btnSearchCaseWorker, "Search");
                tooltip1.SetToolTip(this.btnBackHome, "Back to Home");


                //add Case Worker Dropdown

                SqlCommand cmd2 = new SqlCommand("select distinct CaseWorker from tblUserMgnt Order By CaseWorker", conn);
                conn.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    string name = dr2[0].ToString();
                    ddlCaseWorker.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
        }


        private void btnSearchCaseWorker_Click(object sender, EventArgs e)
        {
            try
            {
                if (optIndividualCaseWorkerLetters.Checked == true && ddlCaseWorker.SelectedIndex == -1)
                {
                    MessageBox.Show("Please  Select Any Caseworker from Dropdown !");
                    ddlCaseWorker.BackColor = Color.Red;
                }

                else if (optAllCaseWorker.Checked == true && ddlCaseWorker.SelectedIndex == -1)
                {
                    SearchAllCaseWorkers_2017();
                }
                else if (optIndividualCaseWorkerLetters.Checked == true && ddlCaseWorker.Text != "")
                {
                    Search_Indi_2017();
                }
            }
            catch (Exception)
            {

            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //if (radDOLetter.Checked == true && ddlCaseWorker.SelectedIndex != -1)
                //{
                //    Print_DO();
                //}
                ////else if (radCourtCaseLetter.Checked == true && ddlCaseWorker.SelectedIndex != -1)
                ////{
                ////    Print_Court_Case();
                ////}
                //else if (radRightToInformationLetter.Checked == true && ddlCaseWorker.SelectedIndex != -1)
                //{
                //    Print_Right_To_Info_Letter();
                //}
                //else if (radGovtLetter.Checked == true && ddlCaseWorker.SelectedIndex != -1)
                //{
                //    Print_Government_Letter();
                //}
                //else if (optLokayuktaLetter.Checked == true && ddlCaseWorker.SelectedIndex != -1)
                //{
                //    Print_Lokayukta_ABS_Letter();
                //}
                //else if (radGeneralLetter.Checked == true && ddlCaseWorker.SelectedIndex != -1)
                //{
                //    Print_General_Letter();
                //}


                if (optAllCaseWorker.Checked == true && ddlCaseWorker.SelectedIndex == -1)
                {
                    Print_All_Letters();
                }
                else if (optIndividualCaseWorkerLetters.Checked == true && ddlCaseWorker.SelectedIndex != -1)
                {
                    Print_Indi_Letters();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Print_All_Letters()
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
                printer.SubTitle = "Date of Entry : " + dateTimePickerFromDate.Value.ToShortDateString() + " to  " + dateTimePickerToDate.Value.ToShortDateString() + " Type of Letter : All Govt's Letters Ordered by CaseWorker's ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                // printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView2);
            }
            catch (Exception)
            {

            }
        }

        private void Print_Indi_Letters()
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
                printer.SubTitle = "Date of Entry : " + dateTimePickerFromDate.Value.ToShortDateString() + " to  " + dateTimePickerToDate.Value.ToShortDateString() + " Type of Letter : Government Letters : '" + ddlCaseWorker.Text + "' ";
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

        private void optAllCaseWorker_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optAllCaseWorker.Checked == true)
                {
                    ddlCaseWorker.SelectedIndex = -1;
                    dataGridView2.Visible = true;

                    dataGridViewSearchGovt.Visible = false;

                    //  grpAllCase.Visible = true;
                    //  grpIndi.Visible = false;
                    lblSelectCaseworker.Visible = false;
                    ddlCaseWorker.Visible = false;
                }
                else
                {
                    dataGridView2.Visible = false;

                    dataGridViewSearchGovt.Visible = true;
                    //  grpAllCase.Visible = false;
                    //  grpIndi.Visible = true;
                    lblSelectCaseworker.Visible = true;
                    ddlCaseWorker.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optIndividualCaseWorkerLetters_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optIndividualCaseWorkerLetters.Checked == true)
                {
                    ddlCaseWorker.SelectedIndex = -1;


                    dataGridView2.Visible = false;

                    lblSelectCaseworker.Visible = true;
                    ddlCaseWorker.Visible = true;
                    // grpIndi.Visible = true;
                    // grpAllCase.Visible = false;
                }
                else
                {
                    dataGridView2.Visible = true;

                    //  grpIndi.Visible = false;
                    //  grpAllCase.Visible = true;
                    lblSelectCaseworker.Visible = false;
                    ddlCaseWorker.Visible = false;
                }
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

        // Method for Generating Serial Numbers for ALL letters
        private void LoadSerialAll()
        {
            try
            {
                int i = 1;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    row.Cells["SlNoAllCase"].Value = i;
                    i++;
                }
            }
            catch (Exception)
            {

            }
        }

        // Method for Generating Serial Numbers for INDI letters
        private void LoadSerialGovt()
        {
            try
            {
                int i = 1;
                foreach (DataGridViewRow row in dataGridViewSearchGovt.Rows)
                {
                    row.Cells["SlNoGovtIndi"].Value = i;
                    i++;
                }

            }
            catch (Exception)
            {

            }
        }


        //Load Fin Year value
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

        private void Search_Indi_2017()
        {
            try
            {
                string s = "";
                string Common = "";
                string Common1 = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Letter_Date, 103) as LetterDateCRD ,Applicant_Name,Subject,"
                      + "ToSection,ToCaseWorker,Signature,FromDept,FromOffice from ";
                string Common2 = " where ToCaseWorker = N'" + ddlCaseWorker.Text + "' and Entry_Date between @p1 and @p2  order by ToCaseWorker";
                // string Common2 = "  tblGovernmentLetter_IN ";

                //2017-2018
                if (cbFinYear.Text == "2017-2018")
                {
                    Common = " tblGovernmentLetter_IN_2017_2018   ";
                    //    lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2017 and 31 March 2018";
                }

                //2018-2019
                else if (cbFinYear.Text == "2018-2019")
                {
                    Common = " tblGovernmentLetter_IN_2018_2019   ";
                    //  lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2018 and 31 March 2019";
                }

               //2019-2020
                else if (cbFinYear.Text == "2019-2020")
                {
                    Common = " tblGovernmentLetter_IN_2019_2020   ";
                    //   lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2019 and 31 March 2020";
                }

                 //2020-2021
                else if (cbFinYear.Text == "2020-2021")
                {
                    Common = " tblGovernmentLetter_IN_2020_2021   ";
                    //  lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2020 and 31 March 2021";
                }

               //2021-2022
                else if (cbFinYear.Text == "2021-2022")
                {
                    Common = " tblGovernmentLetter_IN_2021_2022   ";
                    //  lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2021 and 31 March 2022";
                }

               //2022-2023
                else if (cbFinYear.Text == "2022-2023")
                {
                    Common = " tblGovernmentLetter_IN_2022_2023   ";
                    //   lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2022 and 31 March 2023";
                }

               //2023-2024
                else if (cbFinYear.Text == "2023-2024")
                {
                    Common = " tblGovernmentLetter_IN_2023_2024   ";
                    // lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2023 and 31 March 2024";
                }

               //2024-2025
                else if (cbFinYear.Text == "2024-2025")
                {
                    Common = " tblGovernmentLetter_IN_2024_2025   ";
                    //  lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2024 and 31 March 2025";
                }

                //Final Query 
                s = string.Concat(Common1, Common, Common2);
                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSearchGovt.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found for CaseWorker : " + "'" + ddlCaseWorker.Text + "'");
                    ddlCaseWorker.SelectedIndex = -1;
                }
                dataGridViewSearchGovt.ForeColor = Color.Black;
                LoadSerialGovt();
            }
            catch (Exception)
            {

            }

        }

        private void SearchAllCaseWorkers_2017()
        {
            try
            {
                lblLetterHeading.Text = "The Following are the All Government Letters";
                string s = "";
                string Common = "";
                string Common1 = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Letter_Date, 103) as LetterDateCRAll ,Applicant_Name,Subject,"
                + "ToSection,ToCaseWorker,Signature,FromDept,FromOffice from ";
                // string Common3 = " tblGovernmentLetter_IN " ;
                string Common2 = " where Entry_Date between @p1 and @p2  order by Gl_No_Id";

                //2017-2018
                if (cbFinYear.Text == "2017-2018")
                {
                    Common = " tblGovernmentLetter_IN_2017_2018   ";
                    //    lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2017 and 31 March 2018";
                }

                //2018-2019
                else if (cbFinYear.Text == "2018-2019")
                {
                    Common = " tblGovernmentLetter_IN_2018_2019   ";
                    //  lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2018 and 31 March 2019";
                }

               //2019-2020
                else if (cbFinYear.Text == "2019-2020")
                {
                    Common = " tblGovernmentLetter_IN_2019_2020   ";
                    //   lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2019 and 31 March 2020";
                }

                 //2020-2021
                else if (cbFinYear.Text == "2020-2021")
                {
                    Common = " tblGovernmentLetter_IN_2020_2021   ";
                    //  lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2020 and 31 March 2021";
                }

               //2021-2022
                else if (cbFinYear.Text == "2021-2022")
                {
                    Common = " tblGovernmentLetter_IN_2021_2022   ";
                    //  lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2021 and 31 March 2022";
                }

               //2022-2023
                else if (cbFinYear.Text == "2022-2023")
                {
                    Common = " tblGovernmentLetter_IN_2022_2023   ";
                    //   lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2022 and 31 March 2023";
                }

               //2023-2024
                else if (cbFinYear.Text == "2023-2024")
                {
                    Common = " tblGovernmentLetter_IN_2023_2024   ";
                    // lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2023 and 31 March 2024";
                }

               //2024-2025
                else if (cbFinYear.Text == "2024-2025")
                {
                    Common = " tblGovernmentLetter_IN_2024_2025   ";
                    //  lblLetterHeading.Text = "The following are the Details of All Government Letters Between 1st April 2024 and 31 March 2025";
                }

                //Final Query 
                s = string.Concat(Common1, Common, Common2);
                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found for CaseWorker : " + "'" + ddlCaseWorker.Text + "'");
                    ddlCaseWorker.SelectedIndex = -1;
                }
                dataGridView2.ForeColor = Color.Black;
                LoadSerialAll();
            }

            catch (Exception)
            {

            }
        }

        private void ddlCaseWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ddlCaseWorker.BackColor = Color.PowderBlue;
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

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadSerialAll();
            }
            catch (Exception)
            {

            }
        }
    }
}

