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
    public partial class SectionSubsectionManagement : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlCommand cmd;
        SqlDataAdapter da;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public SectionSubsectionManagement()
        {
            InitializeComponent();
        }

        private void SectionSubsectionManagement_Load(object sender, EventArgs e)
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

            }
            catch (Exception)
            {

            }
        }



        //Display Data in DataGridView  
        private void DisplayData()
        {
            try
            {
              // conn.Open();
                DataTable dt = new DataTable();
                //  da = new SqlDataAdapter("select S.Section,R.Subsection from tblSectionManagement S join tblSubsectionManagement R on S.ID=R.ID", conn);

                da = new SqlDataAdapter("select * from tblSubsectionManagement Order by Section ", conn);
                da.Fill(dt);
                dataGridView_SectionSubsection_Mgmt.DataSource = dt;
               // conn.Close();
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
                txtSubsection.Text = "";
                //  txtSubSection.Text = "";
                ID = 0;
            }
            catch (Exception)
            {

            }
        }

        // To add record

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                 if (txtSection.Text != "" && txtSubsection.Text != "")
                {
                    conn.Close();
                     cmd = new SqlCommand("Insert into tblSubsectionManagement(Section,Subsection) values(N'" + txtSection.Text + "',N'" + txtSubsection.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Document's Added Successfully:" + Environment.NewLine +
                        "Section : " + txtSection.Text + "" + Environment.NewLine +
                        "Subsection : " + txtSubsection.Text + "");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please enter both Section and Subsection to Search!");
                }
                 conn.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //  UnEditableGridColums();

                if (txtSection.Text != "" && txtSubsection.Text != "")
                {
                    cmd = new SqlCommand("Update tblSubsectionManagement set Section=N'" + txtSection.Text + "',Subsection=N'" + txtSubsection.Text + "' where ID=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
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
                    cmd = new SqlCommand("Delete tblSubsectionManagement where ID=@id", conn);
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

        private void dataGridView_SectionSubsection_Mgmt_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView_SectionSubsection_Mgmt.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtSection.Text = dataGridView_SectionSubsection_Mgmt.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSubsection.Text = dataGridView_SectionSubsection_Mgmt.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView_SectionSubsection_Mgmt_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dataGridView_SectionSubsection_Mgmt.Rows[e.RowIndex].Cells["SlNo"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
