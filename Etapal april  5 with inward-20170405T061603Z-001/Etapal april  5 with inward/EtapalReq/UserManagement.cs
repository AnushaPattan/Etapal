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
    public partial class UserManagement : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlDataAdapter da;
        SqlCommand cmd;
        int ID = 0;
        public UserManagement()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtSection.Text != "")
                {
                    //cmd = new SqlCommand("Insert into tblUserMgnt(CaseWorker) values(N'"+txtSection.Text+"')", conn);
                    cmd = new SqlCommand("Insert into tblUserMgnt(CaseWorker) values(N'"+ txtSection.Text + "')", conn);
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
                    MessageBox.Show("Please Enter CaseWorker Details!");
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
                da = new SqlDataAdapter("select * from tblUserMgnt", conn);
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
                txtSection.Text = "";
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
              

                if (txtSection.Text != "")
                {
                    cmd = new SqlCommand("Update tblUserMgnt set CaseWorker=@CaseWorker where ID=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@CaseWorker",txtSection.Text);
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
               

                if (ID != 0)
                {
                    cmd = new SqlCommand("Delete tblUserMgnt where ID=@id", conn);
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
                var CaseWorker = new Home();
                CaseWorker.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtSection.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
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
    }
}
