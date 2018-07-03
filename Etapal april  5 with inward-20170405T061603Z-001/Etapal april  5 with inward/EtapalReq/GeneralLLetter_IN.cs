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
    public partial class GeneralLLetter_IN : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

       // SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReq; integrated Security=true;");
        // SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReqWO; integrated Security=true;");
        // SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        SqlCommand cmd;

        public GeneralLLetter_IN()
        {
            InitializeComponent();
        }

        private void GeneralLLetter_IN_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);

                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                // yourformName.YourLabel.Font = new Font("Arial", 24, FontStyle.Bold);
                //   txtApplicantName.Font = new Font("Microsoft Sans Serif", 50,FontStyle.Regular);

                // Check DO

                // radDOLetter.Checked = true;


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

                // To Autoincrement GL No

                int m = 0;
                string Number1 = "Select count(GL_No_Id) from tblGeneralLetter_IN";
                cmd = new SqlCommand(Number1, conn);
                conn.Open();
                m = (int)cmd.ExecuteScalar();
                double o = m + 100;
                txtGLNo.Text = Convert.ToString(o);
                conn.Close();

                // Add Section Dropdown
                SqlCommand cmd1 = new SqlCommand("select section from tblSectionManagement", conn);
                conn.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    string name = dr1[0].ToString();
                    cbToSection.Items.Add(name);
                }
                conn.Close();


                // Add SubSection Dropdown
                SqlCommand cmd3 = new SqlCommand("select Subsection from tblSectionManagement", conn);
                conn.Open();
                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    string name = dr3[0].ToString();
                    cbToSubsection.Items.Add(name);
                }
                conn.Close();

                //add Case Worker

                SqlCommand cmd2 = new SqlCommand("select CaseWorker from tblUserMgnt", conn);
                conn.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    string name = dr2[0].ToString();
                    cbToCaseWorker.Items.Add(name);
                }
                conn.Close();


                //Add Subsection

                //SqlCommand cmd3 = new SqlCommand("select Subsection from tblSectionManagement", conn);
                //conn.Open();
                //SqlDataReader dr2 = cmd3.ExecuteReader();
                //while (dr2.Read())
                //{
                //    string name = dr2[0].ToString();
                //  //  cbToSubSection.Items.Add(name);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // DateTime CurrentDate = DateTime.Now;
                dateTimePickerLetterDate.MaxDate = DateTime.Today;
                dateTimePickerReceivedDate.MaxDate = DateTime.Today;

                // Validation for General Letter
                if (txtApplicantName.Text == "")
                {
                    MessageBox.Show("Please enter value for Applicant Name");
                    // MessageBox.Show("ದಯವಿಟ್ಟು ಅರ್ಜಿದಾರರ ಹೆಸರು ನಮೂದಿಸಿ");
                    txtSubject.Focus();
                }
                else if (txtHobli.Text == "")
                {
                    MessageBox.Show("Please enter value for Hobli");
                    txtLetterNumber.Focus();
                }
                else if (txtVillage.Text == "")
                {
                    MessageBox.Show("Please enter value for Village");
                    txtSubject.Focus();
                }
                else if (dateTimePickerLetterDate.Value.Date > dateTimePickerLetterDate.MaxDate)
                {
                    MessageBox.Show("Please select Proper Letter Date");
                    //dateTimePickerLetterDate.Focus();
                }
                else if (dateTimePickerReceivedDate.MaxDate < dateTimePickerReceivedDate.Value.Date)
                {
                    MessageBox.Show("Please select Proper Received Date");
                    //dateTimePickerReceivedDate.Focus();
                }
                else if (txtInwardNo.Text == "")
                {
                    MessageBox.Show("Please enter value for Inward Number");
                    txtInwardNo.Focus();
                }
                else if (txtLetterNumber.Text == "")
                {
                    MessageBox.Show("Please enter value for Letter Number");
                    txtLetterNumber.Focus();
                }
                else if (txtSurveyNo.Text == "")
                {
                    MessageBox.Show("Please enter value for Survey Number");
                    txtLetterNumber.Focus();
                }
                //else if ((txtDept.Text == "" && txtDeptOthers.Text == ""))
                //{
                //    MessageBox.Show("Please enter Department or Other Department name");
                //    txtDept.Focus();
                //}
                //else if (txtOffice.Text == "")
                //{
                //    MessageBox.Show("Please select value for From Office");
                //    txtOffice.Focus();
                //}

                else if (cbToSection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To Section");
                    cbToSection.Text = "";
                    cbToSection.Focus();
                }
                else if (cbToSubsection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To Subsection");
                    cbToSubsection.Text = "";
                    cbToSubsection.Focus();
                }
                else if (cbToCaseWorker.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To CaseWorker");
                    cbToCaseWorker.Text = "";
                    cbToCaseWorker.Focus();
                }
                else if (txtSubject.Text == "")
                {
                    MessageBox.Show("Please enter value for Subject");
                    txtSubject.Focus();
                }


                // To save 
                else if (txtGLNo.Text != "")
                {
                    Save_General_Letter();
                }
            }
            catch (Exception)
            {

            }
        }



        // Save General_Letter Function

        private void Save_General_Letter()
        {
            try
            {
                string General_Letter_str = "GeneralLetter";
                // string Inward_No = txtInwardNo.Text;
                string Letter_No = txtLetterNumber.Text;
                string Received_Date = dateTimePickerReceivedDate.Value.ToShortDateString();
                string Letter_Date = dateTimePickerLetterDate.Value.ToShortDateString();
                //string FromDept = "N'" + cbFromDept.Text + "'";
                //string Other_Dept = "N'" + txtDeptOthers.Text + "'";
                //string FromOffice = "N'" + cbFromOffice.Text + "'";
                //string Subject = "N'" + txtSubject.Text + "'";
                //string ToSection = "N'" + cbToSection.Text + "'";
                //string ToSubSection = "N'" + cbToSubSection.Text + "'";
                //string ToCaseWorker = "N'" + cbToCaseWorker.Text + "'";
                //string Applicant_Name = "N'" + txtApplicantName.Text + "'";
                //string Hobli = "N'" + txtHobli.Text + "'";
                //string Village = "N'" + txtVillage.Text + "'";
                //string Survey_No = txtSurveyNo.Text;

                //string InsertData = "Insert into tblReceiverNew(General_Letter,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Applicant_Name,Hobli,Village,Survey_No)" +
                //                 "values(@General_Letter,@Inward_No,@Letter_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToSubSection,@ToCaseWorker,@Applicant_Name,@Hobli,@Village,@Survey_No)";

                //string InsertData = "Insert into tblReceiverNew(General_Letter,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Applicant_Name,Hobli,Village,Survey_No)" +
                //              "values(@General_Letter,@Letter_No,@Received_Date,@Letter_Date,N'" + txtDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + txtOffice.Text + "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "',N'" + txtApplicantName.Text + "',N'" + txtHobli.Text + "',N'" + txtVillage.Text + "',N'" + txtSurveyNo.Text + "')";

                string InsertData = "Insert into tblGeneralLetter_IN(General_Letter,Applicant_Name,Hobli,Village,Received_Date,Letter_Date,Letter_No,Survey_No,From_Other_Dept,ToSection,ToCaseWorker,Subject,Inward_No,ToSubsection)" +
                               "values(@General_Letter,N'" + txtApplicantName.Text + "',N'" + txtHobli.Text + "',N'" + txtVillage.Text + "',@Received_Date,@Letter_Date,@Letter_No,N'" + txtSurveyNo.Text + "',N'" + txtDeptOthers.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "',N'" + txtSubject.Text + "',N'"+ txtInwardNo.Text +"',N'" + cbToSubsection.Text +"')";


                cmd = new SqlCommand(InsertData, conn);
                //cmd.Parameters.AddWithValue("@Gl_NO", txtGLNo.Text);
                // cmd.Parameters.AddWithValue("@DO_Letter", radDO.Text);
                cmd.Parameters.AddWithValue("@General_Letter", General_Letter_str);
                // cmd.Parameters.AddWithValue("@Court_Case_Letter", radCourtCaseLetter.Text);
                // cmd.Parameters.AddWithValue("@Right_To_Info_Letter", radRightToInformationLetter.Text);
                //cmd.Parameters.AddWithValue("@Inward_No", Inward_No);
                cmd.Parameters.AddWithValue("@Letter_No", Letter_No);
                cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.ToShortDateString());
                //cmd.Parameters.AddWithValue("@FromDept", FromDept);
                //cmd.Parameters.AddWithValue("@Other_Dept", Other_Dept);
                //cmd.Parameters.AddWithValue("@FromOffice", FromOffice);
                //cmd.Parameters.AddWithValue("@Subject", Subject);
                //cmd.Parameters.AddWithValue("@ToSection", ToSection);
                //cmd.Parameters.AddWithValue("@ToSubSection", ToSubSection);
                //cmd.Parameters.AddWithValue("@ToCaseWorker", ToCaseWorker);
                //cmd.Parameters.AddWithValue("@Applicant_Name", Applicant_Name);
                //cmd.Parameters.AddWithValue("@Hobli", Hobli);
                //cmd.Parameters.AddWithValue("@Village", Village);
                //cmd.Parameters.AddWithValue("@Survey_No", Survey_No);
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

                cbToSection.SelectedIndex = -1;
                cbToCaseWorker.SelectedIndex = -1;
                cbToSubsection.SelectedIndex = -1;
                chkOthers.Checked = false;

                // To Autoincrement GL No

                int k = 0;
                string Number1 = "Select count(GL_No_Id) from tblGeneralLetter_IN";
                cmd = new SqlCommand(Number1, conn);
                conn.Open();
                k = (int)cmd.ExecuteScalar();
                double o = k + 100;
                txtGLNo.Text = Convert.ToString(o);
                conn.Close();
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

        private void txtSubject_Click(object sender, EventArgs e)
        {
            try
            {
                txtSubject.Text = " ಅರ್ಜಿದಾರರ ಹೆಸರು : " + txtApplicantName.Text + Environment.NewLine + " ಹೋಬಳಿ : " + txtHobli.Text + Environment.NewLine + "ಗ್ರಾಮ : " + txtVillage.Text + Environment.NewLine + Environment.NewLine + "ಪತ್ರದ ಸಂಖ್ಯೆ : " + txtLetterNumber.Text + Environment.NewLine + " ಸಮೀಕ್ಷೆ ಸಂಖ್ಯೆ : " + txtSurveyNo.Text + Environment.NewLine + "ಇನ್ವರ್ಡ್ ಸಂಖ್ಯೆ : " + txtInwardNo.Text;
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
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
