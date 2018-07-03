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
    public partial class ChangeCaseWorker : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlCommand cmd;
        public ChangeCaseWorker()
        {
            InitializeComponent();
        }

        private void ChangeCaseWorker_Load(object sender, EventArgs e)
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

                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                //Default
                optGovtLetter.Checked = true;

                //Label
                lblHeadingGovt.Text = "Note : You have selected Government Letter to make Changes";
                lblHeadingCourt.Text = "Note : You have selected Court Case Letter to make Changes";
                lblHeadingCourt.Visible = false;
                //lblHeadingGovt.Visible = false;


                //Tooltips

                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnSave, "Save");
                toolTip1.SetToolTip(this.btnBack, "Back");

                //Load Fin Year
                LoadFinYear();


                // Add Section Dropdown
                SqlCommand cmd1 = new SqlCommand("select distinct section from tblSubsectionManagement Order by section", conn);
                conn.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    string name = dr1[0].ToString();
                    cbNewToSection.Items.Add(name);
                }
                conn.Close();

                //add Case Worker Dropdown

                SqlCommand cmd2 = new SqlCommand("select distinct CaseWorker from tblUserMgnt Order by CaseWorker ", conn);
                conn.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                //  AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr2.Read())
                {
                    string name = dr2[0].ToString();
                    cbNewToCaseWorker.Items.Add(name);
                    // MyCollection.Add(dr2.GetString(0));
                }
                //   cbNewToCaseWorker.AutoCompleteCustomSource = MyCollection;
                conn.Close();
                //  Add Subsection Dropdown

                SqlCommand cmd4 = new SqlCommand("select distinct Subsection from tblSubsectionManagement Order by Subsection", conn);
                conn.Open();
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    string name = dr4[0].ToString();
                    cbNewToSubsection.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception)
            {

            }

        }


        //Search Court
        private void Search_GLNo_Court_2017()
        {
            try
            {
                string Common2 = "";
                string Common1 = "Select ToCaseWorker,ToSection,ToSubsection from ";
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
                    txtOldCaseworker.Text = dr[0].ToString();
                    txtOldToSection.Text = dr[1].ToString();
                    txtOldToSubsection.Text = dr[2].ToString();

                    grpOld.Visible = true;
                    grpNew.Visible = true;
                    // lblGlNo.Visible = true;
                    //  lblNo.Text = "The Entered GL Number is " + txtGLNo.Text + "";

                }
                else
                {
                    MessageBox.Show("No Document's Found for your entered Gl Number : " + "" + txtGLNo.Text + "" + Environment.NewLine + "Enter Valid GL Number");
                    grpOld.Visible = false;
                    grpNew.Visible = false;
                    lblGlNo.Visible = false;
                }
                conn.Close();
                CleartextBoxes2();
                ClearComboBox();
            }
            catch (Exception)
            {

            }
        }

        //Search Govt
        private void Search_GLNo_Govt_2017()
        {
            try
            {
                string Common2 = "";
                string Common1 = "Select ToCaseWorker,ToSection,ToSubsection from ";
                // string Common3 = " tblCourtCaseLetter_IN ";
                string Common3 = " where GL_No_Id = @GL_No_Id";
                string s = "";

                if (cbFinYear.Text == "2017-2018")
                {
                    Common2 = " tblGovernmentLetter_IN_2017_2018 ";
                }
                else if (cbFinYear.Text == "2018-2019")
                {
                    Common2 = " tblGovernmentLetter_IN_2018_2019 ";
                }
                else if (cbFinYear.Text == "2019-2020")
                {
                    Common2 = " tblGovernmentLetter_IN_2019_2020 ";
                }
                else if (cbFinYear.Text == "2020-2021")
                {
                    Common2 = " tblGovernmentLetter_IN_2020_2021 ";
                }
                else if (cbFinYear.Text == "2021-2022")
                {
                    Common2 = " tblGovernmentLetter_IN_2021_2022 ";
                }
                else if (cbFinYear.Text == "2022-2023")
                {
                    Common2 = " tblGovernmentLetter_IN_2022_2023 ";
                }
                else if (cbFinYear.Text == "2023-2024")
                {
                    Common2 = " tblGovernmentLetter_IN_2023_2024 ";
                }
                else if (cbFinYear.Text == "2024-2025")
                {
                    Common2 = " tblGovernmentLetter_IN_2024_2025 ";
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
                    txtOldCaseworker.Text = dr[0].ToString();
                    txtOldToSection.Text = dr[1].ToString();
                    txtOldToSubsection.Text = dr[2].ToString();

                    grpOld.Visible = true;
                    grpNew.Visible = true;
                    // lblGlNo.Visible = true;
                    //  lblGlNo.Text = "The Entered GL Number is " + txtGLNo.Text + "";

                }
                else
                {
                    MessageBox.Show("No Document's Found for your entered Gl Number : " + "" + txtGLNo.Text + "" + Environment.NewLine + "Enter Valid GL Number");
                    grpOld.Visible = false;
                    grpNew.Visible = false;
                    lblGlNo.Visible = false;
                }
                conn.Close();
                CleartextBoxes2();
                ClearComboBox();
            }
            catch (Exception)
            {

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (optGovtLetter.Checked == false && optCourtCaseLetter.Checked == false)
                {
                    MessageBox.Show("Please Select Category to Search : Government Letter or Court Case Letter");
                }
                else if (optGovtLetter.Checked == true && optCourtCaseLetter.Checked == false)
                {
                    Search_GLNo_Govt_2017();
                }
                else if (optGovtLetter.Checked == false && optCourtCaseLetter.Checked == true)
                {
                    Search_GLNo_Court_2017();
                }
            }
            catch (Exception)
            {

            }

        }

        public void CleartextBoxes2()
        {
            try
            {
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is TextBox)
                    {
                        this.Controls[i].Text = "";
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        public void ClearComboBox()
        {
            try
            {
                cbNewToCaseWorker.SelectedIndex = -1;
                cbNewToSection.SelectedIndex = -1;
                cbNewToSubsection.SelectedIndex = -1;
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

        private void btnBack1_Click(object sender, EventArgs e)
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

        private void optCourtCaseLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optGovtLetter.Checked == false && optCourtCaseLetter.Checked == true)
                {
                    lblHeadingCourt.Visible = true;
                    lblHeadingGovt.Visible = false;
                }
                else
                {
                    lblHeadingCourt.Visible = false;
                    lblHeadingGovt.Visible = true;
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
                if (optGovtLetter.Checked == true && optCourtCaseLetter.Checked == false)
                {
                    lblHeadingGovt.Visible = true;
                    lblHeadingCourt.Visible = false;
                }
                else
                {
                    lblHeadingGovt.Visible = false;
                    lblHeadingCourt.Visible = true;
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

        //  Save Court New Details
        private void Save_Court_Case_Letter_2017()
        {
            try
            {
                string s = "";
                string Court_Case_Letter_str = "CourtCaseLetter";
                string Common1 = " Update ";
                string Common2 = "";
                // string Common2  = " tblCourtCaseLetter_IN ";
                string Common3 = " set "
                                    + " ToSection = N'" + cbNewToSection.Text + "', "
                                    + " ToCaseWorker = N'" + cbNewToCaseWorker.Text + "', "
                                    + " ToSubsection = N'" + cbNewToSubsection.Text + "' "
                                    + "  where GL_No_Id = " + txtGLNo.Text + " ";

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
                cmd.Parameters.AddWithValue("@Court_Case_Letter", Court_Case_Letter_str);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Details Update Successfully for GL No : " + txtGLNo.Text);
                }
                conn.Close();
                grpOld.Visible = false;
                grpNew.Visible = false;

            }

            catch (Exception)
            {

            }
        }

        //  Save Govt New Details
        private void Save_Govt_2017()
        {
            try
            {
                string s = "";
                string Common1 = "Update ";
                string Common2 = "";
                // string Common2 = "   tblGovernmentLetter_IN ";
                string Common3 = " set "
                                     + " ToSection = N'" + cbNewToSection.Text + "',"
                                     + " ToCaseWorker = N'" + cbNewToCaseWorker.Text + "',"
                                     + " ToSubsection = N'" + cbNewToSubsection.Text + "'"
                                     + " where GL_No_Id = " + txtGLNo.Text + "";

                if (cbFinYear.Text == "2017-2018")
                {
                    Common2 = " tblGovernmentLetter_IN_2017_2018 ";
                }
                else if (cbFinYear.Text == "2018-2019")
                {
                    Common2 = " tblGovernmentLetter_IN_2018_2019 ";
                }
                else if (cbFinYear.Text == "2019-2020")
                {
                    Common2 = " tblGovernmentLetter_IN_2019_2020 ";
                }
                else if (cbFinYear.Text == "2020-2021")
                {
                    Common2 = " tblGovernmentLetter_IN_2020_2021 ";
                }
                else if (cbFinYear.Text == "2021-2022")
                {
                    Common2 = " tblGovernmentLetter_IN_2021_2022 ";
                }
                else if (cbFinYear.Text == "2022-2023")
                {
                    Common2 = " tblGovernmentLetter_IN_2022_2023 ";
                }
                else if (cbFinYear.Text == "2023-2024")
                {
                    Common2 = " tblGovernmentLetter_IN_2023_2024 ";
                }
                else if (cbFinYear.Text == "2024-2025")
                {
                    Common2 = " tblGovernmentLetter_IN_2024_2025 ";
                }
                //Final Query
                s = string.Concat(Common1, Common2, Common3);
                //Command
                cmd = new SqlCommand(s, conn);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Details Update Successfully for GL No : " + txtGLNo.Text);
                }
                conn.Close();
                grpOld.Visible = false;
                grpNew.Visible = false;
            }

            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
            if (optGovtLetter.Checked == false && optCourtCaseLetter.Checked == false)
            {
                MessageBox.Show("Please Select Category to Search : Government Letter or Court Case Letter");
            }

            else if (optGovtLetter.Checked == true && optCourtCaseLetter.Checked == false)
            {
                Save_Govt_2017();

            }

            else if (optCourtCaseLetter.Checked == true && optGovtLetter.Checked == false)
            {
                Save_Court_Case_Letter_2017();
            }
            }
            catch (Exception)
            {

            }
        }
    }
}

