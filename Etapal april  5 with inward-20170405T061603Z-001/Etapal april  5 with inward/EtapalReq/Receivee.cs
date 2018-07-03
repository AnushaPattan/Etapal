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

namespace EtapalReq
{
    public partial class Receivee : Form
    {
        
        public Receivee()
        {
            InitializeComponent();
           // lblGLNumber.Visible = false;
            txtGLNo.Visible = false;
            txtDeptOthers.Visible = false;
        }
       
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReq; integrated Security=true;");
        SqlCommand cmd;

        private void radDO_CheckedChanged(object sender, EventArgs e)
        {
            //lblNumber.Text = "DO Number";
            //lblNumber.Visible = true;
            //txtNo.Visible = true;

        }

        private void radGeneralLetter_CheckedChanged(object sender, EventArgs e)
        {
            //lblNumber.Text = "General Letter";
            //lblNumber.Visible = true;
            //txtNo.Visible = true;
        }

        private void radCourtCaseLetter_CheckedChanged(object sender, EventArgs e)
        {
            //lblNumber.Text = "Court Case Letter";
            //lblNumber.Visible = true;
            //txtNo.Visible = true;
        }

        private void radRightToInformationLetter_CheckedChanged(object sender, EventArgs e)
        {
            //lblNumber.Text = "Right To Information Letter";
            //lblNumber.Visible = true;
            //txtNo.Visible = true;
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

        private void Receive_Load(object sender, EventArgs e)
        {
            try
            {
                lblOtherDept.Visible = false;
                //lblGLNumber.Text = radDO.Text;
                //lblGLNumber.Visible = true;
                txtGLNo.Visible = true;
                int i = 0;
                string Number = "Select count(id) from tblReceiver";
                cmd = new SqlCommand(Number, conn);
                conn.Open();
                i = (int)cmd.ExecuteScalar();
                int n = i + 1;
                txtAutoIncNo.Text = Convert.ToString(n);
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
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            catch (Exception)
            {

            }
        }

        private void chkOthers_CheckedChanged(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {       
            if (radDO.Checked && txtGLNo.Text != "")
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
            else if(radRightToInformationLetter.Checked && txtGLNo.Text != "")
            {
                SaveGL_NO();
            }
            CleartextBoxes2();
        }

        private void SaveGL_NO()
        {
               string InsertData = "Insert into tblReceiver_(GL_No,Inward_No,Ack_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker)" +
                                "values(@GL_NO,@Inward_No,@Ack_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToCaseWorker)";
                cmd = new SqlCommand(InsertData,conn);
                cmd.Parameters.AddWithValue("@GL_NO", txtGLNo.Text);
                cmd.Parameters.AddWithValue("@Inward_No", txtInwardNo.Text);
                cmd.Parameters.AddWithValue("@Ack_No", txtAckNo.Text);
                cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@FromDept", txtFromDept.Text);
                cmd.Parameters.AddWithValue("@Other_Dept", txtDeptOthers.Text);
                cmd.Parameters.AddWithValue("@FromOffice", txtFromOffice.Text);
                cmd.Parameters.AddWithValue("@Subject", txtSubject.Text);
                cmd.Parameters.AddWithValue("@ToSection", cbToSection.Text);
                cmd.Parameters.AddWithValue("@ToCaseWorker", cbToCaseWorker.Text);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Rec's Inserted Successfully");
                }
                conn.Close();  
        }
        //private void SaveGeneralLetter_No()
        //{
        //    string InsertData = "Insert into tblReceiver(General_letterNo,Inward_No,Ack_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker)" +
        //                     "values(@General_letterNo,@Inward_No,@Ack_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToCaseWorker)";
        //    cmd = new SqlCommand(InsertData, conn);
        //    cmd.Parameters.AddWithValue("@General_letterNo", txtGLNo.Text);
        //    cmd.Parameters.AddWithValue("@Inward_No", txtInwardNo.Text);
        //    cmd.Parameters.AddWithValue("@Ack_No", txtAckNo.Text);
        //    cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.ToShortDateString());
        //    cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.ToShortDateString());
        //    cmd.Parameters.AddWithValue("@FromDept", txtFromDept.Text);
        //    cmd.Parameters.AddWithValue("@Other_Dept", txtDeptOthers.Text);
        //    cmd.Parameters.AddWithValue("@FromOffice", txtFromOffice.Text);
        //    cmd.Parameters.AddWithValue("@Subject", txtSubject.Text);
        //    cmd.Parameters.AddWithValue("@ToSection", cbToSection.Text);
        //    cmd.Parameters.AddWithValue("@ToCaseWorker", cbToCaseWorker.Text);
        //    conn.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    if (i > 0)
        //    {
        //        MessageBox.Show("Rec's Inserted Successfully");
        //    }
        //    conn.Close();
        //}
        //private void SaveCourtCaseLetter_No()
        //{
        //    string InsertData = "Insert into tblReceiver(CourtCase_No,Inward_No,Ack_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker)" +
        //                     "values(@CourtCase_No,@Inward_No,@Ack_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToCaseWorker)";
        //    cmd = new SqlCommand(InsertData, conn);
        //    cmd.Parameters.AddWithValue("@CourtCase_No", txtGLNo.Text);
        //    cmd.Parameters.AddWithValue("@Inward_No", txtInwardNo.Text);
        //    cmd.Parameters.AddWithValue("@Ack_No", txtAckNo.Text);
        //    cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.ToShortDateString());
        //    cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.ToShortDateString());
        //    cmd.Parameters.AddWithValue("@FromDept", txtFromDept.Text);
        //    cmd.Parameters.AddWithValue("@Other_Dept", txtDeptOthers.Text);
        //    cmd.Parameters.AddWithValue("@FromOffice", txtFromOffice.Text);
        //    cmd.Parameters.AddWithValue("@Subject", txtSubject.Text);
        //    cmd.Parameters.AddWithValue("@ToSection", cbToSection.Text);
        //    cmd.Parameters.AddWithValue("@ToCaseWorker", cbToCaseWorker.Text);
        //    conn.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    if (i > 0)
        //    {
        //        MessageBox.Show("Rec's Inserted Successfully");
        //    }
        //    conn.Close();
        //}
        //private void SaveRightToInfoLetter_No()
        //{
        //    string InsertData = "Insert into tblReceiver(RightToInfo_No,Inward_No,Ack_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker)" +
        //                     "values(@RightToInfo_No,@Inward_No,@Ack_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToCaseWorker)";
        //    cmd = new SqlCommand(InsertData, conn);
        //    cmd.Parameters.AddWithValue("@RightToInfo_No", txtGLNo.Text);
        //    cmd.Parameters.AddWithValue("@Inward_No", txtInwardNo.Text);
        //    cmd.Parameters.AddWithValue("@Ack_No", txtAckNo.Text);
        //    cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.ToShortDateString());
        //    cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.ToShortDateString());
        //    cmd.Parameters.AddWithValue("@FromDept", txtFromDept.Text);
        //    cmd.Parameters.AddWithValue("@Other_Dept", txtDeptOthers.Text);
        //    cmd.Parameters.AddWithValue("@FromOffice", txtFromOffice.Text);
        //    cmd.Parameters.AddWithValue("@Subject", txtSubject.Text);
        //    cmd.Parameters.AddWithValue("@ToSection", cbToSection.Text);
        //    cmd.Parameters.AddWithValue("@ToCaseWorker", cbToCaseWorker.Text);
        //    conn.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    if (i > 0)
        //    {
        //        MessageBox.Show("Rec's Inserted Successfully");
        //    }
        //    conn.Close();
        //}
        public void CleartextBoxes()
        {
            foreach (Control Cleartext in this.Controls)
            {
                if (Cleartext is TextBox)
                {
                    ((TextBox)Cleartext).Text = string.Empty;
                }
            }
        }
        public void CleartextBoxes2()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Text = "";
                }
            }
        }
    }
}
