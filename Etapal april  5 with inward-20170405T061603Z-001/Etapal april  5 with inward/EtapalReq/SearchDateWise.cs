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
    public partial class SearchDateWise : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        // SqlCommand cmd;
        public SearchDateWise()
        {
            InitializeComponent();
        }

        private void SearchDateWise_Load(object sender, EventArgs e)
        {
            try
            {
                // UneditableGridColumn();

                lblLetterHeading.Visible = false;
                optDOLetter.Checked = true;
                dataGridViewDOLetter.Visible = true;

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewDOLetter.Visible = true;
                lblLetterHeading.Visible = true;
                string s = "";
                string SearchDetails = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToSubsection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,Applicant_Name,Survey_No";

                if (optDOLetter.Checked == true)
                {
                    lblLetterHeading.Text = "The Following are the DO Letters";
                    string DO = " from tblGovernmentLetter_IN where DO_Letter = 'DOLetter' and Entry_Date between @p1 and @p2 Order by GL_No_Id";
                    s = string.Concat(SearchDetails, DO);

                }

                else if (optRightToInformationLetter.Checked == true)
                {
                    lblLetterHeading.Text = "The Following are the Right Letters";
                    string RightToInformation = " from tblGovernmentLetter_IN where Right_To_Info_Letter = 'RightToInfoLetter' and Entry_Date between @p1 and @p2 Order by GL_No_Id";
                    s = string.Concat(SearchDetails, RightToInformation);

                }

                else if (optLokayuktaLetter.Checked == true)
                {
                    lblLetterHeading.Text = "The Following are the Lokayukta Letters";
                    string LokayuktaLetter = " from tblGovernmentLetter_IN where Lokayukta_ABS_Letter = 'LokayuktaLetter' and Entry_Date between @p1 and @p2 Order by GL_No_Id";
                    s = string.Concat(SearchDetails, LokayuktaLetter);

                }

                else if (optGovtLetter.Checked == true)
                {
                    lblLetterHeading.Text = "The following are the Government Letters";
                    string GovernmentLetter = " from tblGovernmentLetter_IN where Government_Letter = 'GovernmentLetter' and Entry_Date between @p1 and @p2 Order by GL_No_Id";
                    s = string.Concat(SearchDetails, GovernmentLetter);

                }

                else if (optGeneral.Checked == true)
                {
                    lblLetterHeading.Text = "The following are the General Letters";
                    string GeneralLetter = " from tblGovernmentLetter_IN where General_Letter = 'GeneralLetter' and Entry_Date between @p1 and @p2 Order by GL_No_Id";
                    s = string.Concat(SearchDetails, GeneralLetter);
                }

                else if (optCourtCaseLetter.Checked == true)
                {
                    lblLetterHeading.Text = "The following are the Court Case Letters";
                    string CourtCaseLetter = " from tblCourtCaseLetter_IN  where Court_Case_Letter = 'CourtCaseLetter' and Entry_Date between @p1 and @p2 Order by GL_No_Id";
                    s = string.Concat(SearchDetails, CourtCaseLetter);
                }

                else if (optAllGovtLetters.Checked == true)
                {
                    lblLetterHeading.Text = "The following are the Details of All Government Letters";
                    string AllGovtLetters = " ,isnull(DO_Letter, '    ------') as DOletter,isnull(Right_To_Info_Letter,'    -----') as RightToInfoLetter,"
                    + " isnull(Government_Letter,'    -----') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -----') as LokayuktaABSLetter"
                    + " from tblGovernmentLetter_IN  where Entry_Date between @p1 and @p2 Order by GL_No_Id";
                    s = string.Concat(SearchDetails, AllGovtLetters);
                }

                else if (optAllLetters.Checked == true)
                {
                    lblLetterHeading.Text = "The Following are the details of  All Letters";
                    s = "Select Gl_No_Id,Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDateC ,Applicant_Name,Subject,ToSection,ToCaseWorker,Signature,FromDept,Entry_Date,Survey_No from tblGovernmentLetter_IN  where Entry_Date between @p1 and @p2  union all"
                                           + " Select Gl_No_Id,Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDateC,Applicant_Name,Subject,ToSection,ToCaseWorker,Signature,FromDept,Entry_Date,Survey_No from tblCourtCaseLetter_IN"
                                           + " where Entry_Date between @p1 and @p2 Order by Entry_Date";

                }

                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
                //dateTimePickerEntryDate.Value.Date
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDOLetter.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's found between the date selected by you!! : "
                        + Environment.NewLine + "" + dateTimePickerFromDate.Value + "" + " and "
                        + "" + dateTimePickerToDate.Value + "" + Environment.NewLine
                        + "Select Different date!");
                    lblLetterHeading.Visible = false;
                }
                dataGridViewDOLetter.ForeColor = Color.Black;
                LoadSerialDO();
            }
            catch (Exception)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var Home = new Home();
                Home.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }

        }

        // Method for Generating Serial Numbers for Do,Right,etc letters
        private void LoadSerialDO()
        {
            try
            {
                int i = 1;
                foreach (DataGridViewRow row in dataGridViewDOLetter.Rows)
                {
                    row.Cells["SlNoDOSearchDateIN"].Value = i;
                    i++;
                }
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewDOLetter_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadSerialDO();
            }
            catch (Exception)
            {

            }
        }

        private void optAllLetters_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void dataGridViewDOLetter_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (dataGridViewDOLetter.Columns[e.ColumnIndex].Name == "GlNoIdDO")
        //        {

        //            dataGridViewDOLetter.Rows[e.RowIndex].ReadOnly = true;

        //            // Need Important
        //            string LetterNo = dataGridViewDOLetter.Rows[e.RowIndex].Cells[1].Value.ToString();
        //            string ReceiveDate = dataGridViewDOLetter.Rows[e.RowIndex].Cells[2].Value.ToString();
        //            string LetterDate = dataGridViewDOLetter.Rows[e.RowIndex].Cells[3].Value.ToString();
        //            string FromDept = dataGridViewDOLetter.Rows[e.RowIndex].Cells[4].Value.ToString();
        //            string FromOffice = dataGridViewDOLetter.Rows[e.RowIndex].Cells[5].Value.ToString();
        //            string ToSection = dataGridViewDOLetter.Rows[e.RowIndex].Cells[6].Value.ToString();
        //            string ToCaseWorker = dataGridViewDOLetter.Rows[e.RowIndex].Cells[7].Value.ToString();
        //            string Subject = dataGridViewDOLetter.Rows[e.RowIndex].Cells[8].Value.ToString();
        //            string Hobli = dataGridViewDOLetter.Rows[e.RowIndex].Cells[9].Value.ToString();
        //            string Village = dataGridViewDOLetter.Rows[e.RowIndex].Cells[10].Value.ToString();
        //            string GLNoId = dataGridViewDOLetter.Rows[e.RowIndex].Cells[11].Value.ToString();
        //            //  string Signature = dataGridView_All_letters.Rows[e.RowIndex].Cells[12].Value.ToString();
        //            string InwardNo = dataGridViewDOLetter.Rows[e.RowIndex].Cells[12].Value.ToString();
        //            string ToSubsection = dataGridViewDOLetter.Rows[e.RowIndex].Cells[13].Value.ToString();
        //            string ApplicantName = dataGridViewDOLetter.Rows[e.RowIndex].Cells[14].Value.ToString();

        //            //string DOLetter = dataGridViewDOLetter.Rows[e.RowIndex].Cells[14].Value.ToString();
        //            //string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
        //            //string  RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();
        //            //string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[17].Value.ToString();
        //            //string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[18].Value.ToString();

        //            // Imp
        //            string message = "GL Number\t : " + GLNoId + "\nLetter Number\t : " + LetterNo + "\nInward Number\t : " + InwardNo + "\nReceived Date\t : " + ReceiveDate + "\nLetter Date\t: " + LetterDate + "\nFrom Department\t : " + FromDept + "\nFrom Office\t : " + FromOffice + "\nTo Section\t  :  " + ToSection + "\nTo Subsection\t  : " + ToSubsection + "\nTo Case Worker\t :     " + ToCaseWorker + "\n Hobli\t\t : " + Hobli + "\n Village\t\t : " + Village + "\nSubject\t\t :\n  " + Subject;
        //            MessageBox.Show(message);
        //        }

        //        //catch (IndexOutOfRangeException)
        //        //{
        //        //    MessageBox.Show("Please click on Reference Link to View Details......");
        //        //}
        //        //catch (Exception)
        //        //{
        //        //    MessageBox.Show("Please Enter valid Reference Number.......");
        //        //}
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
    }
}
