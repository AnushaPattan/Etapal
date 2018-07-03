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
    public partial class SearchGeneral : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        //SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
       
      //  SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReqWO; integrated Security=true;");
       // SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        SqlCommand cmd;

        public SearchGeneral()
        {
            InitializeComponent();
        }

        private void SearchGeneral_Load(object sender, EventArgs e)
        {
            try
            {
                optGLNo.Checked = true;
                dataGridViewSearch_General.Visible = true;

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



        //private void SearchAll()
        //{
        //    try
        //    {
                
                
        //         if (optGeneralLetter.Checked && txtSearch.Text == "")
        //        {
        //            Search_General_Letter();
        //            dataGridViewSearch_General.Visible = true;

        //        }
        //         else if (optGLNo.Checked && txtSearch.Text != "")
        //         {
        //             Search_GL_No();
        //             lblLetterDetails.Visible = false;
        //             dataGridViewSearch_General.Visible = true;
        //         }
        //         else if (radLetterNo.Checked && txtSearch.Text != "")
        //         {
        //             Search_Letter_Number();
        //             lblLetterDetails.Visible = false;
        //             dataGridViewSearch_General.Visible = true;
        //         }

        //         else if (optSubject.Checked && txtSearch.Text != "")
        //         {
        //             Search_Subject();
        //             lblLetterDetails.Visible = false;
        //             dataGridViewSearch_General.Visible = true;

        //         }
        //         else if (optGLNo.Checked && txtSearch.Text == "")
        //         {
        //             MessageBox.Show("Please Enter GL Number");
        //         }
        //         else if (optSubject.Checked && txtSearch.Text == "")
        //         {
        //             MessageBox.Show("Please Enter Subject");
        //         }
        //         else if (radLetterNo.Checked && txtSearch.Text == "")
        //         {
        //             MessageBox.Show("Please Enter Letter Number");
        //         }
        //         else if (radSurveyNumber.Checked && txtSearch.Text == "")
        //         {
        //             MessageBox.Show("Please Enter Survey Number");
        //         }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                SearchAll();
                txtSearch.Text = "";
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
                string General_Letter = "Select General_Letter,Applicant_Name,Hobli,Village,Received_Date,Letter_Date,Letter_No,Survey_No,From_Other_Dept,ToSection,ToCaseWorker,Subject,GL_No_Id from tblGeneralLetter_WO where General_Letter = @p1 Order by GL_No_Id";
                cmd = new SqlCommand(General_Letter, conn);
                cmd.Parameters.AddWithValue("@p1", "GeneralLetter");
                // cmd.Parameters.AddWithValue("@Dept", Dept);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSearch_General.DataSource = dt;
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
                string GL_No = "Select General_Letter,Applicant_Name,Hobli,Village,Received_Date,Letter_Date,Letter_No,Survey_No,From_Other_Dept,ToSection,ToCaseWorker,Subject,GL_No_Id from tblGeneralLetter_WO  where  GL_No_Id ='" + txtSearch.Text + "'";
                cmd = new SqlCommand(GL_No, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSearch_General.DataSource = dt;
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
                string Letter_Number = "Select General_Letter,Applicant_Name,Hobli,Village,Received_Date,Letter_Date,Letter_No,Survey_No,From_Other_Dept,ToSection,ToCaseWorker,Subject,GL_No_Id from tblGeneralLetter_WO where Letter_No = @p1";
                cmd = new SqlCommand(Letter_Number, conn);
                cmd.Parameters.AddWithValue("@p1", txtSearch.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSearch_General.DataSource = dt;
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
                //string Letter_Number = "Select * from tblGovernmentLetter_WO where Letter_No = @p1";
                string Survey_Number = "Select General_Letter,Applicant_Name,Hobli,Village,Received_Date,Letter_Date,Letter_No,Survey_No,From_Other_Dept,ToSection,ToCaseWorker,Subject,GL_No_Id from tblGeneralLetter_WO where Survey_No = @p1";
                cmd = new SqlCommand(Survey_Number, conn);
                cmd.Parameters.AddWithValue("@p1", txtSearch.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSearch_General.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }
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

                s = "Select General_Letter,Applicant_Name,Hobli,Village,Received_Date,Letter_Date,Letter_No,Survey_No,From_Other_Dept,ToSection,ToCaseWorker,Subject,GL_No_Id from tblGeneralLetter_WO R";
                //  s = string.Concat(s);
                string sub = " where (R.Subject LIKE @Search)";
                s = string.Concat(s, sub);
                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSearch_General.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }
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
               if (optGeneralLetter.Checked && txtSearch.Text == "")
                {
                    Search_General_Letter();
                    dataGridViewSearch_General.Visible = true;

                }
               else if (optGLNo.Checked && txtSearch.Text != "")
               {
                   Search_GL_No();
                   lblLetterDetails.Visible = false;
                   dataGridViewSearch_General.Visible = true;
               }
               else if (optSubject.Checked && txtSearch.Text != "")
               {
                   Search_Subject();
                   lblLetterDetails.Visible = false;
                   dataGridViewSearch_General.Visible = true;

               }
               else if (radLetterNo.Checked && txtSearch.Text != "")
               {
                   Search_Letter_Number();
                   lblLetterDetails.Visible = false;
                   dataGridViewSearch_General.Visible = true;
               }
               else if (radSurveyNumber.Checked && txtSearch.Text != "")
               {
                   Search_Survey_Number();
                   lblLetterDetails.Visible = false;
                   dataGridViewSearch_General.Visible = true;
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
               else if (radSurveyNumber.Checked && txtSearch.Text == "")
               {
                   MessageBox.Show("Please Enter Survey Number");
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

        private void dataGridViewSearch_General_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dataGridViewSearch_General.Rows[e.RowIndex].Cells["SlNoGen"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewSearch_General_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewSearch_General.Columns[e.ColumnIndex].Name == "GlNo")
                {

                    dataGridViewSearch_General.Rows[e.RowIndex].ReadOnly = true;

                    // Need Important
                    string GeneralLetter = dataGridViewSearch_General.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string Applicant_Name = dataGridViewSearch_General.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string Hobli = dataGridViewSearch_General.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string Village  = dataGridViewSearch_General.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string ReceivedDate = dataGridViewSearch_General.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string LetterDate = dataGridViewSearch_General.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string LetterNo = dataGridViewSearch_General.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string SurveyNo = dataGridViewSearch_General.Rows[e.RowIndex].Cells[8].Value.ToString();
                    string FromOtherDept = dataGridViewSearch_General.Rows[e.RowIndex].Cells[9].Value.ToString();
                    string ToSection = dataGridViewSearch_General.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string ToCaseWorker = dataGridViewSearch_General.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string Subject = dataGridViewSearch_General.Rows[e.RowIndex].Cells[12].Value.ToString(); 
                    string GL_No_Id = dataGridViewSearch_General.Rows[e.RowIndex].Cells[13].Value.ToString();
                    

                    //string DOLetter = dataGridViewDOLetter.Rows[e.RowIndex].Cells[14].Value.ToString();
                    //string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    //string  RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();
                    //string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[17].Value.ToString();
                    //string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[18].Value.ToString();

                    // Imp
                    string message = "General Letter\t\t:   " + GeneralLetter + "\n GL No\t\t\t: " + GL_No_Id + "\nApplicant Name\t\t :  " + Applicant_Name + "\nHobli\t\t\t:   " + Hobli + "\nVillage\t\t\t:     " + Village + "\nReceived Date\t\t :  " + ReceivedDate + "\nLetter Date\t\t: " + LetterDate + "\nLetter Number\t\t :  " + LetterNo + "\nSurvey Number\t\t: " + SurveyNo + "\nFrom Other Department\t: " + FromOtherDept + "\nTo Section\t\t:  " + ToSection + "\nTo Case Worker\t\t:     " + ToCaseWorker + "\n Subject \t : " + Subject;
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

        private void optGeneralLetter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optGLNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radSurveyNumber_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
