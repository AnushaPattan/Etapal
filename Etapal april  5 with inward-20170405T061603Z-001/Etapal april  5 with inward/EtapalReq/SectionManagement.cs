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
    public partial class SectionManagement : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
      //  SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
       
      //  SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReqWO; integrated Security=true;");
      //   SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        SqlCommand cmd;
        SqlDataAdapter da;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public SectionManagement()
        {
            InitializeComponent();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            try
            {
            conn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from tblSectionManagement", conn);
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
          //  txtSubSection.Text = "";
            ID = 0;
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
              //  txtSubSection.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

      

        //Update Record
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                UnEditableGridColums();

                if (txtSection.Text != "" )
                {
                    cmd = new SqlCommand("Update tblSectionManagement set Section=@Section where ID=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@Section", txtSection.Text);
                   // cmd.Parameters.AddWithValue("@SubSection", txtSubSection.Text);
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
                    cmd = new SqlCommand("Delete tblSectionManagement where ID=@id", conn);
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

        // To Add Record
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                UnEditableGridColums();

                if (txtSection.Text != "" )
                {
                    //string section = "'"+txtSection.Text+"'";
                   // string Subsection = "'"+txtSubSection.Text+"'"; 
                    cmd = new SqlCommand("Insert into tblSectionManagement(Section) values(N'" + txtSection.Text + "')", conn);
                    conn.Open();
                   // cmd.Parameters.AddWithValue("@Section", section);
                   // cmd.Parameters.AddWithValue("@SubSection", Subsection);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Document's Added Successfully");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Enter Section");
                }
            }
            catch (Exception)
            {

            }
        }

        // To make datagridview columns uneditable
            
        private void UnEditableGridColums()
        {
            try
            {
                this.dataGridView1.Columns[0].ReadOnly = true;
                this.dataGridView1.Columns[1].ReadOnly = true;
                this.dataGridView1.Columns[2].ReadOnly = true;
                this.dataGridView1.Columns[3].ReadOnly = true;

            }
            catch (Exception)
            {

            }
        }

        private void SectionManagement_Load(object sender, EventArgs e)
        {
            try
            {
                UnEditableGridColums();

                DisplayData();

                //Tooltips
                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnInsert, "Add");
                toolTip1.SetToolTip(this.btnUpdate, "Update");
                toolTip1.SetToolTip(this.btnDelete, "Delete");
                toolTip1.SetToolTip(this.btnBack, "Back");
              //  toolTip1.SetToolTip(this.dataGridView1, "Click here to Update");

                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                // Datagrid view column width
                // dataGridView1.Columns[1].Width = 20;
                //dataGridView1.Columns[2].Width = 200;  

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
