using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EtapalReq
{
    public partial class SearchCourtCase_IN : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlCommand cmd;
        public SearchCourtCase_IN()
        {
            InitializeComponent();
        }

        private void SearchCourtCase_IN_Load(object sender, EventArgs e)
        {
            try
            {


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


                lblLetterDetails.Visible = false;

                //Load Fin Year
                LoadFinYear();

                //Default Check GL No
                optGLNo.Checked = true;

                //hide 
                grpDate.Visible = false;


                dataGridViewSearchCourt.Visible = true;

                //  LoadSerial();

                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnSearch, "Search");
                toolTip1.SetToolTip(this.btnBack, "Back");
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;


            }
            catch (Exception)
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (optGLNo.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter GL Number");
                }
                else if (optSubject.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter Subject");
                }
                else if (radLetterNo.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter Letter Number");
                }
                else if (optInwardNo.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter Inward Number");
                }
                else if (optGLNo.Checked == true || radLetterNo.Checked == true || optSubject.Checked == true || optInwardNo.Checked == true)
                {
                    Search_GlNo_2017();
                }
                else if (optCourtCaseLetter.Checked == true)
                {
                    Search_All_2017();
                }
                txtSearch.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var Back = new Home();
                Back.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        // Method for Generating Serial Numbers for Court letters
        private void LoadSerial()
        {
            try
            {

                int i = 1;
                foreach (DataGridViewRow row in dataGridViewSearchCourt.Rows)
                {
                    row.Cells["SlNoCourtSearchIN"].Value = i;
                    i++;
                }
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewSearchCourt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewSearchCourt.Columns[e.ColumnIndex].Name == "Gl_No_Id_Court")
                {

                    dataGridViewSearchCourt.Rows[e.RowIndex].ReadOnly = true;

                    // Need Important
                    string LetterNo = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string ReceiveDate = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string LetterDate = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string FromDept = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string FromOffice = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string ToSection = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string ToCaseWorker = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string Subject = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[8].Value.ToString();
                    // string Hobli = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[9].Value.ToString();
                    //  string Village = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string GLNoId = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[9].Value.ToString();
                    //  string Signature = dataGridView_All_letters.Rows[e.RowIndex].Cells[12].Value.ToString();
                    string InwardNo = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string ToSubsection = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[11].Value.ToString();
                    //string SurveyNo = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[14].Value.ToString();


                    //string DOLetter = dataGridViewSearchCourt.Rows[e.RowIndex].Cells[14].Value.ToString();
                    //string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    //string  RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();
                    //string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[17].Value.ToString();
                    //string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[18].Value.ToString();

                    // Imp
                    string message = "GL Number\t : " + GLNoId + "\nLetter Number\t : " + LetterNo + "\nInward Number\t : " + InwardNo + "\nReceived Date\t : " + ReceiveDate + "\nLetter Date\t: " + LetterDate + "\nFrom Department\t : " + FromDept + "\nFrom Office\t : " + FromOffice + "\nTo Section\t  :  " + ToSection + "\nTo Subsection\t  : " + ToSubsection + "\nTo Case Worker\t :     " + ToCaseWorker + "\nSubject\t\t :\n  " + Subject;
                    MessageBox.Show(message);
                }

                //catch (IndexOutOfRangeException)
                //{
                //    MessageBox.Show("Please click on Reference Link to View Details......");
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Please Enter valid Reference Number.......");
                //}
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewSearchCourt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadSerial();
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

        //Search GlNo,LetterNo,Subject Letters  From 2017
        private void Search_GlNo_2017()
        {
            try
            {
                string s = "";

                //Common Select query
                string Common1 = " Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate , "
                            + " FromDept,FromOffice,ToSection,ToCaseWorker,Subject,GL_No_Id,Inward_No,ToSubsection from ";

                //Table Query
                string Common_2017_2018 = " tblCourtCaseLetter_IN_2017_2018  ";
                string Common_2018_2019 = " tblCourtCaseLetter_IN_2018_2019   ";
                string Common_2019_2020 = "  tblCourtCaseLetter_IN_2019_2020   ";
                string Common_2020_2021 = " tblCourtCaseLetter_IN_2020_2021  ";
                string Common_2021_2022 = " tblCourtCaseLetter_IN_2021_2022   ";
                string Common_2022_2023 = "  tblCourtCaseLetter_IN_2022_2023   ";
                string Common_2023_2024 = " tblCourtCaseLetter_IN_2023_2024   ";
                string Common_2024_2025 = "  tblCourtCaseLetter_IN_2024_2025   ";

                //where Query
                string Common2 = " where ";

                //Conditions for //GlNo,LetterNo,Subject 
                string Common3 = " GL_No_Id ='" + txtSearch.Text + "'";
                string Common4 = " Letter_No = N'" + txtSearch.Text + "'";
                string Common5 = " (R.Subject LIKE @Search) ";
                string Common6 = " R  ";
                string Common8 = " Inward_No = N'" + txtSearch.Text + "' ";

                //Order By
                string Common7 = " Order by GL_No_Id ";

                //GlNo
                string GlNo = string.Concat(Common1, Common_2017_2018, Common2, Common3, Common7);
                //Subject
                string Subject = string.Concat(Common1, Common_2017_2018, Common6, Common2, Common5, Common7);
                //LetterNo
                string Letter = string.Concat(Common1, Common_2017_2018, Common2, Common4, Common7);
                //Inward
                string Inward = string.Concat(Common1, Common_2017_2018, Common2, Common8, Common7);



                lblLetterDetails.Visible = true;


                //2017-2018
                if (cbFinYear.Text == "2017-2018")
                {
                    if (optGLNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2017_2018, Common2, Common3, Common7);
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2017_2018, Common2, Common4, Common7);
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                    }
                    else if (optSubject.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2017_2018, Common6, Common2, Common5, Common7);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2017_2018, Common2, Common8, Common7);
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                    }
                }

                //2018-2019
                else if (cbFinYear.Text == "2018-2019")
                {
                    if (optGLNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2018_2019, Common2, Common3, Common7);
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2018_2019, Common2, Common4, Common7);
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                    }
                    else if (optSubject.Checked == true)
                    {

                        s = string.Concat(Common1, Common_2018_2019, Common6, Common2, Common5, Common7);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2018_2019, Common2, Common8, Common7);
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                    }
                }

                //2019-2020
                else if (cbFinYear.Text == "2019-2020")
                {
                    if (optGLNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2019_2020, Common2, Common3, Common7);
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2019_2020, Common2, Common4, Common7);
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                    }
                    else if (optSubject.Checked == true)
                    {

                        s = string.Concat(Common1, Common_2019_2020, Common6, Common2, Common5, Common7);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2019_2020, Common2, Common8, Common7);
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                    }
                }

            //2020-2021
                else if (cbFinYear.Text == "2020-2021")
                {
                    if (optGLNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2020_2021, Common2, Common3, Common7);
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2020_2021, Common2, Common4, Common7);
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                    }
                    else if (optSubject.Checked == true)
                    {

                        s = string.Concat(Common1, Common_2020_2021, Common6, Common2, Common5, Common7);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2020_2021, Common2, Common8, Common7);
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                    }
                }

            //2021-2022
                else if (cbFinYear.Text == "2021-2022")
                {
                    if (optGLNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2021_2022, Common2, Common3, Common7);
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2021_2022, Common2, Common4, Common7);
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                    }
                    else if (optSubject.Checked == true)
                    {

                        s = string.Concat(Common1, Common_2021_2022, Common6, Common2, Common5, Common7);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2021_2022, Common2, Common8, Common7);
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                    }
                }

            //2022-2023
                else if (cbFinYear.Text == "2022-2023")
                {
                    if (optGLNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2022_2023, Common2, Common3, Common7);
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2022_2023, Common2, Common4, Common7);
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                    }
                    else if (optSubject.Checked == true)
                    {

                        s = string.Concat(Common1, Common_2022_2023, Common6, Common2, Common5, Common7);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2022_2023, Common2, Common8, Common7);
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                    }
                }

            //2023-2024
                else if (cbFinYear.Text == "2023-2024")
                {
                    if (optGLNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2023_2024, Common2, Common3, Common7);
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2023_2024, Common2, Common4, Common7);
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                    }
                    else if (optSubject.Checked == true)
                    {

                        s = string.Concat(Common1, Common_2023_2024, Common6, Common2, Common5, Common7);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2023_2024, Common2, Common8, Common7);
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                    }
                }

            //2024-2025
                else if (cbFinYear.Text == "2024-2025")
                {
                    if (optGLNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2024_2025, Common2, Common3, Common7);
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2024_2025, Common2, Common4, Common7);
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                    }
                    else if (optSubject.Checked == true)
                    {

                        s = string.Concat(Common1, Common_2024_2025, Common6, Common2, Common5, Common7);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2024_2025, Common2, Common8, Common7);
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                    }
                }

                //Command 
                cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
                cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
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
                LoadSerial();
                dataGridViewSearchCourt.Visible = true;
                dataGridViewSearchCourt.ForeColor = Color.Black;

            }
            catch (Exception)
            {

            }
        }

        //Search ALL CourtCase Letters from 2017
        private void Search_All_2017()
        {
            try
            {
                string s = "";
                string Common = "";
                string Common1 = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,GL_No_Id,Inward_No,ToSubsection from ";
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
                LoadSerial();
                dataGridViewSearchCourt.Visible = true;
                dataGridViewSearchCourt.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        private void optGLNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optGLNo.Checked == true)
                {
                    grpNumber.Visible = true;
                    grpDate.Visible = false;
                    lblNumber.Text = "Enter GL Number(Only Numbers Allowed)";
                }
                else if (optGLNo.Checked == false)
                {
                    grpNumber.Visible = false;
                    grpDate.Visible = true;
                }

            }
            catch (Exception)
            {

            }
        }

        private void radLetterNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radLetterNo.Checked == true)
                {
                    grpNumber.Visible = true;
                    grpDate.Visible = false;
                    lblNumber.Text = "Enter Letter Number";
                }
                else if (radLetterNo.Checked == false)
                {
                    grpNumber.Visible = false;
                    grpDate.Visible = true;
                }

            }
            catch (Exception)
            {

            }
        }

        private void optInwardNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optInwardNo.Checked == true)
                {
                    grpNumber.Visible = true;
                    grpDate.Visible = false;
                    lblNumber.Text = "Enter Inward Number";
                }
                else if (optInwardNo.Checked == false)
                {
                    grpNumber.Visible = false;
                    grpDate.Visible = true;
                }

            }
            catch (Exception)
            {

            }
        }

        private void optSubject_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optSubject.Checked == true)
                {
                    grpNumber.Visible = true;
                    grpDate.Visible = false;
                    lblNumber.Text = "Enter Subject";
                }
                else if (optSubject.Checked == false)
                {
                    grpNumber.Visible = false;
                    grpDate.Visible = true;
                }

            }
            catch (Exception)
            {

            }
        }

        private void optCourtCaseLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optCourtCaseLetter.Checked == true)
                {
                    grpDate.Visible = true;
                    grpNumber.Visible = false;
                }
                else if (optCourtCaseLetter.Checked == false)
                {
                    grpDate.Visible = false;
                    grpNumber.Visible = true;
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

        private void btnGotoGovtLetterPagee_Click(object sender, EventArgs e)
        {
            try
            {
                var Back = new SearchGovernment_IN();
                Back.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
