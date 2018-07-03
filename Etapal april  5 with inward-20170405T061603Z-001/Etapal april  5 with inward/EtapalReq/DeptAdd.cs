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
    public partial class DeptAdd : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlDataAdapter da;
        SqlCommand cmd;

        public DeptAdd()
        {
            InitializeComponent();
        }

        private void DeptAdd_Load(object sender, EventArgs e)
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

            //Tooltips
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnInsert, "Add");
            toolTip1.SetToolTip(this.btnDelete, "Delete");
            toolTip1.SetToolTip(this.btnBack, "Back");



            //To fit Application to full Page
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            DeptDropDown();
                       
        }

        public void DeptDropDown()
        {
            //Add Dept dropdown
            cmd = new SqlCommand("Select distinct Department_Name from tblDepartment order by Department_Name", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string Dept = dr[0].ToString();
                cbDept.Items.Add(Dept);
            }
            conn.Close();
        }

        public void DeptDropDown1()
        {
            //Add Dept dropdown
            cmd = new SqlCommand("Select distinct Department_Name from tblDepartment order by Department_Name", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string Dept = dr[0].ToString();
                cbDept.Items.Add(Dept);
            }
            conn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDept.Text != "" && txtOffice.Text != "")
                {
                    cmd = new SqlCommand("Insert into tblDepartment(Department_Name,FromOffice) values(N'" + txtDept.Text + "',N'" + txtOffice.Text + "')", conn);
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        DeptDropDown1();
                        MessageBox.Show("Document's Added Successfully:" + Environment.NewLine +
                                    "Department Name : " + txtDept.Text + "" + Environment.NewLine +
                                    "FromOffice Name : " + txtOffice.Text + "");

                        
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Both Department and Office Name !");
                }

            }
            catch (Exception)
            {

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
            cmd = new SqlCommand("Delete tblDepartment where Department_Name = @Department_Name and FromOffice = @FromOffice");
            cmd.Parameters.AddWithValue("@Department_Name",cbDept.Text);
            cmd.Parameters.AddWithValue("@FromOffice",cbOffice.Text);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Document's Deleted Successfully:" + Environment.NewLine +
                       "Department Name : " + txtDept.Text + "" + Environment.NewLine +
                       "Office Name : " + txtOffice.Text + "");  
            }
            catch (Exception)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var Dept = new Home();
                Dept.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
