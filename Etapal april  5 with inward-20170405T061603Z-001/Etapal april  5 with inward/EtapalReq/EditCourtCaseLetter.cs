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
    public partial class EditCourtCaseLetter : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlCommand cmd;

        public EditCourtCaseLetter()
        {
            InitializeComponent();
        }

        private void EditCourtCaseLetter_Load(object sender, EventArgs e)
        {
            try
            {
                //Today Date
                DateTime Today = DateTime.Now;
                lblTodayValue.Text = Today.ToString();

                //Full screen code
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                //Hide groupbox
                grpCourt.Visible = false;
                lblGlNo.Visible = false;

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
                //return FinYear.Trim();
                // Hide Other dept

                txtDeptOthers.Visible = false;
                lblOtherDept.Visible = false;

                // Label for Financial Year
                //DateTime date = new DateTime(DateTime.Today.Year,3,1);
                //lblFinYearValue.Text = date.ToShortDateString();

                //Tooltips

                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnSave, "Save");
                toolTip1.SetToolTip(this.btnBack, "Back");

                //Load Fin Year
                LoadFinYear();

                // Add Section Dropdown
                SqlCommand cmd1 = new SqlCommand("select distinct section from tblSubsectionManagement Order By section", conn);
                conn.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    string name = dr1[0].ToString();
                    cbToSection.Items.Add(name);
                }
                conn.Close();

                //add Case Worker Dropdown

                SqlCommand cmd2 = new SqlCommand("select distinct CaseWorker from tblUserMgnt Order By CaseWorker", conn);
                conn.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    string name = dr2[0].ToString();
                    cbToCaseWorker.Items.Add(name);
                }
                conn.Close();

                // Add Department Dropdown
                SqlCommand cmd3 = new SqlCommand("select distinct Department_Name from tblDepartment Order By Department_Name", conn);
                conn.Open();
                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    string name = dr3[0].ToString();
                    cbDept.Items.Add(name);
                }
                conn.Close();

                //  Add Subsection Dropdown

                SqlCommand cmd4 = new SqlCommand("select distinct Subsection from tblSubsectionManagement Order By Subsection", conn);
                conn.Open();
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    string name = dr4[0].ToString();
                    cbToSubsection.Items.Add(name);
                }
                conn.Close();

                //Add FromOffice Dropdown
                SqlCommand cmd5 = new SqlCommand("Select distinct FromOffice from tblDepartment Order By FromOffice", conn);
                conn.Open();
                SqlDataReader dr5 = cmd5.ExecuteReader();
                while (dr5.Read())
                {
                    string name = dr5[0].ToString();
                    cbOffice.Items.Add(name);
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
                if (txtGLNo.Text == "")
                {
                    MessageBox.Show("Enter GL Number to Search!");
                }
                else if (txtGLNo.Text != "")
                {
                    Search_GLNo_2017();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Search_GLNo_2017()
        {
            try
            {
                txtDeptOthers.Visible = true;
                string Common2 = "";
                string Common1 = "Select Inward_No,Letter_No,Received_Date,Letter_Date,Entry_Date,Subject,FromDept,FromOffice,ToSection,ToSubsection,ToCaseWorker,From_Other_Dept from ";
                // string Common3 = " tblCourtCaseLetter_IN ";
                string Common3 = " where GL_No_Id = @GL_No_Id";
                string s = "";

                if (cbFinYear.Text == "2017-2018")
                {
                    Common2 = " tblCourtCaseLetter_IN_2017_2018 ";
                }
                else if (cbFinYear.Text == "2018-2019")
                {
                    Common2 = " tblCourtCaseLetter_IN_2018_2019 ";
                }
                else if (cbFinYear.Text == "2019-2020")
                {
                    Common2 = " tblCourtCaseLetter_IN_2019_2020 ";
                }
                else if (cbFinYear.Text == "2020-2021")
                {
                    Common2 = " tblCourtCaseLetter_IN_2020_2021 ";
                }
                else if (cbFinYear.Text == "2021-2022")
                {
                    Common2 = " tblCourtCaseLetter_IN_2021_2022 ";
                }
                else if (cbFinYear.Text == "2022-2023")
                {
                    Common2 = " tblCourtCaseLetter_IN_2022_2023 ";
                }
                else if (cbFinYear.Text == "2023-2024")
                {
                    Common2 = " tblCourtCaseLetter_IN_2023_2024 ";
                }
                else if (cbFinYear.Text == "2024-2025")
                {
                    Common2 = " tblCourtCaseLetter_IN_2024_2025 ";
                }
                //Final Query
                s = string.Concat(Common1, Common2, Common3);

                //Command
                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@GL_No_Id", txtGLNo.Text);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtInwardNo.Text = dr[0].ToString();
                    txtLetterNumber.Text = dr[1].ToString();
                    dateTimePickerReceivedDate.Text = dr[2].ToString();
                    dateTimePickerLetterDate.Text = dr[3].ToString();
                    dateTimePickerEntryDate.Text = dr[4].ToString();
                    txtSubject.Text = dr[5].ToString();
                    cbDept.Text = dr[6].ToString();
                    cbOffice.Text = dr[7].ToString();
                    cbToSection.Text = dr[8].ToString();
                    cbToSubsection.Text = dr[9].ToString();
                    cbToCaseWorker.Text = dr[10].ToString();
                    txtDeptOthers.Text = dr[11].ToString();

                    grpCourt.Visible = true;
                    lblGlNo.Visible = true;
                    lblGlNo.Text = "The Entered GL Number is " + txtGLNo.Text + "";

                }
                else
                {
                    MessageBox.Show("No Document's Found for your entered Gl Number : " + "" + txtGLNo.Text + "" + Environment.NewLine + "Enter Valid GL Number");
                    grpCourt.Visible = false;
                    lblGlNo.Visible = false;
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
        }




        // Save Court Case Letter Function

        //private void Save_Court_Case_Letter()
        //{
        //    try
        //    {
        //        string Court_Case_Letter_str = "CourtCaseLetter";
        //        //string Received_Date = dateTimePickerReceivedDate.Value.ToShortDateString();
        //        //string Letter_Date = dateTimePickerLetterDate.Value.ToShortDateString();
        //        //string Entry_Date = dateTimePickerEntryDate.Value.ToShortDateString();
        //        // string InsertData = "Insert into tblCourtCaseLetter_IN(Court_Case_Letter,Letter_No,Received_Date,Letter_Date,FromDept,From_Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Hobli,Village,Inward_No,ToSubsection,Entry_Date,Survey_No,Applicant_Name)" +
        //        //   "values(@Court_Case_Letter,N'" + txtLetterNumber.Text + "',@Received_Date,@Letter_Date,N'" + cbDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + txtOffice.Text + "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "',N'" + txtHobli.Text + "',N'" + txtVillage.Text + "',N'" + txtInwardNo.Text + "',N'" + cbToSubsection.Text + "',@Entry_Date,N'" + txtSurveyNo.Text + "',N'" + txtApplicantName.Text + "')";
        //        string UpdateData = "Update tblCourtCaseLetter_IN"
        //                            + " set Court_Case_Letter = @Court_Case_Letter,"
        //                            + "Letter_No = N'" + txtLetterNumber.Text + "',"
        //                            + "Received_Date = @Received_Date,"
        //                            + "Letter_Date = @Letter_Date,"
        //                            + "FromDept = N'" + cbDept.Text + "',"
        //                            + "From_Other_Dept = N'" + txtDeptOthers.Text + "',"
        //                            + "FromOffice = N'" + txtOffice.Text + "',"
        //                            + "Subject = N'" + txtSubject.Text + "',"
        //                            + "ToSection = N'" + cbToSection.Text + "',"
        //                            + "ToCaseWorker = N'" + cbToCaseWorker.Text + "',"
        //                            + "Hobli = N'" + txtHobli.Text + "',"
        //                            + "Village = N'" + txtVillage.Text + "',"
        //                            + "Inward_No = N'" + txtInwardNo.Text + "',"
        //                            + "ToSubsection = N'" + cbToSubsection.Text + "',"
        //                            + "Entry_Date = @Entry_Date,"
        //                            + "Survey_No = N'" + txtSurveyNo.Text + "',"
        //                            + "Applicant_Name = N'" + txtApplicantName.Text + "'"
        //                            + "where GL_No_Id = " + txtGLNo.Text + "";
        //        cmd = new SqlCommand(UpdateData, conn);
        //        cmd.Parameters.AddWithValue("@Court_Case_Letter", Court_Case_Letter_str);
        //        cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.Date);
        //        cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.Date);
        //        cmd.Parameters.AddWithValue("@Entry_Date", dateTimePickerEntryDate.Value.Date);
        //        conn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            MessageBox.Show("Details Update Successfully for GL No : " + txtGLNo.Text);
        //        }
        //        conn.Close();
        //        CleartextBoxes2();
        //        grpCourt.Visible = false;
        //    }

        //    catch (Exception)
        //    {

        //    }
        //}

        private void Save_Court_Case_Letter_2017()
        {
            try
            {
                string s = "";
                string Court_Case_Letter_str = "CourtCaseLetter";
                string Common1 = "Update ";
                string Common2 = "";
                // string Common2  = " tblCourtCaseLetter_IN ";
                string Common3 = "  set Court_Case_Letter = @Court_Case_Letter,"
                                    + "Letter_No = N'" + txtLetterNumber.Text + "',"
                                    + "Received_Date = @Received_Date,"
                                    + "Letter_Date = @Letter_Date,"
                                    + "FromDept = N'" + cbDept.Text + "',"
                                    + "From_Other_Dept = N'" + txtDeptOthers.Text + "',"
                                    + "FromOffice = N'" + cbOffice.Text + "',"
                                    + "Subject = N'" + txtSubject.Text + "',"
                                    + "ToSection = N'" + cbToSection.Text + "',"
                                    + "ToCaseWorker = N'" + cbToCaseWorker.Text + "',"
                                    + "Inward_No = N'" + txtInwardNo.Text + "',"
                                    + "ToSubsection = N'" + cbToSubsection.Text + "',"
                                    + "Entry_Date = @Entry_Date"
                                    + " where GL_No_Id =  @GL_No_Id";

                if (cbFinYear.Text == "2017-2018")
                {
                    Common2 = " tblCourtCaseLetter_IN_2017_2018 ";
                }
                else if (cbFinYear.Text == "2018-2019")
                {
                    Common2 = " tblCourtCaseLetter_IN_2018_2019 ";
                }
                else if (cbFinYear.Text == "2019-2020")
                {
                    Common2 = " tblCourtCaseLetter_IN_2019_2020 ";
                }
                else if (cbFinYear.Text == "2020-2021")
                {
                    Common2 = " tblCourtCaseLetter_IN_2020_2021 ";
                }
                else if (cbFinYear.Text == "2021-2022")
                {
                    Common2 = " tblCourtCaseLetter_IN_2021_2022 ";
                }
                else if (cbFinYear.Text == "2022-2023")
                {
                    Common2 = " tblCourtCaseLetter_IN_2022_2023 ";
                }
                else if (cbFinYear.Text == "2023-2024")
                {
                    Common2 = " tblCourtCaseLetter_IN_2023_2024 ";
                }
                else if (cbFinYear.Text == "2024-2025")
                {
                    Common2 = " tblCourtCaseLetter_IN_2024_2025 ";
                }
                //Final Query
                s = string.Concat(Common1, Common2, Common3);
                //Command
                cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@GL_No_Id", txtGLNo.Text);
                cmd.Parameters.AddWithValue("@Court_Case_Letter", Court_Case_Letter_str);
                cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.Date);
                cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.Date);
                cmd.Parameters.AddWithValue("@Entry_Date", dateTimePickerEntryDate.Value.Date);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Details Update Successfully for GL No : " + txtGLNo.Text);
                }
                conn.Close();
                grpCourt.Visible = false;
            }

            catch (Exception)
            {

            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var Home = new Home();
                Home.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                Save_Court_Case_Letter_2017();
                lblGlNo.Visible = false;
                txtGLNo.Text = "";
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

        private void cbFinYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFinYear.Text == "2017-2018")
                {
                    lblDateBetween.Text = "You have selected 2017-2018";
                }
                else if (cbFinYear.Text == "2018-2019")
                {
                    lblDateBetween.Text = "You have selected 2018-2019";
                }
                else if (cbFinYear.Text == "2019-2020")
                {
                    lblDateBetween.Text = "You have selected 2019-2020";
                }
                else if (cbFinYear.Text == "2020-2021")
                {
                    lblDateBetween.Text = "You have selected 2020-2021";
                }
                else if (cbFinYear.Text == "2021-2022")
                {
                    lblDateBetween.Text = "You have selected 2021-2022";
                }
                else if (cbFinYear.Text == "2022-2023")
                {
                    lblDateBetween.Text = "You have selected 2022-2023";
                }
                else if (cbFinYear.Text == "2023-2024")
                {
                    lblDateBetween.Text = "You have selected 2023-2024";
                }
                else if (cbFinYear.Text == "2024-2025")
                {
                    lblDateBetween.Text = "You have selected 2024-2025";
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
                var Home = new EditGovtLetter();
                Home.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
