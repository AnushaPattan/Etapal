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
    public partial class Receive_ : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReq; integrated Security=true;");
        SqlCommand cmd;
        // double n;
        public Receive_()
        {

            InitializeComponent();
            // lblGLNumber.Visible = false;
            txtGLNo.Visible = false;
            txtDeptOthers.Visible = false;
        }



        private void SaveGL_NO()
        {

            string InsertData = "Insert into tblReceiver_(GL_No,Inward_No,Ack_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,ToSubSection)" +
                             "values(@GL_NO,@Inward_No,@Ack_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToCaseWorker,@ToSubSection)";
            cmd = new SqlCommand(InsertData, conn);
            cmd.Parameters.AddWithValue("@GL_NO", txtGLNo.Text);
            cmd.Parameters.AddWithValue("@Inward_No", txtInwardNo.Text);
            cmd.Parameters.AddWithValue("@Ack_No", txtAutoIncNo.Text);
            cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@FromDept", txtFromDept.Text);
            cmd.Parameters.AddWithValue("@Other_Dept", txtDeptOthers.Text);
            cmd.Parameters.AddWithValue("@FromOffice", txtFromOffice.Text);
            cmd.Parameters.AddWithValue("@Subject", txtSubject.Text);
            cmd.Parameters.AddWithValue("@ToSection", cbToSection.Text);
            cmd.Parameters.AddWithValue("@ToCaseWorker", cbToCaseWorker.Text);
            cmd.Parameters.AddWithValue("@TOSubSection", cbToSubSection.Text);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                //    MessageBox.Show("Details saved Successfully , GL No is" + txtAutoIncNo.Text+");
            }
            conn.Close();
            CleartextBoxes2();

        }

        // Load Event
        private void Receive__Load(object sender, EventArgs e)
        {
            try
            {
                //Tooltips
                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnSave, "Save");
                toolTip1.SetToolTip(this.btnSave, "Back");

                lblOtherDept.Visible = false;
                //  lblAckNumber.Visible = false;
                //lblGLNumber.Text = radDO.Text;
                //lblGLNumber.Visible = true;
                txtGLNo.Visible = true;


                //int i = 0;
                //string Number = "Select count(id) from tblReceiver_";
                //cmd = new SqlCommand(Number, conn);
                //conn.Open();
                //i = (int)cmd.ExecuteScalar();
                //double n = i + 1;
                //txtAutoIncNo.Text = Convert.ToString(n);
                //txtAckNo.Text = Convert.ToString(n);
                //txtAckNo.Visible = false;
                //conn.Close();

                int j = 0;
                string Number1 = "Select max(id) from tblReceiver_";
                cmd = new SqlCommand(Number1, conn);
                conn.Open();
                j = (int)cmd.ExecuteScalar();
                double m = j + 1;
                txtAutoIncNo.Text = Convert.ToString(m);
                //txtAckNo.Text = Convert.ToString(m);
                //txtAckNo.Visible = false;
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

                SqlCommand cmd3 = new SqlCommand("select Subsection from tblSectionManagement", conn);
                conn.Open();
                SqlDataReader dr2 = cmd3.ExecuteReader();
                while (dr2.Read())
                {
                    string name = dr2[0].ToString();
                    cbToSubSection.Items.Add(name);
                }
                conn.Close();
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            catch (Exception)
            {

            }

        }

        //private void chkOthers_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkOthers.Checked == true)
        //    {
        //        lblOtherDept.Visible = true;
        //        txtDeptOthers.Visible = true;
        //    }
        //    else
        //    {
        //        lblOtherDept.Visible = false;
        //        txtDeptOthers.Visible = false;
        //        txtDeptOthers.Text = "";
        //    }
        //}
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
                cbToSubSection.SelectedIndex = -1;

                //int a = 0;
                //string Number = "Select count(id) from tblReceiver_";
                //cmd = new SqlCommand(Number, conn);
                //conn.Open();
                //a = (int)cmd.ExecuteScalar();
                //double n = a + 1;
                //txtAutoIncNo.Text = Convert.ToString(n);
                //txtAckNo.Visible = false;
                //conn.Close();

                int k = 0;
                string Number1 = "Select max(id) from tblReceiver_";
                cmd = new SqlCommand(Number1, conn);
                conn.Open();
                k = (int)cmd.ExecuteScalar();
                double o = k + 1;
                txtAutoIncNo.Text = Convert.ToString(o);
                //txtAckNo.Text = Convert.ToString(o);
                //txtAckNo.Visible = false;
                conn.Close();


            }
            catch (Exception)
            {

            }


        }

        private void txtFromDept_TextChanged(object sender, EventArgs e)
        {
            //if (!System.Text.RegularExpressions.Regex.IsMatch(txtFromDept.Text, @"^[a-zA-Z]+$"))
            //{
            //    MessageBox.Show("From Department accepts only alphabetical characters");
            //    txtFromDept.Text = "";
            //}
        }

        private void lblOtherDept_Click(object sender, EventArgs e)
        {

        }

        private void lblCaseWorker_Click(object sender, EventArgs e)
        {

        }




        private void lblToSection_Click(object sender, EventArgs e)
        {

        }

        private void lblFromOffice_Click(object sender, EventArgs e)
        {

        }

        private void lblAckNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblLetterDate_Click(object sender, EventArgs e)
        {

        }

        private void lblGLNumber_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblReceivedDate_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radDO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }

        private void txtDeptOthers_TextChanged_1(object sender, EventArgs e)
        {
            //if (!System.Text.RegularExpressions.Regex.IsMatch(txtDeptOthers.Text, @"^[a-zA-Z]+$"))
            //{
            //    MessageBox.Show("Other Department accepts only alphabetical characters");
            //    txtDeptOthers.Text = "";
            //}
        }

        //private void chkOthers_CheckedChanged_1(object sender, EventArgs e)
        //{

        //}

        private void chkOthers_CheckedChanged_2(object sender, EventArgs e)
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

        private void cbToSubSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // To save Records
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // DateTime CurrentDate = DateTime.Now;
                dateTimePickerLetterDate.MaxDate = DateTime.Today;
                dateTimePickerReceivedDate.MaxDate = DateTime.Today;

                if (txtGLNo.Text == "")
                {
                    MessageBox.Show("Please enter value for GL No.");
                    txtGLNo.Text = "";
                    txtGLNo.Focus();
                }
                else if (txtInwardNo.Text == "")
                {
                    MessageBox.Show("Please enter value for Inward No");
                    txtInwardNo.Text = "";
                    txtInwardNo.Focus();
                }

                else if (dateTimePickerLetterDate.MaxDate < dateTimePickerLetterDate.Value.Date)
                {
                    MessageBox.Show("Please enter Proper Date");
                }
                else if (dateTimePickerReceivedDate.MaxDate < dateTimePickerReceivedDate.Value.Date)
                {
                    MessageBox.Show("Please enter Proper Date");
                }
                else if (txtFromDept.Text == "")
                {
                    MessageBox.Show("Please enter only alphabetical characters for From Deparment");
                    txtFromDept.Focus();
                    txtFromDept.Text = "";

                }

                else if (txtFromOffice.Text == "")
                {
                    MessageBox.Show("Please enter value for From Office");
                    txtFromOffice.Text = "";
                    txtFromOffice.Focus();
                }
                else if (txtSubject.Text == "")
                {
                    MessageBox.Show("Please enter value for Subject");
                    txtSubject.Text = "";
                    txtSubject.Focus();
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
                else if (cbToSubSection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To SubSection");
                    cbToSubSection.Text = "";
                    cbToSubSection.Focus();
                }
                else if (radDO.Checked && txtGLNo.Text != "")
                {
                    SaveGL_NO();
                }
                else if (radGeneralLetter.Checked && txtGLNo.Text != "")
                {
                    SaveGL_NO();
                }
                else if (radCourtCaseLetter.Checked && txtGLNo.Text != "")
                {
                    SaveGL_NO();
                }
                else if (radRightToInformationLetter.Checked && txtGLNo.Text != "")
                {
                    SaveGL_NO();
                }
                // CleartextBoxes2();
            }
            catch (Exception)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var Home1 = new Home1();
                Home1.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void txtAckNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFromDept_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void txtDeptOthers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }




    }
}
