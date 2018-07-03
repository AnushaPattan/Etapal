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
    public partial class Search : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReq; integrated Security=true;");
        SqlCommand cmd;
        //SqlDataAdapter da;

        public Search()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                lblSearch.Text = "Enter" + " " + radioButton1.Text;
            }
            catch (Exception)
            {

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                lblSearch.Text = "Enter" + " " + radioButton2.Text;
            }
            catch (Exception)
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                lblSearch.Text = "Enter" + " " + radioButton3.Text;
            }
            catch (Exception)
            {

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                lblSearch.Text = "Enter" + " " + radioButton4.Text;
            }
            catch (Exception)
            {

            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            try
            {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnSearch, "Search");
                toolTip1.SetToolTip(this.btnBack, "Back");
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            catch (Exception)
            {

            }
        }

        public void ser()
        {
            //string s = "";
            //s = string.Concat

            //s = "select distinct * from tblReceiver  R";
            //  s = string.Concat(s); 
            if (radioButton1.Checked && txtSearch.Text != "")
            {
                Search_Number();
                //string GLNo = "  join tblReceiver G on G.DO_No = '" + txtSearch.Text + "' or G.General_letterNo ='" + txtSearch.Text + "' where G.DO_No='" + txtSearch.Text + "'";
                //s = string.Concat(s, GLNo);
            }
            else if (radioButton2.Checked && txtSearch.Text != "")
            {
                Search_AckNumber();
                //string ack = "  join tblReceiver G on R.AckNumber = '" + txtSearch.Text + "' and G.AckNumber='" + txtSearch.Text + "'";
                //s = string.Concat(s, ack);
            }
            else if (radioButton3.Checked && txtSearch.Text != "")
            {
                Search_InwardNumber();
                //string Inward = "  join tblReceiver G on R.InwardNumber = '" + txtSearch.Text + "' and  G.InwardNumber = '" + txtSearch.Text + "'";
                //s = string.Concat(s, Inward);
            }
            else if (radioButton4.Checked && txtSearch.Text != "")
            {
                Search_Subject();
              //  SELECT * FROM Contacts WHERE Name like @person + '%'
                //string sub = " where (R.Subject LIKE @Search)"; 
                //s = string.Concat(s, sub);
            }
            else if(txtSearch.Text ==  "")
            {
                MessageBox.Show("Please Enter value for Search");
            }

        //    SqlCommand cmd = new SqlCommand(s, conn);
        //    cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%"); 
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable ds = new DataTable();
        //    da.Fill(ds);
        //    dataGridView1.DataSource = ds;
       }

        // To Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ser();
                txtSearch.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var Back = new Home1();
                Back.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void Search_Number()
        {
            string Number = "select distinct * from tblReceiver_ where  GL_No ='" + txtSearch.Text + "'";
            cmd = new SqlCommand(Number, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
        }
        private void Search_AckNumber()
        {
            string AckNumber = "select distinct * from tblReceiver_ where  Ack_No ='" + txtSearch.Text + "'";
            cmd = new SqlCommand(AckNumber, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
        }
        private void Search_InwardNumber()
        {
            string Inward_No = "select distinct * from tblReceiver_ where  Inward_No ='" + txtSearch.Text + "'";
            cmd = new SqlCommand(Inward_No, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
        }

        private void Search_Subject()
        {
            string s = "";
            //s = string.Concat

            s = "select distinct * from tblReceiver_  R";
            //  s = string.Concat(s);
            string sub = " where (R.Subject LIKE @Search)";
            s = string.Concat(s, sub);
            SqlCommand cmd = new SqlCommand(s, conn);
            cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "GL_No")
                {
                    dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                    string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string GLNo = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string InwardNo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string ACKNo = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string ReciveDate = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string LetterDate = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string FromDept = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string OtherDept = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string FromOffice = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string Sub = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string ToSection = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string ToCaseWorker = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string message = "Id : " + id + "\nGL NO : " + GLNo + "\nInward No : " + InwardNo + "\nAck No : " + ACKNo + "\nReceived Date : " + ReciveDate + "\nLetter Date : " + LetterDate + "\nFrom Department : " + FromDept + "\nOther Dept : " + OtherDept + "\nFrom Office : " + FromOffice + "\nSubject : " + Sub + "\nTo Section : " + ToSection + "\nTo Casee Worker : " + ToCaseWorker;
                    MessageBox.Show(message);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please click on Reference Link to View Details......");
            }
            catch (Exception)
            {
                // MessageBox.Show("Please Enter valid Reference Number.......");
            }
        }
    }
}
