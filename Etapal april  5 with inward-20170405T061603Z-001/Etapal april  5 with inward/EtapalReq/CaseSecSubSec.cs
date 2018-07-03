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
    public partial class CaseSecSubSec : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlCommand cmd;
        SqlDataAdapter da;
        //ID variable used in Updating and Deleting Record  
        int Index = 0;

        public CaseSecSubSec()
        {
            InitializeComponent();
        }

        private void CaseSecSubSec_Load(object sender, EventArgs e)
        {
            //Note Delete Label
            lblDelete.Text = "NOTE : Right click on any row in the table to Delete the Row";


            //Today Date
            DateTime Today = DateTime.Now;
            lblTodayDateValue.Text = Today.ToString();

            //Full screen code
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

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

            //add Case Worker Dropdown

            SqlCommand cmd2 = new SqlCommand("select distinct CaseWorker from tblUserMgnt Order By CaseWorker", conn);
            conn.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                string name = dr2[0].ToString();
                cbToCaseWorker.Items.Add(name);
            }
            conn.Close();

            // Add Section Dropdown
            SqlCommand cmd1 = new SqlCommand("select distinct section from tblSubsectionManagement Order By section", conn);
            conn.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                string name = dr1[0].ToString();
                cbToSection.Items.Add(name);
            }
            conn.Close();

            //Fill datagrid
            DisplayData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbToCaseWorker.Text != "" && cbToSection.Text != "" && cbToSubsection.Text != "")
                {
                    conn.Close();
                    cmd = new SqlCommand("Insert into tblCaseSecSubsec(CaseWorker,Section,Subsection) "
                                + " values(N'" + cbToCaseWorker.Text + "',N'" + cbToSection.Text + "',N'" + cbToSubsection.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Document's Added Successfully:" + Environment.NewLine +
                        "Caseworker :  " + cbToCaseWorker.Text + "" + Environment.NewLine +
                        "Section : " + cbToSection.Text + "" + Environment.NewLine +
                        "Subsection : " + cbToSubsection.Text + "");

                }
                else
                {
                    MessageBox.Show("Please enter both Section and Subsection to Search!");
                }
                conn.Close();
                cbToSubsection.Items.Clear();
                cbToSection.SelectedIndex = -1;
                cbToSubsection.Text = "";
                cbToCaseWorker.SelectedIndex = -1;

                DisplayData();

            }
            catch (Exception)
            {

            }
        }

        private void DisplayData()
        {
            try
            {
                dataGridView_CaseSecSubsec.AutoGenerateColumns = false;
               
                DataTable dt = new DataTable();
                da = new SqlDataAdapter("select * from tblCaseSecSubsec", conn);
                da.Fill(dt);
                dataGridView_CaseSecSubsec.DataSource = dt;
               
                LoadSerial();
            }
            catch (Exception)
            {

            }
        }



        private void cbToSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //  Add Subsection Dropdown

                SqlCommand cmd4 = new SqlCommand("select distinct Subsection from tblSubsectionManagement where Section = N'" + cbToSection.SelectedItem + "' Order By Subsection", conn);
                conn.Open();
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    string name = dr4[0].ToString();
                    cbToSubsection.Items.Add(name);
                }
                conn.Close();
                cbToSection.BackColor = Color.PowderBlue;
            }
            catch (Exception)
            {

            }
        }



        private void dataGridView_CaseSecSubsec_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadSerial();
            }
            catch (Exception)
            {

            }
        }

        // Method for Generating Serial Numbers 
        private void LoadSerial()
        {
            try
            {
                int i = 1;
                foreach (DataGridViewRow row in dataGridView_CaseSecSubsec.Rows)
                {
                    row.Cells["SlNoCase"].Value = i;
                    i++;
                }

            }
            catch (Exception)
            {

            }
        }

        private void dataGridView_CaseSecSubsec_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView_CaseSecSubsec.Rows[e.RowIndex].Selected = true;
                this.Index = e.RowIndex;
                this.dataGridView_CaseSecSubsec.CurrentCell = this.dataGridView_CaseSecSubsec.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dataGridView_CaseSecSubsec, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to Delete", "confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string CaseWorker = dataGridView_CaseSecSubsec.Rows[Index].Cells[1].Value.ToString();
                string Section = dataGridView_CaseSecSubsec.Rows[Index].Cells[2].Value.ToString();
                string Subsection = dataGridView_CaseSecSubsec.Rows[Index].Cells[3].Value.ToString();
                // getting the id by index of row.  
                SqlCommand cmd = new SqlCommand("delete from tblCaseSecSubsec where CaseWorker=N'" + CaseWorker + "' and Section = N'" + Section + "' and Subsection = N'" + Subsection + "' ", conn);
              //  SqlCommand cmd = new SqlCommand("delete from tblCaseSecSubsec where CaseWorker=N'" + CaseWorker + "'", conn);
               
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayData();
                }
                else
                {
                    MessageBox.Show("Record not Deleted....Please try again.");
                }
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var Back = new Home();
                Back.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

    }
}
