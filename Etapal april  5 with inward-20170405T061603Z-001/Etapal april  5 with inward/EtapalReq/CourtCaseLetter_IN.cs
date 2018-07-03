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
    public partial class CourtCaseLetter_IN : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlCommand cmd;

        public CourtCaseLetter_IN()
        {
            InitializeComponent();
        }

        private void CourtCaseLetter_IN_Load(object sender, EventArgs e)
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

                // To Autoincrement GL No
                Auto();


               //  To Autoincrement GL No

                //int m = 0;
                //string Number1 = "Select count(Gl_No_Id) from tblCourtCaseLetter_IN";
                //cmd = new SqlCommand(Number1, conn);
                //conn.Open();
                //m = (int)cmd.ExecuteScalar();
                //double o = m + 1;
                //txtGLNo.Text = Convert.ToString(o);
                //conn.Close();

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

                ////add Case Worker Dropdown

                SqlCommand cmd2 = new SqlCommand("select distinct CaseWorker from tblUserMgnt Order By CaseWorker", conn);
                conn.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    string name = dr2[0].ToString();
                    cbToCaseWorker.Items.Add(name);
                }
                conn.Close();

                //// Add Department Dropdown
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
            }
            catch (Exception)
            {

            }
        }

        // To Autoincrement GL No
        private void Auto()
        {
            try
            {
            int m = 0;
            string Number1 = "Select count(Gl_No_Id) from  ";
            string Number2 = "";
            string s = "";
            if(lblFinYearValue.Text == "2017-2018")
            {
                Number2 = " tblCourtCaseLetter_IN_2017_2018";
            }
            else if (lblFinYearValue.Text == "2018-2019")
            {
                Number2 = " tblCourtCaseLetter_IN_2018_2019";
            }
            else if (lblFinYearValue.Text == "2019-2020")
            {
                Number2 = " tblCourtCaseLetter_IN_2019_2020";
            }
            else if (lblFinYearValue.Text == "2020-2021")
            {
                Number2 = " tblCourtCaseLetter_IN_2020_2021";
            }
            else if (lblFinYearValue.Text == "2021-2022")
            {
                Number2 = " tblCourtCaseLetter_IN_2021_2022";
            }
            else if (lblFinYearValue.Text == "2022-2023")
            {
                Number2 = " tblCourtCaseLetter_IN_2022_2023";
            }
            else if (lblFinYearValue.Text == "2023-2024")
            {
                Number2 = " tblCourtCaseLetter_IN_2023_2024";
            }
            else if (lblFinYearValue.Text == "2024-2025")
            {
                Number2 = " tblCourtCaseLetter_IN_2024_2025";
            }
            s = string.Concat(Number1, Number2);
            cmd = new SqlCommand(s, conn);
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
        

        public void CleartextBoxes2()
        {
            try
            {
               
                txtInwardNo.Text = "";
                txtLetterNumber.Text = "";
                txtSubject.Text = "";
                txtDeptOthers.Text = "";

                cbToSection.SelectedIndex = -1;
                cbToCaseWorker.SelectedIndex = -1;
                cbToSubsection.SelectedIndex = -1;
                cbDept.SelectedIndex = -1;
                cbOffice.SelectedIndex = -1;
                chkOthers.Checked = false;
                cbOffice.Items.Clear();
                cbToSection.Items.Clear();

                // To Autoincrement GL No
                Auto();

                //int k = 0;
                //string Number1 = "Select count(GL_No_Id) from dbo.tblCourtCaseLetter_IN";
                //cmd = new SqlCommand(Number1, conn);
                //conn.Open();
                //k = (int)cmd.ExecuteScalar();
                //double o = k + 1;
                //txtGLNo.Text = Convert.ToString(o);
                //conn.Close();
                
            }
            catch (Exception)
            {

            }
        }

        //Save CourtCase CLICK
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation for Court Case  Letter
                if (txtInwardNo.Text == "")
                {
                    MessageBox.Show("Please enter value for Inward Number");
                    txtInwardNo.Focus();
                    txtInwardNo.BackColor = Color.Red;
                }
                else if (txtLetterNumber.Text == "")
                {
                    MessageBox.Show("Please enter value for Letter Number");
                    txtLetterNumber.Focus();
                    txtLetterNumber.BackColor = Color.Red;
                }
                else if ((dateTimePickerLetterDate.MaxDate < dateTimePickerLetterDate.Value.Date))
                {
                    MessageBox.Show("Please enter Proper Letter Date");
                }
                else if ((dateTimePickerReceivedDate.MaxDate < dateTimePickerReceivedDate.Value.Date))
                {
                    MessageBox.Show("Please enter Proper Received Date");
                }
                else if (cbDept.SelectedIndex == -1 )
                {
                    MessageBox.Show("Please select Department Name from dropdown");
                    cbDept.Focus();
                    cbDept.SelectedIndex = -1;
                    cbDept.BackColor = Color.Red;
                }
                else if (cbOffice.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Office name from dropdown");
                    cbOffice.Focus();
                    cbOffice.SelectedIndex = -1;
                    cbOffice.BackColor = Color.Red;
                }
                else if (cbToSection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select value for To Section from dropdown");
                    cbToSection.SelectedIndex = -1;
                    cbToSection.Focus();
                    cbToSection.BackColor = Color.Red;
                }
                else if (cbToSubsection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select value for To Subsection from dropdown");
                    cbToSubsection.SelectedIndex = -1;
                    cbToSubsection.Focus();
                    cbToSubsection.BackColor = Color.Red;
                }
                else if (cbToCaseWorker.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select value for To CaseWorker from dropdown");
                    cbToCaseWorker.SelectedIndex = -1;
                    cbToCaseWorker.Focus();
                    cbToCaseWorker.BackColor = Color.Red;
                }
                else if (txtSubject.Text == "")
                {
                    MessageBox.Show("Please enter value for Subject");
                    txtSubject.Focus();
                    txtSubject.BackColor = Color.Red;
                }
                // To save 

                else if ((txtGLNo.Text != "" && txtInwardNo.Text != "" && txtLetterNumber.Text != "" && cbDept.SelectedIndex != -1 && cbToSection.SelectedIndex != -1 && cbToCaseWorker.SelectedIndex != -1 && txtSubject.Text != ""))
                {
                    Save_CourtCase_Letter_2017();
                    CleartextBoxes2();
                    txtInwardNo.Focus();
                }
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

        // Save CourtCase_Letter Function from 2017

        private void Save_CourtCase_Letter_2017()
        {
            try
            {
                string s = "";
                string Common2 = "";
                string Court_Case_Letter_str = "CourtCaseLetter";
                string Common1 = "Insert into ";
                string Common3 = " (Court_Case_Letter,Letter_No,Received_Date,Letter_Date,FromDept,From_Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Inward_No,ToSubsection,Entry_Date)" +
                                " values(@Court_Case_Letter,N'" + txtLetterNumber.Text + "',@Received_Date,@Letter_Date,N'" + cbDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + cbOffice .Text+ "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "',N'" + txtInwardNo.Text + "',N'" + cbToSubsection.Text + "',@Entry_Date)";
                 Common2 = " tblCourtCaseLetter_IN_2018_2019 ";
				 s = string.Concat(Common1, Common2, Common3);
				
                if (lblFinYearValue.Text == "2017-2018")
                {
                    Common2 = " tblCourtCaseLetter_IN_2017_2018 ";
                }
                else if (lblFinYearValue.Text == "2018-2019")
                {
                    Common2 = " tblCourtCaseLetter_IN_2018_2019 ";
                }
                else if (lblFinYearValue.Text == "2019-2020")
                {
                    Common2 = " tblCourtCaseLetter_IN_2019_2020 ";
                }
                else if (lblFinYearValue.Text == "2020-2021")
                {
                    Common2 = " tblCourtCaseLetter_IN_2020_2021 ";
                }
                else if (lblFinYearValue.Text == "2021-2022")
                {
                    Common2 = " tblCourtCaseLetter_IN_2021_2022 ";
                }
                else if (lblFinYearValue.Text == "2022-2023")
                {
                    Common2 = " tblCourtCaseLetter_IN_2022_2023 ";
                }
                else if (lblFinYearValue.Text == "2023-2024")
                {
                    Common2 = " tblCourtCaseLetter_IN_2023_2024 ";
                }
                else if (lblFinYearValue.Text == "2024-2025")
                {
                    Common2 = " tblCourtCaseLetter_IN_2024_2025 ";
                }
                else if (lblFinYearValue.Text == "2025-2026")
                {
                    Common2 = " tblCourtCaseLetter_IN_2025_2026 ";
                }
                else if (lblFinYearValue.Text == "2026-2027")
                {
                    Common2 = " tblCourtCaseLetter_IN_2026_2027 ";
                }
                else if (lblFinYearValue.Text == "2027-2028")
                {
                    Common2 = " tblCourtCaseLetter_IN_2027_2028 ";
                }
                else if (lblFinYearValue.Text == "2028-2029")
                {
                    Common2 = " tblCourtCaseLetter_IN_2029_2030 ";
                }
                else if (lblFinYearValue.Text == "2029-2030")
                {
                    Common2 = " tblCourtCaseLetter_IN ";
                }
                s = string.Concat(Common1, Common2, Common3);
                cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@Court_Case_Letter", Court_Case_Letter_str);
                cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.Date);
                cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.Date);
                cmd.Parameters.AddWithValue("@Entry_Date", dateTimePickerEntryDate.Value.Date);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Details saved Successfully , GL No : " + txtGLNo.Text);
                }
                conn.Close();
                CleartextBoxes2();
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
            {
                //  Add Subsection Dropdown
                cbToSubsection.Items.Clear();
                cbToSubsection.Text = "";

                SqlCommand cmd4 = new SqlCommand("select distinct Subsection from tblSubsectionManagement where Section = N'"+cbToSection.SelectedItem+"' Order By Subsection", conn);
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

        //private void cbToSubsection_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //  Add CaseWorker Dropdown
        //        cbToCaseWorker.Items.Clear();
        //        cbToCaseWorker.Text = "";

        //        SqlCommand cmd2 = new SqlCommand("select distinct CaseWorker from tblCaseSecSubsec where Section = N'" + cbToSection.SelectedItem + "' and Subsection = N'"+cbToSubsection.SelectedItem+"'", conn);
        //        conn.Open();
        //        SqlDataReader dr2 = cmd2.ExecuteReader();
        //        while (dr2.Read())
        //        {
        //            string name = dr2[0].ToString();
        //            cbToCaseWorker.Items.Add(name);
        //        }
        //        conn.Close();
        //    cbToSubsection.BackColor = Color.PowderBlue;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

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

       
        private void btnGotoGovtLetterPagee_Click(object sender, EventArgs e)
        {
            try
            {
                var Home = new GovtLetters_IN();
                Home.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void lblFinancialYear_Click(object sender, EventArgs e)
        {

        }

        
    }
}
