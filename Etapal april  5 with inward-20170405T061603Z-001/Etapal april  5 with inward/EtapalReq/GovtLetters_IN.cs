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
    public partial class GovtLetters_IN : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlCommand cmd;
        string s = "";

        public GovtLetters_IN()
        {
            InitializeComponent();
        }

        // To Autoincrement GL No
        private void Auto()
        {
            try
            {
                int m = 0;
                string p = "";
                string q = " Select count(GL_No_Id) from ";
                string r = "";

                if (lblFinYearValue.Text == "2017-2018")
                {
                    r = " tblGovernmentLetter_IN_2017_2018 ";
                }
                else if (lblFinYearValue.Text == "2018-2019")
                {
                    r = " tblGovernmentLetter_IN_2018_2019 ";
                }
                else if (lblFinYearValue.Text == "2019-2020")
                {
                    r = " tblGovernmentLetter_IN_2019_2020 ";
                }
                else if (lblFinYearValue.Text == "2020-2021")
                {
                    r = " tblGovernmentLetter_IN_2020_2021 ";
                }
                else if (lblFinYearValue.Text == "2021-2022")
                {
                    r = " tblGovernmentLetter_IN_2021_2022 ";
                }
                else if (lblFinYearValue.Text == "2022-2023")
                {
                    r = " tblGovernmentLetter_IN_2022_2023 ";
                }
                else if (lblFinYearValue.Text == "2023-2024")
                {
                    r = " tblGovernmentLetter_IN_2023_2024 ";
                }
                else if (lblFinYearValue.Text == "2024-2025")
                {
                    r = " tblGovernmentLetter_IN_2024_2025 ";
                }
                else if (lblFinYearValue.Text == "2025-2026")
                {
                    r = " tblGovernmentLetter_IN_2025_2026 ";
                }
                else if (lblFinYearValue.Text == "2026-2027")
                {
                    r = " tblGovernmentLetter_IN_2026_2027 ";
                }
                else if (lblFinYearValue.Text == "2027-2028")
                {
                    r = " tblGovernmentLetter_IN_2027_2028 ";
                }
                else if (lblFinYearValue.Text == "2028-2029")
                {
                    r = " tblGovernmentLetter_IN_2028_2029 ";
                }
                else if (lblFinYearValue.Text == "2029-2030")
                {
                    r = " tblGovernmentLetter_IN_2029_2030 ";
                }
                p = string.Concat(q, r);
                cmd = new SqlCommand(p, conn);
                conn.Open();
                m = (int)cmd.ExecuteScalar();
                double o = m + 1;
                txtGLNo.Text = Convert.ToString(o);
                conn.Close();
            }
            catch (Exception)
            {

            }
        }

        private void GovtLetters_IN_Load(object sender, EventArgs e)
        {
            try
            {
                //Today Date
                DateTime Today = DateTime.Now;
                lblTodayValue.Text = Today.ToString();

                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                // Check DO

                radGovtLetter.Checked = true;


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


                // Hide Other dept

                txtDeptOthers.Visible = false;
                lblOtherDept.Visible = false;

                //Tooltips

                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnSave, "Save");
                toolTip1.SetToolTip(this.btnBack, "Back");

                // Add Section Dropdown
                SqlCommand cmd1 = new SqlCommand("select distinct section from tblSubsectionManagement section Order by section", conn);
                conn.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    string name = dr1[0].ToString();
                    cbToSection.Items.Add(name);
                }
                conn.Close();

                ////add Case Worker Dropdown

                //SqlCommand cmd2 = new SqlCommand("select distinct CaseWorker from tblUserMgnt  Order by CaseWorker", conn);
                //conn.Open();
                //SqlDataReader dr2 = cmd2.ExecuteReader();
                //while (dr2.Read())
                //{
                //    string name = dr2[0].ToString();
                //    cbToCaseWorker.Items.Add(name);
                //}
                //conn.Close();

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

                ////  Add Subsection Dropdown

                //SqlCommand cmd4 = new SqlCommand("select distinct Subsection from tblSubsectionManagement Order By Subsection", conn);
                //conn.Open();
                //SqlDataReader dr4 = cmd4.ExecuteReader();
                //while (dr4.Read())
                //{
                //    string name = dr4[0].ToString();
                //    cbToSubsection.Items.Add(name);
                //}
                //conn.Close();

                ////Add FromOffice Dropdown
                //SqlCommand cmd5 = new SqlCommand("Select distinct FromOffice from tblDepartment Order By FromOffice", conn);
                //conn.Open();
                //SqlDataReader dr5 = cmd5.ExecuteReader();
                //while (dr5.Read())
                //{
                //    string name = dr5[0].ToString();
                //    cbOffice.Items.Add(name);
                //}
                //conn.Close();

                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                // To Autoincrement GL No
                Auto();
            }
            catch (Exception)
            {

            }
        }



        public void CleartextBoxes2()
        {
            try
            {
                //for (int i = 0; i < this.Controls.Count; i++)
                //{
                //    if (this.Controls[i] is TextBox)
                //    {
                //        this.Controls[i].Text = "";
                //    }
                //}

                txtInwardNo.Text = "";
                txtLetterNumber.Text = "";
                txtSubject.Text = "";
                txtDeptOthers.Text = "";
                txtApplicantName.Text = "";

                //cbToSection.SelectedIndex = -1;
                //cbToSubsection.SelectedIndex = -1;
                //cbToCaseWorker.SelectedIndex = -1;
                //cbDept.SelectedIndex = -1;
                //cbOffice.SelectedIndex = -1;
                //chkOthers.Checked = false;

                cbToSection.SelectedIndex = -1;
                cbToCaseWorker.SelectedIndex = -1;
                cbToSubsection.SelectedIndex = -1;
                cbDept.SelectedIndex = -1;
                cbOffice.SelectedIndex = -1;
                chkOthers.Checked = false;
                cbOffice.Items.Clear();
                cbToSection.Items.Clear();

                //To auto increment

                Auto();
            }
            catch (Exception)
            {

            }
        }


        // Save Govt Letter from 2017
        private void Save_Govt_Letter_2017()
        {
            try
            {
                string Common2 = " Insert into ";

                string Common3 = " Letter_No,Received_Date,Letter_Date,FromDept,From_Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Inward_No,ToSubsection,Applicant_Name,Entry_Date) values ";

                string Common4 = " N'" + txtLetterNumber.Text + "',@Received_Date,@Letter_Date,N'" + cbDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + cbOffice.Text + "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "', " +
                           " N'" + cbToCaseWorker.Text + "',N'" + txtInwardNo.Text + "',N'" + cbToSubsection.Text + "',N'" + txtApplicantName.Text + "',@Entry_Date)";

                string Common5 = " (DO_Letter, ";
                string Common6 = " (Right_To_Info_Letter, ";
                string Common7 = " (Government_Letter, ";
                string Common8 = " (Lokayukta_ABS_Letter, ";
                string Common9 = " (General_Letter, ";

                string Common10 = " (@DO_Letter, ";
                string Common11 = " (@Right_To_Info_Letter, ";
                string Common12 = " (@Government_Letter, ";
                string Common13 = " (@Lokayukta_ABS_Letter, ";
                string Common14 = " (@General_Letter, ";

                string DO_Letter = "DOLetter";
                string Right_To_Info_Letter = "RightToInfoLetter";
                string Government_Letter = "GovernmentLetter";
                string Lokayukta_ABS_Letter = "LokayuktaLetter";
                string General_Letter = "GeneralLetter";

                //  string Common40 = string.Concat(Common2, Common18, Common6, Common30);
                //  string Common30 = string.Concat(Common3, Common11, Common4);

                string Common17 = " tblGovernmentLetter_IN_2017_2018 ";
                string Common18 = " tblGovernmentLetter_IN_2018_2019 ";
                string Common19 = " tblGovernmentLetter_IN_2019_2020 ";
                string Common20 = " tblGovernmentLetter_IN_2020_2021 ";
                string Common21 = " tblGovernmentLetter_IN_2021_2022 ";
                string Common22 = " tblGovernmentLetter_IN_2022_2023 ";
                string Common23 = " tblGovernmentLetter_IN_2023_2024 ";
                string Common24 = " tblGovernmentLetter_IN_2024_2025 ";
                string Common25 = " tblGovernmentLetter_IN_2025_2026 ";
                string Common25a = " tblGovernmentLetter_IN_2026_2027 ";
                string Common26 = " tblGovernmentLetter_IN_2027_2028 ";
                string Common27 = " tblGovernmentLetter_IN_2028_2029 ";
                string Common28 = " tblGovernmentLetter_IN_2029_2030 ";


                string Common29 = string.Concat(Common3, Common10, Common4);
                string Common30 = string.Concat(Common3, Common11, Common4);
                string Common31 = string.Concat(Common3, Common12, Common4);
                string Common32 = string.Concat(Common3, Common13, Common4);
                string Common33 = string.Concat(Common3, Common14, Common4);

                //2017-2018
                string Common34 = string.Concat(Common2, Common17, Common5, Common29);
                string Common35 = string.Concat(Common2, Common17, Common6, Common30);
                string Common36 = string.Concat(Common2, Common17, Common7, Common31);
                string Common37 = string.Concat(Common2, Common17, Common8, Common32);
                string Common38 = string.Concat(Common2, Common17, Common9, Common33);

                //2018-2019
                string Common39 = string.Concat(Common2, Common18, Common5, Common29);
                string Common40 = string.Concat(Common2, Common18, Common6, Common30);
                string Common41 = string.Concat(Common2, Common18, Common7, Common31);
                string Common42 = string.Concat(Common2, Common18, Common8, Common32);
                string Common43 = string.Concat(Common2, Common18, Common9, Common33);

                //2019-2020
                string Common44 = string.Concat(Common2, Common19, Common5, Common29);
                string Common45 = string.Concat(Common2, Common19, Common6, Common30);
                string Common46 = string.Concat(Common2, Common19, Common7, Common31);
                string Common47 = string.Concat(Common2, Common19, Common8, Common32);
                string Common48 = string.Concat(Common2, Common19, Common9, Common33);

                //2020-2021
                string Common49 = string.Concat(Common2, Common20, Common5, Common29);
                string Common50 = string.Concat(Common2, Common20, Common6, Common30);
                string Common51 = string.Concat(Common2, Common20, Common7, Common31);
                string Common52 = string.Concat(Common2, Common20, Common8, Common32);
                string Common53 = string.Concat(Common2, Common20, Common9, Common33);

                //2021-2022
                string Common54 = string.Concat(Common2, Common21, Common5, Common29);
                string Common55 = string.Concat(Common2, Common21, Common6, Common30);
                string Common56 = string.Concat(Common2, Common21, Common7, Common31);
                string Common57 = string.Concat(Common2, Common21, Common8, Common32);
                string Common58 = string.Concat(Common2, Common21, Common9, Common33);

                //2022-2023
                string Common59 = string.Concat(Common2, Common22, Common5, Common29);
                string Common60 = string.Concat(Common2, Common22, Common6, Common30);
                string Common61 = string.Concat(Common2, Common22, Common7, Common31);
                string Common62 = string.Concat(Common2, Common22, Common8, Common32);
                string Common63 = string.Concat(Common2, Common22, Common9, Common33);

                //2023-2024
                string Common64 = string.Concat(Common2, Common23, Common5, Common29);
                string Common65 = string.Concat(Common2, Common23, Common6, Common30);
                string Common66 = string.Concat(Common2, Common23, Common7, Common31);
                string Common67 = string.Concat(Common2, Common23, Common8, Common32);
                string Common68 = string.Concat(Common2, Common23, Common9, Common33);

                //2024-2025
                string Common69 = string.Concat(Common2, Common24, Common5, Common29);
                string Common70 = string.Concat(Common2, Common24, Common6, Common30);
                string Common71 = string.Concat(Common2, Common24, Common7, Common31);
                string Common72 = string.Concat(Common2, Common24, Common8, Common32);
                string Common73 = string.Concat(Common2, Common24, Common9, Common33);

                //2017-2018
                if (lblFinYearValue.Text == "2017-2018")
                {

                    if (radDOLetter.Checked == true)
                    {
                        s = Common34;
                    }
                    else if (radRightToInformationLetter.Checked == true)
                    {
                        s = Common35;
                    }
                    else if (radGovtLetter.Checked == true)
                    {
                        s = Common36;
                    }
                    else if (radLokayuktha.Checked == true)
                    {
                        s = Common37;
                    }
                    else if (radGeneralLetter.Checked == true)
                    {
                        s = Common38;
                    }

                }

                   //2018-2019
                else if (lblFinYearValue.Text == "2018-2019")
                {
                    if (radDOLetter.Checked == true)
                    {
                        s = Common39;
                    }
                    else if (radRightToInformationLetter.Checked == true)
                    {
                        s = Common40;
                    }
                    else if (radGovtLetter.Checked == true)
                    {
                        s = Common41;
                    }
                    else if (radLokayuktha.Checked == true)
                    {
                        s = Common42;
                    }
                    else if (radGeneralLetter.Checked == true)
                    {
                        s = Common43;
                    }
                }

                //2019-2020
                else if (lblFinYearValue.Text == "2019-2020")
                {
                    if (radDOLetter.Checked == true)
                    {
                        s = Common44;
                    }
                    else if (radRightToInformationLetter.Checked == true)
                    {
                        s = Common45;
                    }
                    else if (radGovtLetter.Checked == true)
                    {
                        s = Common46;
                    }
                    else if (radLokayuktha.Checked == true)
                    {
                        s = Common47;
                    }
                    else if (radGeneralLetter.Checked == true)
                    {
                        s = Common48;
                    }
                }

                //2020-2021
                else if (lblFinYearValue.Text == "2020-2021")
                {
                    if (radDOLetter.Checked == true)
                    {
                        s = Common49;
                    }
                    else if (radRightToInformationLetter.Checked == true)
                    {
                        s = Common50;
                    }
                    else if (radGovtLetter.Checked == true)
                    {
                        s = Common51;
                    }
                    else if (radLokayuktha.Checked == true)
                    {
                        s = Common52;
                    }
                    else if (radGeneralLetter.Checked == true)
                    {
                        s = Common53;
                    }
                }

                  //2021-2022
                else if (lblFinYearValue.Text == "2021-2022")
                {
                    if (radDOLetter.Checked == true)
                    {
                        s = Common54;
                    }
                    else if (radRightToInformationLetter.Checked == true)
                    {
                        s = Common55;
                    }
                    else if (radGovtLetter.Checked == true)
                    {
                        s = Common56;
                    }
                    else if (radLokayuktha.Checked == true)
                    {
                        s = Common57;
                    }
                    else if (radGeneralLetter.Checked == true)
                    {
                        s = Common58;
                    }
                }
                //2022-2023
                else if (lblFinYearValue.Text == "2022-2023")
                {
                    if (radDOLetter.Checked == true)
                    {
                        s = Common59;
                    }
                    else if (radRightToInformationLetter.Checked == true)
                    {
                        s = Common60;
                    }
                    else if (radGovtLetter.Checked == true)
                    {
                        s = Common61;
                    }
                    else if (radLokayuktha.Checked == true)
                    {
                        s = Common62;
                    }
                    else if (radGeneralLetter.Checked == true)
                    {
                        s = Common63;
                    }
                }

                //2023-2024
                else if (lblFinYearValue.Text == "2023-2024")
                {
                    if (radDOLetter.Checked == true)
                    {
                        s = Common64;
                    }
                    else if (radRightToInformationLetter.Checked == true)
                    {
                        s = Common65;
                    }
                    else if (radGovtLetter.Checked == true)
                    {
                        s = Common66;
                    }
                    else if (radLokayuktha.Checked == true)
                    {
                        s = Common67;
                    }
                    else if (radGeneralLetter.Checked == true)
                    {
                        s = Common68;
                    }
                }


                //2024-2025
                else if (lblFinYearValue.Text == "2024-2025")
                {
                    if (radDOLetter.Checked == true)
                    {
                        s = Common69;
                    }
                    else if (radRightToInformationLetter.Checked == true)
                    {
                        s = Common70;
                    }
                    else if (radGovtLetter.Checked == true)
                    {
                        s = Common71;
                    }
                    else if (radLokayuktha.Checked == true)
                    {
                        s = Common72;
                    }
                    else if (radGeneralLetter.Checked == true)
                    {
                        s = Common73;
                    }
                }

                cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@DO_Letter", DO_Letter);
                cmd.Parameters.AddWithValue("@Right_To_Info_Letter", Right_To_Info_Letter);
                cmd.Parameters.AddWithValue("@Government_Letter", Government_Letter);
                cmd.Parameters.AddWithValue("@Lokayukta_ABS_Letter", Lokayukta_ABS_Letter);
                cmd.Parameters.AddWithValue("@General_Letter", General_Letter);
                cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.Date);
                cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.Date);
                cmd.Parameters.AddWithValue("@Entry_Date", dateTimePickerEntryDate.Value.Date);
                // conn.Close();
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Records Inserted Successfully, GL No = " + txtGLNo.Text + "");
                    CleartextBoxes2();
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (radDOLetter.Checked == false && radGeneralLetter.Checked == false && radRightToInformationLetter.Checked == false && radGovtLetter.Checked == false && radLokayuktha.Checked == false)
                {
                    MessageBox.Show("Please Select Letter Category ");
                }


                if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && txtInwardNo.Text == "")
                {
                    MessageBox.Show("Please enter value for Inward Number");
                    txtInwardNo.Focus();
                    txtInwardNo.BackColor = Color.Red;
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && txtLetterNumber.Text == "")
                {
                    MessageBox.Show("Please enter value for Letter Number");
                    txtLetterNumber.Focus();
                    txtLetterNumber.BackColor = Color.Red;
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && (dateTimePickerLetterDate.MaxDate < dateTimePickerLetterDate.Value.Date))
                {
                    MessageBox.Show("Please enter Proper Letter Date");
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && (dateTimePickerReceivedDate.MaxDate < dateTimePickerReceivedDate.Value.Date))
                {
                    MessageBox.Show("Please enter Proper Received Date");
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && cbDept.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select value Department ");
                    cbDept.SelectedIndex = -1;
                    cbDept.Focus();
                    cbDept.BackColor = Color.Red;
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && cbOffice.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select value Office ");
                    cbOffice.SelectedIndex = -1;
                    cbOffice.Focus();
                    cbOffice.BackColor = Color.Red;
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && cbToSection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To Section");
                    cbToSection.SelectedIndex = -1;
                    cbToSection.Focus();
                    cbToSection.BackColor = Color.Red;
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && cbToSubsection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To Subsection");
                    cbToSubsection.SelectedIndex = -1;
                    cbToSubsection.Focus();
                    cbToSubsection.BackColor = Color.Red;
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && cbToCaseWorker.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To CaseWorker");
                    cbToCaseWorker.SelectedIndex = -1;
                    cbToCaseWorker.Focus();
                    cbToCaseWorker.BackColor = Color.Red;
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && txtSubject.Text == "")
                {
                    MessageBox.Show("Please enter value for Subject");
                    txtSubject.Focus();
                    txtSubject.BackColor = Color.Red;
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || radLokayuktha.Checked == true) && (txtGLNo.Text != "" && txtInwardNo.Text != "" && txtLetterNumber.Text != "" && txtSubject.Text != "" && cbDept.SelectedIndex != -1 && cbOffice.SelectedIndex != -1 && cbToSection.SelectedIndex != -1 && cbToSubsection.SelectedIndex != -1 && cbToCaseWorker.SelectedIndex != -1))
                {
                    Save_Govt_Letter_2017();
                    CleartextBoxes2();
                    txtInwardNo.Focus();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
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

        private void chkOthers_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkOthers.Checked == true)
                {
                    lblOtherDept.Visible = true;
                    txtDeptOthers.Visible = true;
                }
                else
                {
                    lblOtherDept.Visible = false;
                    txtDeptOthers.Visible = false;
                    txtDeptOthers.Text = "";
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtInwardNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtInwardNo.BackColor = Color.PowderBlue;
            }
            catch (Exception)
            {

            }
        }

        private void txtLetterNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtLetterNumber.BackColor = Color.PowderBlue;
            }
            catch (Exception)
            {

            }
        }

        private void txtApplicantName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtApplicantName.BackColor = Color.PowderBlue;
            }
            catch (Exception)
            {

            }
        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Add FromOffice Dropdown
                cbOffice.Items.Clear();
                cbOffice.Text = "";

                SqlCommand cmd5 = new SqlCommand("Select distinct FromOffice from tblDepartment where Department_Name = N'" + cbDept.SelectedItem + "' order by FromOffice", conn);
                conn.Open();
                SqlDataReader dr5 = cmd5.ExecuteReader();
                while (dr5.Read())
                {
                    string name = dr5[0].ToString();
                    cbOffice.Items.Add(name);
                }
                conn.Close();

                cbDept.BackColor = Color.PowderBlue;
            }
            catch (Exception)
            {

            }

        }

        private void cbOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbOffice.BackColor = Color.PowderBlue;
            }
            catch (Exception)
            {

            }
        }

        private void cbToSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {  //  Add Subsection Dropdown
                cbToSubsection.Items.Clear();
                cbToSubsection.Text = "";

                SqlCommand cmd4 = new SqlCommand("select distinct Subsection from tblSubsectionManagement where Section = N'" + cbToSection.SelectedItem + "' Order By Subsection", conn);
                conn.Open();
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    string name = dr4[0].ToString();
                    cbToSubsection.Items.Add(name);
                }
                conn.Close();

                cbToSection.BackColor = Color.PowderBlue;
            }
            catch (Exception)
            {

            }
        }

        private void cbToSubsection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //  Add CaseWorker Dropdown
                cbToCaseWorker.Items.Clear();
                cbToCaseWorker.Text = "";

                SqlCommand cmd2 = new SqlCommand("select distinct CaseWorker from tblCaseSecSubsec where Section = N'" + cbToSection.SelectedItem + "' and Subsection = N'" + cbToSubsection.SelectedItem + "'", conn);
                conn.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    string name = dr2[0].ToString();
                    cbToCaseWorker.Items.Add(name);
                }
                conn.Close();

                cbToSubsection.BackColor = Color.PowderBlue;
            }
            catch (Exception)
            {

            }
        }

        private void cbToCaseWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbToCaseWorker.BackColor = Color.PowderBlue;
            }
            catch (Exception)
            {

            }
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSubject.BackColor = Color.PowderBlue;
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
                    lblTypeOfLetter.Text = "You have Selected DO Letter!";
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
                    lblTypeOfLetter.Text = "You have Selected General Letter!";
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
                    lblTypeOfLetter.Text = "You have Selected Right To Information Letter!";
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
                    lblTypeOfLetter.Text = "You have Selected Governemnt Letter!";
                }

            }
            catch (Exception)
            {

            }
        }

        private void radLokayuktha_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radLokayuktha.Checked == true)
                {
                    lblTypeOfLetter.Text = "You have Selected Lokayuktha/ACB Letter!";
                }

            }
            catch (Exception)
            {

            }
        }

    

        private void btnGotoCourtCaseLetterPagee_Click(object sender, EventArgs e)
        {
            try
            {
                var Home = new CourtCaseLetter_IN();
                Home.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
