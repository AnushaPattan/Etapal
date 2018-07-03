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
    public partial class SearchGovernment : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
       // SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
       
      //  SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReqWO; integrated Security=true;");
     //   SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        SqlCommand cmd;

        public SearchGovernment()
        {
            InitializeComponent();
        }


        // To make datagridview columns uneditable
        private void UneditableGridColumn()
        {
            try
            {
                this.dataGridView_Search_GL_No.Columns[0].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[1].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[2].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[3].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[4].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[5].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[6].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[7].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[8].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[9].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[10].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[11].ReadOnly = true;
                this.dataGridView_Search_GL_No.Columns[12].ReadOnly = true;
              //  this.dataGridView_Search_GL_No.Columns[13].ReadOnly = true;
                //this.dataGridView_Search_GL_No.Columns[14].ReadOnly = true;
                //this.dataGridView_Search_GL_No.Columns[15].ReadOnly = true;
                //this.dataGridView_Search_GL_No.Columns[16].ReadOnly = true;
                //this.dataGridView_Search_GL_No.Columns[17].ReadOnly = true;
                //this.dataGridView_Search_GL_No.Columns[18].ReadOnly = true;
                //this.dataGridView_Search_GL_No.Columns[19].ReadOnly = true;


                this.dataGridViewDOLetter.Columns[0].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[1].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[2].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[3].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[4].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[5].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[6].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[7].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[8].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[9].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[10].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[11].ReadOnly = true;
                this.dataGridViewDOLetter.Columns[12].ReadOnly = true;
                //this.dataGridViewDOLetter.Columns["DOletter"].ReadOnly = true;
                //this.dataGridViewDOLetter.Columns[13].ReadOnly = true;
                //this.dataGridViewDOLetter.Columns[14].ReadOnly = true;
                //this.dataGridViewDOLetter.Columns[15].ReadOnly = true;
                
            }
            catch (Exception)
            {

            }
        }

        private void SearchGovernment_Load(object sender, EventArgs e)
        {
            try
            {
                UneditableGridColumn();

                lblLetterDetails.Visible = false;

                optGLNo.Checked = true;

                dataGridView_Search_GL_No.Visible = true;
                dataGridViewDOLetter.Visible = false;
                dataGridView_All_letters.Visible = false;

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

        // To Search  Record on button click

        private void SearchAll()
        {
            try
            {
                if (optDOLetter.Checked && txtSearch.Text == "")
                {
                    Search_DO_Letter();
                    dataGridView_Search_GL_No.Visible = false;
                    dataGridViewDOLetter.Visible = true;
                    dataGridView_All_letters.Visible = false;
                    
                }
               else if (optCourtCaseLetter.Checked && txtSearch.Text == "")
                {
                    Search_Court_Case_Letter();
                    dataGridView_Search_GL_No.Visible = false;
                    dataGridViewDOLetter.Visible = true;
                    dataGridView_All_letters.Visible = false;
                }
                else if (optRightToInformationLetter.Checked && txtSearch.Text == "")
                {
                    Search_Right_To_Info_Letter();
                    dataGridView_Search_GL_No.Visible = false;
                    dataGridViewDOLetter.Visible = true;
                    dataGridView_All_letters.Visible = false;

                }
                else if (optGovtLetter.Checked && txtSearch.Text == "")
                {
                    Search_Government_Letter();
                    dataGridView_Search_GL_No.Visible = false;
                    dataGridViewDOLetter.Visible = true;
                    dataGridView_All_letters.Visible = false;
                }
                else if (radLokayuktaLetter.Checked && txtSearch.Text == "")
                {
                    Search_Lokayukta_ABS_Letter();
                    dataGridView_Search_GL_No.Visible = false;
                    dataGridViewDOLetter.Visible = true;
                }
                else if (radAllLetters.Checked && txtSearch.Text == "")
                {
                    Search_All_Letters();
                    dataGridView_Search_GL_No.Visible = false;
                    dataGridViewDOLetter.Visible = false;
                    dataGridView_All_letters.Visible = true;
                    
                } 
                else if (optGLNo.Checked && txtSearch.Text != "")
                {
                    Search_GL_No();
                    lblLetterDetails.Visible = false;
                    dataGridView_Search_GL_No.Visible = true;
                    dataGridViewDOLetter.Visible = false;
                    dataGridView_All_letters.Visible = false;
                }
                else if (radLetterNo.Checked && txtSearch.Text != "")
                {
                    Search_Letter_Number();
                    lblLetterDetails.Visible = false;
                    dataGridView_Search_GL_No.Visible = true;
                    dataGridViewDOLetter.Visible = false;
                    dataGridView_All_letters.Visible = false;
                }
                
                else if (optSubject.Checked && txtSearch.Text != "")
                {
                    Search_Subject();
                    lblLetterDetails.Visible = false;
                    dataGridView_Search_GL_No.Visible = true;
                    dataGridViewDOLetter.Visible = false;
                    dataGridView_All_letters.Visible = false;
                
                }
                else if (optGLNo.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter GL Number");
                }
                else if (optSubject.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter Subject");
                }
               else if (radLetterNo.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter Letter Number");
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
                string DO_Letter = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Signature from tblGovernmentLetter_WO where DO_Letter = @p1 Order by GL_No_Id";
                //string DO_Letter = "Select DO_Letter,Inward_No,Letter_No,Letter_Date,FromDept,isnull(Other_Dept,'-'),FromOffice,Subject,Gl_No,Signature,ToSection,ToSubSection,ToCaseWorker from tblReceiverNew where DO_Letter = @p1";
                cmd = new SqlCommand(DO_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", "DOLetter");
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDOLetter.DataSource = dt;
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


        //Search Function for Court Case Letter

        private void Search_Court_Case_Letter()
        {
            try
            {
                string Court_Case_Letter_str = "CourtCaseLetter";
                //string Dept = "FromDept" + "''" + "Others_Dept as Department";
                //string Court_Case_Letter = "Select Court_Case_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker  from tblReceiverNew where Court_Case_Letter = @p1";
                string Court_Case_Letter = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Signature from tblGovernmentLetter_WO where Court_Case_Letter = @p1 Order by GL_No_Id";
                cmd = new SqlCommand(Court_Case_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", Court_Case_Letter_str);
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDOLetter.DataSource = dt;
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

                string Right_To_Info_Letter = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Signature from tblGovernmentLetter_WO where Right_To_Info_Letter = @p1 Order by GL_No_Id";
                cmd = new SqlCommand(Right_To_Info_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", Right_To_Info_Letter_str);
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDOLetter.DataSource = dt;
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

                string Government_Letter = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Signature from tblGovernmentLetter_WO where Government_Letter = @p1 Order by GL_No_Id";
                cmd = new SqlCommand(Government_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", Government_Letter_str);
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDOLetter.DataSource = dt;
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

        //Search Function for Lokayukta/ABS Letter

        private void Search_Lokayukta_ABS_Letter()
        {
            try
            {
                string Lokayukta_ABS_Letter_str = "LokayuktaLetter";
                //string Dept = "FromDept" + "''" + "Others_Dept as Department";
                //string Right_To_Info_Letter = "Select Right_To_Info_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker  from tblReceiverNew  where Right_To_Info_Letter = @p1";

                string Lokayukta_ABS_Letter = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Signature  from tblGovernmentLetter_WO where Lokayukta_ABS_Letter = @p1 Order by GL_No_Id";
                cmd = new SqlCommand(Lokayukta_ABS_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", Lokayukta_ABS_Letter_str);
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDOLetter.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Lokayukta Letters";
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

                s = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Signature,isnull(DO_Letter, '    ------') as DOletter,isnull(Court_Case_Letter, '   -------') as CourtCaseLetter,isnull(Right_To_Info_Letter,'    ---------') as RightToInfoLetter, isnull(Government_Letter,'    -------') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -------') as LokayuktaABSLetter   from tblGovernmentLetter_WO R Order by GL_No_Id";
                //  s = string.Concat(s);
                string sub = " where (R.Subject LIKE @Search)";
                s = string.Concat(s, sub);
                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Search_GL_No.DataSource = dt;
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
                //string Letter_Number = "Select * from tblGovernmentLetter_WO where Letter_No = @p1";
                string Letter_Number = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Signature,isnull(DO_Letter, '    -----') as DOletter,isnull(Court_Case_Letter, '   ------') as CourtCaseLetter,isnull(Right_To_Info_Letter,'    -------') as RightToInfoLetter, isnull(Government_Letter,'    ------') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -------') as LokayuktaABSLetter  from tblGovernmentLetter_WO where Letter_No = @p1 Order by GL_No_Id";
                cmd = new SqlCommand(Letter_Number, conn);
                cmd.Parameters.AddWithValue("@p1", txtSearch.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Search_GL_No.DataSource = dt;
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
                string GL_No = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Signature,isnull(DO_Letter, '    ------') as DOletter,isnull(Court_Case_Letter, '   ------') as CourtCaseLetter,isnull(Right_To_Info_Letter,'    ------') as RightToInfoLetter, isnull(Government_Letter,'    ------') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -----') as LokayuktaABSLetter   from tblGovernmentLetter_WO where  GL_No_Id ='" + txtSearch.Text + "' Order by GL_No_Id";
                cmd = new SqlCommand(GL_No, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Search_GL_No.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }

            }
            catch (Exception)
            {

            }
        }


        //Search Function for All Letter

        private void Search_All_Letters()
        {
            try
            {
                string All_Letters = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Signature,isnull(DO_Letter, '    ------') as DOletter,isnull(Court_Case_Letter, '   ------') as CourtCaseLetter,isnull(Right_To_Info_Letter,'    -----') as RightToInfoLetter, isnull(Government_Letter,'    -----') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -----') as LokayuktaABSLetter  from tblGovernmentLetter_WO Order by GL_No_Id";
                //string DO_Letter = "Select DO_Letter,Inward_No,Letter_No,Letter_Date,FromDept,isnull(Other_Dept,'-'),FromOffice,Subject,Gl_No,Signature,ToSection,ToSubSection,ToCaseWorker from tblReceiverNew where DO_Letter = @p1";
                cmd = new SqlCommand(All_Letters, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_All_letters.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Details of All Letters";
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

        private void dataGridView_Search_GL_No_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dataGridView_Search_GL_No.Rows[e.RowIndex].Cells["SlNo"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView_Search_GL_No_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                if (dataGridView_Search_GL_No.Columns[e.ColumnIndex].Name == "GlNoId")
                {
                    //DataGridViewColumn column = new DataGridViewColumn();
                    //column.DataPropertyName = "Gl_No";
                    dataGridView_Search_GL_No.Rows[e.RowIndex].ReadOnly = true;

                    // Need Important

                    //string DOLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //string RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[3].Value.ToString();
                    //string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[4].Value.ToString();
                    //string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[5].Value.ToString();
                    //string LetterNo = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[6].Value.ToString();
                    //string ReceiveDate = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[7].Value.ToString();
                    //string LetterDate = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[8].Value.ToString();
                    //string FromDept = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[9].Value.ToString();
                    //string FromOtherDept = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[10].Value.ToString();
                    //string FromOffice = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[11].Value.ToString();
                    //string ToSection = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[12].Value.ToString();
                    //string ToCaseWorker = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[13].Value.ToString();
                    //string Subject = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[14].Value.ToString();
                    //string Hobli = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    //string Village = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();
                    //string GLNoId = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[17].Value.ToString();
                    //string Signature = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[18].Value.ToString();


                    //string GLNoId = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //string LetterNo = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //string FromDept = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[3].Value.ToString();
                    //string ReceiveDate = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[4].Value.ToString();
                    //string Subject = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[5].Value.ToString();
                    //string ToSection = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[6].Value.ToString();

                    //string ToCaseWorker = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[7].Value.ToString();

                    //string Signature = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[8].Value.ToString();

                    //string Hobli = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[9].Value.ToString();

                    //string Village = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[10].Value.ToString();
                    //string FromOffice = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[11].Value.ToString();
                    //string FromOtherDept = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[12].Value.ToString();
                    //string LetterDate = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[13].Value.ToString();

                    //string DOLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[14].Value.ToString();
                    //string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    //string RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();
                    //string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[17].Value.ToString();
                    //string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[18].Value.ToString();


                    string LetterNo = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string ReceiveDate = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string LetterDate = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string FromDept = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string FromOffice = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string ToSection = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string ToCaseWorker = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string Subject = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string Hobli = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string Village = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string GLNoId = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string Signature = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[12].Value.ToString();
                    string DOLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[13].Value.ToString();
                    string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[14].Value.ToString();
                    string  RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();
                    string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[17].Value.ToString();
                    
                

                    // Imp
                    string message = "GL Number\t  :   " + GLNoId + "\nLetter Number :  " + LetterNo + "\nReceived Date :   " + ReceiveDate + "\nLetter Date  :     " + LetterDate + "\nFrom Department  :  " + FromDept + "\nFrom Office : " + FromOffice + "\nSubject  :   \n  " + Subject + "\nTo Section :  " + ToSection + "\nTo Case Worker :" + ToCaseWorker + "\n DO Letter:   " + DOLetter + "\n CourtCase Letter :" + CourtCaseLetter + "\n Right to Information Letter :  " + RightToInfoLetter + "\n Government Letter : " + GovernmentLetter + " \nLokayukta   : " + LokayuktaABSLetter + "\n Hobli : " + Hobli + "\n Village  : " + Village;
                   

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

        private void dataGridViewDOLetter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                if (dataGridViewDOLetter.Columns[e.ColumnIndex].Name == "GlNoIdDO")
                {
                    
                    dataGridViewDOLetter.Rows[e.RowIndex].ReadOnly = true;

                    // Need Important
                    string LetterNo = dataGridViewDOLetter.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string ReceiveDate = dataGridViewDOLetter.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string LetterDate = dataGridViewDOLetter.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string FromDept = dataGridViewDOLetter.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string FromOffice = dataGridViewDOLetter.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string ToSection = dataGridViewDOLetter.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string ToCaseWorker = dataGridViewDOLetter.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string Subject = dataGridViewDOLetter.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string Hobli = dataGridViewDOLetter.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string Village = dataGridViewDOLetter.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string GLNoId = dataGridViewDOLetter.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string Signature = dataGridViewDOLetter.Rows[e.RowIndex].Cells[12].Value.ToString();

                    //string DOLetter = dataGridViewDOLetter.Rows[e.RowIndex].Cells[14].Value.ToString();
                    //string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    //string  RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();
                    //string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[17].Value.ToString();
                    //string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[18].Value.ToString();

                    // Imp
                    string message = "GL Number\t :   " + GLNoId + "\nLetter Number :  " + LetterNo + "\nReceived Date    :   " + ReceiveDate + "\nLetter Date    :     " + LetterDate + "\nFrom Department   :  " + FromDept + "\nFrom Office : " + FromOffice + "\nSubject :   \n  " + Subject + "\nTo Section   :  " + ToSection + "\nTo Case Worker :     " + ToCaseWorker + "\n Hobli  : " + Hobli + "\n Village  : " + Village;
                    MessageBox.Show(message);
                }

                //catch (IndexOutOfRangeException)
                //{
                //    MessageBox.Show("Please click on Reference Link to View Details......");
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Please Enter valid Reference Number.......");
                //}
            }
             catch (Exception)
             {

             }

        }

        private void dataGridViewDOLetter_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dataGridViewDOLetter.Rows[e.RowIndex].Cells["SlNoDO"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView_All_letters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView_All_letters.Columns[e.ColumnIndex].Name == "GlNoIdAll")
                {

                    dataGridView_All_letters.Rows[e.RowIndex].ReadOnly = true;

                    // Need Important
                    string LetterNo = dataGridView_All_letters.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string ReceiveDate = dataGridView_All_letters.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string LetterDate = dataGridView_All_letters.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string FromDept = dataGridView_All_letters.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string FromOffice = dataGridView_All_letters.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string ToSection = dataGridView_All_letters.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string ToCaseWorker = dataGridView_All_letters.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string Subject = dataGridView_All_letters.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string Hobli = dataGridView_All_letters.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string Village = dataGridView_All_letters.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string GLNoId = dataGridView_All_letters.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string Signature = dataGridView_All_letters.Rows[e.RowIndex].Cells[12].Value.ToString();

                    //string DOLetter = dataGridViewDOLetter.Rows[e.RowIndex].Cells[14].Value.ToString();
                    //string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    //string  RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();
                    //string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[17].Value.ToString();
                    //string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[18].Value.ToString();

                    // Imp
                    string message = "GL Number :   " + GLNoId + "\nLetter Number :  " + LetterNo + "\nReceived Date    :   " + ReceiveDate + "\nLetter Date    :     " + LetterDate + "\nFrom Department   :  " + FromDept + "\nFrom Office : " + FromOffice + "\nSubject :   \n  " + Subject + "\nTo Section   :  " + ToSection + "\nTo Case Worker :     " + ToCaseWorker + "\n Hobli  : " + Hobli + "\n Village  : " + Village;
                    MessageBox.Show(message);
                }

                //catch (IndexOutOfRangeException)
                //{
                //    MessageBox.Show("Please click on Reference Link to View Details......");
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Please Enter valid Reference Number.......");
                //}
            }
            catch (Exception)
            {

            }

        }

        private void dataGridView_All_letters_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dataGridView_All_letters.Rows[e.RowIndex].Cells["SlNoAll"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {

            }
        }

        //private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //    try
        //    {
               
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
        
    }
}
