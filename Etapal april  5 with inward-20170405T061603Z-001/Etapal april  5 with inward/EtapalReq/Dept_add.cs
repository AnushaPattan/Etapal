using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EtapalReq
{
    public partial class Dept_add : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReqWO; integrated Security=true;");
        //SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        SqlDataAdapter da;
        SqlCommand cmd;
        int ID = 0;

        // To make datagridview columns uneditable

        private void UnEditableGridColums()
        {
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].ReadOnly = true;
            this.dataGridView1.Columns[2].ReadOnly = true;
        }

        public Dept_add()
        {
            InitializeComponent();
        }

        private void Dept_add_Load(object sender, EventArgs e)
        {
            try
            {
                UnEditableGridColums();

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
                UnEditableGridColums();


                if (txtDept.Text != "")
                {
                    //cmd = new SqlCommand("Insert into tblUserMgnt(CaseWorker) values(N'"+txtSection.Text+"')", conn);
                    cmd = new SqlCommand("Insert into tblDepartment(Department_Name) values(N'" + txtDept.Text + "')", conn);
                    conn.Open();
                    //cmd.Parameters.AddWithValue("@CaseWorker", txtSection.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Document's Added Successfully");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Enter Department Name !");
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
                UnEditableGridColums();

                if (txtDept.Text != "")
                {
                    cmd = new SqlCommand("Update tblDepartment set Department_Name=@Department_Name where ID=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@Department_Name", txtDept.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Document's Updated Successfully");
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
                UnEditableGridColums();

                if (ID != 0)
                {
                    cmd = new SqlCommand("Delete tblDepartment where ID=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Document's Deleted Successfully!");
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

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
