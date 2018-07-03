using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using EtapalReq;

namespace EtapalReq
{
    public partial class RightToInformationLetter : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReqWO; integrated Security=true;");
        //SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        SqlCommand cmd;

        public RightToInformationLetter()
        {
            InitializeComponent();
        }

        private void RightToInformationLetter_Load(object sender, EventArgs e)
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
                toolTip1.SetToolTip(this.btnSave, "Back");

                // To Autoincrement GL No

                int m = 0;
                string Number1 = "Select count(Gl_No) from tblReceiverNew";
                cmd = new SqlCommand(Number1, conn);
                conn.Open();
                m = (int)cmd.ExecuteScalar();
                double o = m + 100;
                txtGLNo.Text = Convert.ToString(o);
                conn.Close();

                // Add Section Dropdown
                SqlCommand cmd1 = new SqlCommand("select section from tblSectionManagement", conn);
                conn.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr[0].ToString();
                    cbToSection.Items.Add(name);
                }
                conn.Close();

                //add Case Worker

                SqlCommand cmd2 = new SqlCommand("select CaseWorker from tblUserMgnt", conn);
                conn.Open();
                SqlDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read())
                {
                    string name = dr1[0].ToString();
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

                // Validation for Court Case  Letter
                if (dateTimePickerLetterDate.MaxDate < dateTimePickerLetterDate.Value.Date)
                {
                    MessageBox.Show("Please enter Proper Letter Date");
                    // dateTimePickerLetterDate.Focus();
                }
                else if (dateTimePickerReceivedDate.MaxDate < dateTimePickerReceivedDate.Value.Date)
                {
                    MessageBox.Show("Please enter Proper Received Date");
                    //dateTimePickerReceivedDate.Focus();
                }
                else if (txtSubject.Text == "")
                {
                    MessageBox.Show("Please enter value for Subject");
                    txtSubject.Focus();
                }
                else if (txtLetterNumber.Text == "")
                {
                    MessageBox.Show("Please enter value for Letter Number");
                    txtLetterNumber.Focus();
                }
                else if (txtDept.Text == "" && txtDeptOthers.Text == "")
                {
                    MessageBox.Show("Please select Department or enter Other Department name");
                    txtDept.Focus();
                }
                else if (txtOffice.Text == "")
                {
                    MessageBox.Show("Please select value for From Office");
                    txtOffice.Focus();
                }
                else if (cbToSection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To Section");
                    cbToSection.Text = "";
                    cbToSection.Focus();
                }
                else if (cbToCaseWorker.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To CaseWorker");
                    cbToCaseWorker.Text = "";
                    cbToCaseWorker.Focus();
                }
                else if (txtGLNo.Text != "" && (txtDept.Text != "" || txtDeptOthers.Text != ""))
                {
                    Save_Right_To_Info_Letter();
                }
                //CleartextBoxes2();
            }
            catch (Exception)
            {

            }
        }

        // Save Court Right_To_Info_Letter Function

        private void Save_Right_To_Info_Letter()
        {
            try
            {
                string Right_To_Info_Letter_str = "RightToInfoLetter";
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

                //string InsertData = "Insert into tblReceiverNew(Right_To_Info_Letter,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker)" +
                //                 "values(@Right_To_Info_Letter,@Inward_No,@Letter_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToSubSection,@ToCaseWorker)";

                string InsertData = "Insert into tblReceiverNew(Right_To_Info_Letter,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker)" +
                                "values(@Right_To_Info_Letter,@Letter_No,@Received_Date,@Letter_Date,N'" + txtDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + txtOffice.Text + "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "')";

                cmd = new SqlCommand(InsertData, conn);
                //  cmd.Parameters.AddWithValue("@Gl_NO", txtGLNo.Text);
                //cmd.Parameters.AddWithValue("@DO_Letter", radDO.Text);
                //cmd.Parameters.AddWithValue("@General_Letter", radGeneralLetter.Text);
                // cmd.Parameters.AddWithValue("@Court_Case_Letter", Right_To_Info_Letter_str);
                cmd.Parameters.AddWithValue("@Right_To_Info_Letter", Right_To_Info_Letter_str);
                // cmd.Parameters.AddWithValue("@Inward_No", Inward_No);
                cmd.Parameters.AddWithValue("@Letter_No", Letter_No);
                cmd.Parameters.AddWithValue("@Received_Date", Received_Date);
                cmd.Parameters.AddWithValue("@Letter_Date", Letter_Date);
                //cmd.Parameters.AddWithValue("@FromDept", FromDept);
                //cmd.Parameters.AddWithValue("@Other_Dept", Other_Dept);
                //cmd.Parameters.AddWithValue("@FromOffice", FromOffice);
                //cmd.Parameters.AddWithValue("@Subject", Subject);
                //cmd.Parameters.AddWithValue("@ToSection", ToSection);
                //cmd.Parameters.AddWithValue("@ToSubSection", cbToSubSection.Text);
                //cmd.Parameters.AddWithValue("@ToCaseWorker", ToCaseWorker);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var SelectCategory = new SelectCategory_WO();
                SelectCategory.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        // To Clear texyboxes

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

                //txtDept.Text == "";
                //txtOffice.Text == "";
                //cbFromDept.SelectedIndex = -1;
                //cbFromOffice.SelectedIndex = -1;
                cbToSection.SelectedIndex = -1;
                cbToCaseWorker.SelectedIndex = -1;
                // cbToSubSection.SelectedIndex = -1;
                chkOthers.Checked = false;

                // To Autoincrement GL No

                int k = 0;
                string Number1 = "Select count(Gl_No) from tblReceiverNew";
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

        private void chkOthers_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkOthers.Checked == true)
                {
                    lblOtherDept.Visible = true;
                    txtDeptOthers.Visible = true;
                    // cbFromDept.SelectedIndex = -1;

                    txtDept.Text = "";
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
    }
}
