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
    public partial class SearchWO : Form
    {

        //SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReqWO; integrated Security=true;");
        SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        SqlCommand cmd;


        public SearchWO()
        {
            InitializeComponent();
        }

        // To make datagridview columns uneditable
        private void UneditableGridColumn()
        {
            try
            {
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].ReadOnly = true;
            this.dataGridView1.Columns[2].ReadOnly = true;
            this.dataGridView1.Columns[3].ReadOnly = true;
            this.dataGridView1.Columns[4].ReadOnly = true;
            this.dataGridView1.Columns[5].ReadOnly = true;
            this.dataGridView1.Columns[6].ReadOnly = true;
            this.dataGridView1.Columns[7].ReadOnly = true;
            this.dataGridView1.Columns[8].ReadOnly = true;
            this.dataGridView1.Columns[9].ReadOnly = true;
            this.dataGridView1.Columns[10].ReadOnly = true;
            this.dataGridView1.Columns[11].ReadOnly = true;
            this.dataGridView1.Columns[12].ReadOnly = true;
            this.dataGridView1.Columns[13].ReadOnly = true;
            this.dataGridView1.Columns[14].ReadOnly = true;
            this.dataGridView1.Columns[15].ReadOnly = true;
            }
            catch (Exception)
            {

            }
        }


        // To Search  Record on button click

        private void SearchAll()
        {
            try
            {
                if (optDOLetter.Checked && txtSearch.Text == "")
                {
                    Search_DO_Letter();
                }
                else if (optGeneralLetter.Checked && txtSearch.Text == "")
                {
                    Search_General_Letter();
                }
                else if (optCourtCaseLetter.Checked && txtSearch.Text == "")
                {
                    Search_Court_Case_Letter();
                }
                else if (optRightToInformationLetter.Checked && txtSearch.Text == "")
                {
                    Search_Right_To_Info_Letter();

                }
                else if (optGovtLetter.Checked && txtSearch.Text == "")
                {
                    Search_Government_Letter();

                }
                else if (optGLNo.Checked && txtSearch.Text != "")
                {
                    Search_GL_No();
                }
                else if (radSurveyNumber.Checked && txtSearch.Text != "")
                {
                    Search_Survey_Number();
                }
                else if (radLetterNo.Checked && txtSearch.Text != "")
                {
                    Search_Letter_Number();
                }
                else if (optSubject.Checked && txtSearch.Text != "")
                {
                    Search_Subject();
                }
                else if (optGLNo.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter GL Number");
                }
                else if (optSubject.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter Subject");
                }
                else if (radSurveyNumber.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter Survey Number");
                }
                else if (radLetterNo.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter LetterNo Number");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                UneditableGridColumn();
                SearchAll();
                txtSearch.Text = "";
                //   LoadSerial();
                //LoadSerial(dataGridView1);
            }
            catch (Exception)
            {

            }
        }

        //Search Function for DO Letter

        private void Search_DO_Letter()
        {
            try
            {
                // string Dept = "FromDept" + " ''" + "Other_Dept as Department" ;
                //string DO_Letter = "Select DO_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker from tblReceiverNew where DO_Letter = @p1";
                //string DO_Letter = "Select Gl_No,Inward_No,Subject from tblReceiverNew where DO_Letter = @p1";
                //string DO_Letter_str = "DOLetter";
                string DO_Letter = "Select * from tblReceiverNew where DO_Letter = @p1";
                //string DO_Letter = "Select DO_Letter,Inward_No,Letter_No,Letter_Date,FromDept,isnull(Other_Dept,'-'),FromOffice,Subject,Gl_No,Signature,ToSection,ToSubSection,ToCaseWorker from tblReceiverNew where DO_Letter = @p1";
                cmd = new SqlCommand(DO_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", "DOLetter");
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the DO Letters";
                }
                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    DataGridViewLinkCell link = new DataGridViewLinkCell();
                //    link.Value = row.Cells[1].Value;
                //    row.Cells[1] = link;
                //}


                // Datagridview  function call

                // DatagridProp();
            }
            catch (Exception)
            {

            }

        }

        //Search Function for General Letter
        private void Search_General_Letter()
        {
            try
            {
                // string General_Letter_str = "GeneralLetter";
                //string Dept = "FromDept" + "''" + "Other_Dept as Department";
                //string General_Letter = "Select General_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker from tblReceiverNew  where General_Letter = @p1";
                string General_Letter = "Select * from tblReceiverNew where General_Letter = @p1";
                cmd = new SqlCommand(General_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", "GeneralLetter");
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the General Letters";
                }

                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    DataGridViewLinkCell link = new DataGridViewLinkCell();
                //    link.Value = row.Cells[0].Value;
                //    row.Cells[0] = link;
                //}


                // Datagridview  function call

                // DatagridProp();
            }
            catch (Exception)
            {

            }
        }

        //Search Function for Court Case Letter

        private void Search_Court_Case_Letter()
        {
            try
            {
                string Court_Case_Letter_str = "CourtCaseLetter";
                //string Dept = "FromDept" + "''" + "Others_Dept as Department";
                //string Court_Case_Letter = "Select Court_Case_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker  from tblReceiverNew where Court_Case_Letter = @p1";
                string Court_Case_Letter = "Select * from tblReceiverNew where Court_Case_Letter = @p1";
                cmd = new SqlCommand(Court_Case_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", Court_Case_Letter_str);
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Court Case Letters";
                }



                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    DataGridViewLinkCell link = new DataGridViewLinkCell();
                //    link.Value = row.Cells[0].Value;
                //    row.Cells[0] = link;
                //}

            }
            // Datagridview  function call

         //   DatagridProp();
            catch (Exception)
            {

            }
        }

        //Search Function for Right To Info Letter

        private void Search_Right_To_Info_Letter()
        {
            try
            {
                string Right_To_Info_Letter_str = "RightToInfoLetter";
                //string Dept = "FromDept" + "''" + "Others_Dept as Department";
                //string Right_To_Info_Letter = "Select Right_To_Info_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker  from tblReceiverNew  where Right_To_Info_Letter = @p1";

                string Right_To_Info_Letter = "Select * from tblReceiverNew where Right_To_Info_Letter = @p1";
                cmd = new SqlCommand(Right_To_Info_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", Right_To_Info_Letter_str);
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Right To Information Letters";
                }


                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    DataGridViewLinkCell link = new DataGridViewLinkCell();
                //    link.Value = row.Cells[0].Value;
                //    row.Cells[0] = link;
                //}


                // Datagridview  function call

                //DatagridProp();
            }
            catch (Exception)
            {

            }
        }

        //Search Function for Govt Letter

        private void Search_Government_Letter()
        {
            try
            {
                string Government_Letter_str = "GovernmentLetter";
                //string Dept = "FromDept" + "''" + "Others_Dept as Department";
                //string Right_To_Info_Letter = "Select Right_To_Info_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker  from tblReceiverNew  where Right_To_Info_Letter = @p1";

                string Government_Letter = "Select * from tblReceiverNew where Government_Letter = @p1";
                cmd = new SqlCommand(Government_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", Government_Letter_str);
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Government Letters";
                }


                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    DataGridViewLinkCell link = new DataGridViewLinkCell();
                //    link.Value = row.Cells[0].Value;
                //    row.Cells[0] = link;
                //}


                // Datagridview  function call

                //DatagridProp();
            }
            catch (Exception)
            {

            }
        }

       
        //Search Function for Subject

        private void Search_Subject()
        {
            try
            {
                string s = "";
                //s = string.Concat

                s = "select  * from tblReceiverNew R";
                //  s = string.Concat(s);
                string sub = " where (R.Subject LIKE @Search)";
                s = string.Concat(s, sub);
                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }
            }
            catch (Exception)
            {

            }
        }


        // Search Function for Survey Number

        private void Search_Survey_Number()
        {
            try
            {
                string Survey_Number = "Select * from tblReceiverNew where Survey_No = @p1";
                cmd = new SqlCommand(Survey_Number, conn);
                cmd.Parameters.AddWithValue("@p1", txtSearch.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }
            }
            catch (Exception)
            {

            }
        }

        // Search Function for Letter Number

        private void Search_Letter_Number()
        {
            try
            {
                string Letter_Number = "Select * from tblReceiverNew where Letter_No = @p1";
                cmd = new SqlCommand(Letter_Number, conn);
                cmd.Parameters.AddWithValue("@p1", txtSearch.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }
            }
            catch (Exception)
            {

            }
        }

        // Search Function for  GL No

        private void Search_GL_No()
        {
            try
            {
                string GL_No = "select  * from tblReceiverNew where  Gl_No ='" + txtSearch.Text + "'";
                cmd = new SqlCommand(GL_No, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
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
                var Back = new Home();
                Back.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void SearchWO_Load(object sender, EventArgs e)
        {
            try
            {
                UneditableGridColumn();

                lblLetterDetails.Visible = false;

                optDOLetter.Checked = true;

                //  LoadSerial();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // dataGridView1.Columns[0].Name = "GlNo";

                //dataGridView1.Columns[1].Name = "Inward_No";
                //dataGridView1.Columns[2].Name = "Letter_No";
                //dataGridView1.Columns[3].Name = "Received_Date";
                //dataGridView1.Columns[4].Name = "Letter_Date";
                //dataGridView1.Columns[5].Name = "FromDept";
                //dataGridView1.Columns[6].Name = "FromDept";
                //dataGridView1.Columns[7].Name = "Other_Dept";
                //dataGridView1.Columns[8].Name = "FromOffice";
                //dataGridView1.Columns[9].Name = "ToSection";
                //dataGridView1.Columns[10].Name = "ToSubSection";
                //dataGridView1.Columns[11].Name = "ToCaseWorker";
                //dataGridView1.Columns[12].Name = "DO_Letter";
                //dataGridView1.Columns[13].Name = "General_Letter";
                //dataGridView1.Columns[14].Name = "Court_Case_Letter";
                //dataGridView1.Columns[15].Name = "Right_To_Info_Letter";



                //dataGridView1.Columns[15].DataPropertyName = "Gl_No";
                //dataGridView1.Columns[4].DataPropertyName = "Inward_No";
                //dataGridView1.Columns[11].DataPropertyName = "Subject";
                //dataGridView1.Columns[5].DataPropertyName = "Letter_No";
                //dataGridView1.Columns[6].DataPropertyName = "Received_Date";
                //dataGridView1.Columns[7].DataPropertyName = "Letter_Date";
                //dataGridView1.Columns[8].DataPropertyName = "FromDept";
                //dataGridView1.Columns[9].DataPropertyName = "Other_Dept";
                //dataGridView1.Columns[10].DataPropertyName = "FromOffice";
                //dataGridView1.Columns[12].DataPropertyName = "ToSection";
                //dataGridView1.Columns[13].DataPropertyName = "ToSubSection";
                //dataGridView1.Columns[14].DataPropertyName = "ToCaseWorker";
                //dataGridView1.Columns[0].DataPropertyName = "DO_Letter";
                //dataGridView1.Columns[1].DataPropertyName = "General_Letter";
                //dataGridView1.Columns[2].DataPropertyName = "Court_Case_Letter";
                //dataGridView1.Columns[3].DataPropertyName = "Right_To_Info_Letter";



                if (dataGridView1.Columns[e.ColumnIndex].Name == "GlNo")
                {
                    //DataGridViewColumn column = new DataGridViewColumn();
                    //column.DataPropertyName = "Gl_No";
                    dataGridView1.Rows[e.RowIndex].ReadOnly = true;

             

                    // Need Important

                    string DOLetter = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string GeneralLetter = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string CourtCaseLetter = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string RightToInfoLetter = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    //string InwardNo = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string LetterNo = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string ReceiveDate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string LetterDate = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string FromDept = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string OtherDept = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string FromOffice = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string Sub = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string ToSection = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                    //string ToSubSection = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                    string ToCaseWorker = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                    string GLNo = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                    string GovernmentLetter = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
                    string ApplicantName = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();

                

                    // Imp
                    string message = "GL No : " + GLNo +"\nLetter No : " + LetterNo + "\nReceived Date : " + ReceiveDate + "\nLetter Date : " + LetterDate + "\nFrom Department : " + FromDept + "\nOther Dept : " + OtherDept + "\nFrom Office : " + FromOffice + "\nSubject : " + Sub + "\nTo Section : " + ToSection + "\nTo Case Worker : " + ToCaseWorker + "\nDO Letter : " + DOLetter + "\nGl Letter : " + GeneralLetter + "\nCourt Case Letter : " + CourtCaseLetter + "\nRight To Information Letter : " + RightToInfoLetter + "\nGovernment Letter : " + GovernmentLetter + "\nApplicant Name  :" + ApplicantName;
                    //string message = "GL NO : " + GLNo + "\nInward No : " + InwardNo + "\nSubject : " + Sub ;

                

                    MessageBox.Show(message);
                }

                //catch (IndexOutOfRangeException)
                //{
                //    MessageBox.Show("Please click on Reference Link to View Details......");
                //}
                //catch (Exception)
                //{
                //    // MessageBox.Show("Please Enter valid Reference Number.......");
                //}
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

        private void optGeneralLetter_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
