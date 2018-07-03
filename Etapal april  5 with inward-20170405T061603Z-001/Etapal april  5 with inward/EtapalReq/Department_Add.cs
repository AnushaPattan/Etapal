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
    public partial class Department_Add : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlDataAdapter da;
        SqlCommand cmd;
        int ID = 0;

        public Department_Add()
        {
            InitializeComponent();
        }

        private void Department_Add_Load(object sender, EventArgs e)
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

                //Tooltips
                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnInsert, "Add");
                toolTip1.SetToolTip(this.btnUpdate, "Update");
                toolTip1.SetToolTip(this.btnDelete, "Delete");
                toolTip1.SetToolTip(this.btnBack, "Back");

                DisplayData();

                //To fit Application to full Page
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                dataGridView1.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtDept.Text != "" && txtOffice.Text != "")
                {
                    //cmd = new SqlCommand("Insert into tblUserMgnt(CaseWorker) values(N'"+txtSection.Text+"')", conn);
                    cmd = new SqlCommand("Insert into tblDepartment(Department_Name,FromOffice) values(N'" + txtDept.Text + "',N'" + txtOffice.Text + "')", conn);
                    conn.Open();
                    //cmd.Parameters.AddWithValue("@CaseWorker", txtSection.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Document's Added Successfully:" + Environment.NewLine +
                        "Department Name : " + txtDept.Text + "" + Environment.NewLine +
                        "FromOffice Name : " + txtOffice.Text + "");
                    DisplayData();
                    ClearData();
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


        private void DisplayData()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                da = new SqlDataAdapter("select * from tblDepartment", conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception)
            {

            }
        }

        //Clear Data  
        private void ClearData()
        {
            try
            {
               txtDept.Text = "";
               txtOffice.Text = "";
                ID = 0;
            }
            catch (Exception)
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txtDept.Text != "" && txtOffice.Text != "")
                {
                    cmd = new SqlCommand("Update tblDepartment set Department_Name=N'" + txtDept.Text + "',FromOffice=N'" + txtOffice.Text + "' where ID=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Document's Updated Successfully:" + Environment.NewLine +
                         "Department Name : " + txtDept.Text + "" + Environment.NewLine +
                         "FromOffice Name : " + txtOffice.Text + "");
                    conn.Close();
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Select Document to Update");
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
                if (ID != 0)
                {
                    cmd = new SqlCommand("Delete tblDepartment where ID=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                     MessageBox.Show("Document's Deleted Successfully:" + Environment.NewLine +
                       "Department Name : " + txtDept.Text + "" + Environment.NewLine +
                       "Office Name : " + txtOffice.Text + "");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Select Document to Delete");
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
                var Dept = new Home();
                Dept.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtDept.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtOffice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dataGridView1.Rows[e.RowIndex].Cells["SlNo"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtDept_TextChanged(object sender, EventArgs e)
        {
            try
            {
            txtDept.BackColor = Color.PowderBlue;

            }
            catch (Exception)
            {

            }
        }

        private void txtOffice_TextChanged(object sender, EventArgs e)
        {
            try
            {
            txtOffice.BackColor = Color.PowderBlue;

            }
            catch (Exception)
            {

            }
        }
    }
}
