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
using EtapalReq;



namespace EtapalReq
{
    public partial class GovtLetters_WO : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
      //  SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
       
       // SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReqWO; integrated Security=true;");
      //  SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
      //  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlCommand cmd;

        public GovtLetters_WO()
        {
            InitializeComponent();
        }

        private void GovtLetters_WO_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);

                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                // yourformName.YourLabel.Font = new Font("Arial", 24, FontStyle.Bold);
                //   txtApplicantName.Font = new Font("Microsoft Sans Serif", 50,FontStyle.Regular);

                // Check DO

                radDOLetter.Checked = true;


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
                //return FinYear.Trim();
                // Hide Other dept

                txtDeptOthers.Visible = false;
                lblOtherDept.Visible = false;

                // Label for Financial Year
                //DateTime date = new DateTime(DateTime.Today.Year,3,1);
                //lblFinYearValue.Text = date.ToShortDateString();

                //Tooltips

                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnSave, "Save");
                toolTip1.SetToolTip(this.btnBack, "Back");

                // To Autoincrement GL No

                int m = 0;
                string Number1 = "Select count(Gl_No_Id) from dbo.tblGovernmentLetter_WO";
                cmd = new SqlCommand(Number1, conn);
                conn.Open();
                m = (int)cmd.ExecuteScalar();
                double o = m + 100;
                txtGLNo.Text = Convert.ToString(o);
                conn.Close();

                // Add Section Dropdown
                SqlCommand cmd1 = new SqlCommand("select section from tblSectionManagement", conn);
                conn.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr[0].ToString();
                    cbToSection.Items.Add(name);
                }
                conn.Close();

                //add Case Worker Dropdown

                SqlCommand cmd2 = new SqlCommand("select CaseWorker from tblUserMgnt", conn);
                conn.Open();
                SqlDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read())
                {
                    string name = dr1[0].ToString();
                    cbToCaseWorker.Items.Add(name);
                }
                conn.Close();

                // Add Department Dropdown
                SqlCommand cmd3 = new SqlCommand("select Department_Name from tblDepartment", conn);
                conn.Open();
                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    string name = dr3[0].ToString();
                    cbDept.Items.Add(name);
                }
                conn.Close();

                //Add Subsection

                //SqlCommand cmd3 = new SqlCommand("select Subsection from tblSectionManagement", conn);
                //conn.Open();
                //SqlDataReader dr2 = cmd3.ExecuteReader();
                //while (dr2.Read())
                //{
                //    string name = dr2[0].ToString();
                //  //  cbToSubSection.Items.Add(name);
                //}
                //conn.Close();
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (radDOLetter.Checked == false && radCourtCaseLetter.Checked == false && radRightToInformationLetter.Checked == false && radGovtLetter.Checked == false && radLokayuktha.Checked == false)
                {
                    MessageBox.Show("Please Select Letter Category ");
                }

             // Validation for DO Letter
                 else if (radDOLetter.Checked == true && txtLetterNumber.Text == "")
                {
                    MessageBox.Show("Please enter value for Letter Number");
                    txtLetterNumber.Focus();
                }
                 else if (radDOLetter.Checked == true && (dateTimePickerLetterDate.MaxDate < dateTimePickerLetterDate.Value.Date))
                 {
                     MessageBox.Show("Please enter Proper Letter Date");
                 }
                 else if (radDOLetter.Checked == true && (dateTimePickerReceivedDate.MaxDate < dateTimePickerReceivedDate.Value.Date))
                 {
                     MessageBox.Show("Please enter Proper Received Date");
                 }
                 else if (radDOLetter.Checked == true && (cbDept.SelectedIndex == -1 && txtDeptOthers.Text == ""))
                 {
                     MessageBox.Show("Please enter Department or Other Department name");
                     cbDept.Text = "";
                     cbDept.Focus();
                 }
                 //else if (radDOLetter.Checked == true && txtOffice.Text == "")
                 //{
                 //    MessageBox.Show("Please select value for From Office");
                 //    txtOffice.Focus();
                 //}
                 else if (radDOLetter.Checked == true && cbToSection.SelectedIndex == -1)
                 {
                     MessageBox.Show("Please Select value for To Section");
                     cbToSection.Text = "";
                     cbToSection.Focus();
                 }
                 else if (radDOLetter.Checked == true && cbToCaseWorker.SelectedIndex == -1)
                 {
                     MessageBox.Show("Please Select value for To CaseWorker");
                     cbToCaseWorker.Text = "";
                     cbToCaseWorker.Focus();
                 }
                else if (radDOLetter.Checked == true && txtSubject.Text == "")
                {
                    MessageBox.Show("Please enter value for Subject");
                    txtSubject.Focus();
                }
                
               
                    // Validation for Court Case  Letter
                 else if (radCourtCaseLetter.Checked == true && txtLetterNumber.Text == "")
                 {
                     MessageBox.Show("Please enter value for Letter Number");
                     txtLetterNumber.Focus();
                 }
                 else if (radCourtCaseLetter.Checked == true && (dateTimePickerLetterDate.MaxDate < dateTimePickerLetterDate.Value.Date))
                 {
                     MessageBox.Show("Please enter Proper Letter Date");
                 }
                 else if (radCourtCaseLetter.Checked == true && (dateTimePickerReceivedDate.MaxDate < dateTimePickerReceivedDate.Value.Date))
                 {
                     MessageBox.Show("Please enter Proper Received Date");
                 }
                else if (radCourtCaseLetter.Checked == true && (cbDept.SelectedIndex == -1 && txtDeptOthers.Text == ""))
                 {
                     MessageBox.Show("Please enter Department or Other Department name");
                     cbDept.Focus();
                     cbDept.Text = "";
                 }
                 //else if (radCourtCaseLetter.Checked == true && txtOffice.Text == "")
                 //{
                 //    MessageBox.Show("Please select value for From Office");
                 //    txtOffice.Focus();
                 //}
                 else if (radCourtCaseLetter.Checked == true && cbToSection.SelectedIndex == -1)
                 {
                     MessageBox.Show("Please Select value for To Section");
                     cbToSection.Text = "";
                     cbToSection.Focus();
                 }
                 else if (radCourtCaseLetter.Checked == true && cbToCaseWorker.SelectedIndex == -1)
                 {
                     MessageBox.Show("Please Select value for To CaseWorker");
                     cbToCaseWorker.Text = "";
                     cbToCaseWorker.Focus();
                 }
                 else if (radCourtCaseLetter.Checked == true && txtSubject.Text == "")
                 {
                     MessageBox.Show("Please enter value for Subject");
                     txtSubject.Focus();
                 }
                

                     // Validation for Right To info  Letter
                 else if (radRightToInformationLetter.Checked == true && txtLetterNumber.Text == "")
                 {
                     MessageBox.Show("Please enter value for Letter Number");
                     txtLetterNumber.Focus();
                 }
                 else if (radRightToInformationLetter.Checked == true && (dateTimePickerLetterDate.MaxDate < dateTimePickerLetterDate.Value.Date))
                 {
                     MessageBox.Show("Please enter Proper Letter Date");
                 }
                 else if (radRightToInformationLetter.Checked == true && (dateTimePickerReceivedDate.MaxDate < dateTimePickerReceivedDate.Value.Date))
                 {
                     MessageBox.Show("Please enter Proper Received Date");
                 }
                else if (radRightToInformationLetter.Checked == true && (cbDept.SelectedIndex == -1 && txtDeptOthers.Text == ""))
                 {
                     MessageBox.Show("Please enter Department or Other Department name");
                     cbDept.Focus();
                     cbDept.Text = "";
                 }
                 //else if (radRightToInformationLetter.Checked == true && txtOffice.Text == "")
                 //{
                 //    MessageBox.Show("Please select value for From Office");
                 //    txtOffice.Focus();
                 //}
                 else if (radRightToInformationLetter.Checked == true && cbToSection.SelectedIndex == -1)
                 {
                     MessageBox.Show("Please Select value for To Section");
                     cbToSection.Text = "";
                     cbToSection.Focus();
                 }
                 else if (radRightToInformationLetter.Checked == true && cbToCaseWorker.SelectedIndex == -1)
                 {
                     MessageBox.Show("Please Select value for To CaseWorker");
                     cbToCaseWorker.Text = "";
                     cbToCaseWorker.Focus();
                 }
                 else if (radRightToInformationLetter.Checked == true && txtSubject.Text == "")
                 {
                     MessageBox.Show("Please enter value for Subject");
                     txtSubject.Focus();
                 }

                    // Validation for Govt Letter
                 else if (radGovtLetter.Checked == true && txtLetterNumber.Text == "")
                 {
                     MessageBox.Show("Please enter value for Letter Number");
                     txtLetterNumber.Focus();
                 }
                 else if (radGovtLetter.Checked == true && (dateTimePickerLetterDate.MaxDate < dateTimePickerLetterDate.Value.Date))
                 {
                     MessageBox.Show("Please enter Proper Letter Date");
                 }
                 else if (radGovtLetter.Checked == true && (dateTimePickerReceivedDate.MaxDate < dateTimePickerReceivedDate.Value.Date))
                 {
                     MessageBox.Show("Please enter Proper Received Date");
                 }
                else if (radGovtLetter.Checked == true && (cbDept.SelectedIndex == -1 && txtDeptOthers.Text == ""))
                 {
                     MessageBox.Show("Please enter Department or Other Department name");
                     cbDept.Focus();
                     cbDept.Text = "";
                 }
                 //else if (radGovtLetter.Checked == true && txtOffice.Text == "")
                 //{
                 //    MessageBox.Show("Please select value for From Office");
                 //    txtOffice.Focus();
                 //}
                 else if (radGovtLetter.Checked == true && cbToSection.SelectedIndex == -1)
                 {
                     MessageBox.Show("Please Select value for To Section");
                     cbToSection.Text = "";
                     cbToSection.Focus();
                 }
                 else if (radGovtLetter.Checked == true && cbToCaseWorker.SelectedIndex == -1)
                 {
                     MessageBox.Show("Please Select value for To CaseWorker");
                     cbToCaseWorker.Text = "";
                     cbToCaseWorker.Focus();
                 }
                 else if (radGovtLetter.Checked == true && txtSubject.Text == "")
                 {
                     MessageBox.Show("Please enter value for Subject");
                     txtSubject.Focus();
                 }

                // Validation for Lokayukta/ABS Letter

                else if (radLokayuktha.Checked == true && txtLetterNumber.Text == "")
                {
                    MessageBox.Show("Please enter value for Letter Number");
                    txtLetterNumber.Focus();
                }
                else if (radLokayuktha.Checked == true && (dateTimePickerLetterDate.MaxDate < dateTimePickerLetterDate.Value.Date))
                {
                    MessageBox.Show("Please enter Proper Letter Date");
                }
                else if (radLokayuktha.Checked == true && (dateTimePickerReceivedDate.MaxDate < dateTimePickerReceivedDate.Value.Date))
                {
                    MessageBox.Show("Please enter Proper Received Date");
                }
                else if (radLokayuktha.Checked == true && (cbDept.SelectedIndex == -1 && txtDeptOthers.Text == ""))
                {
                    MessageBox.Show("Please enter Department or Other Department name");
                    cbDept.Focus();
                    cbDept.Text = "";
                }
                //else if (radLokayuktha.Checked == true && txtOffice.Text == "")
                //{
                //    MessageBox.Show("Please select value for From Office");
                //    txtOffice.Focus();
                //}
                else if (radLokayuktha.Checked == true && cbToSection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To Section");
                    cbToSection.Text = "";
                    cbToSection.Focus();
                }
                else if (radLokayuktha.Checked == true && cbToCaseWorker.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select value for To CaseWorker");
                    cbToCaseWorker.Text = "";
                    cbToCaseWorker.Focus();
                }
                else if (radLokayuktha.Checked == true && txtSubject.Text == "")
                {
                    MessageBox.Show("Please enter value for Subject");
                    txtSubject.Focus();
                }




                // To save 
                else if (radDOLetter.Checked && txtGLNo.Text != "" && txtLetterNumber.Text != "" && (cbDept.SelectedIndex != -1 || txtDeptOthers.Text != "") && txtOffice.Text != "" && cbToSection.SelectedIndex != -1 && cbToCaseWorker.SelectedIndex != -1 && txtSubject.Text != "")
                {
                    Save_DO_Letter();
                }
                else if (radCourtCaseLetter.Checked && txtGLNo.Text != "" && txtLetterNumber.Text != "" && (cbDept.SelectedIndex != -1 || txtDeptOthers.Text != "") && txtOffice.Text != "" && cbToSection.SelectedIndex != -1 && cbToCaseWorker.SelectedIndex != -1 && txtSubject.Text != "")
                {
                    Save_Court_Case_Letter();
                }
                else if (radRightToInformationLetter.Checked && txtGLNo.Text != "" && txtLetterNumber.Text != "" && (cbDept.SelectedIndex != -1 || txtDeptOthers.Text != "") && txtOffice.Text != "" && cbToSection.SelectedIndex != -1 && cbToCaseWorker.SelectedIndex != -1 && txtSubject.Text != "")
                {
                    Save_Right_To_Info_Letter();
                }
                else if (radGovtLetter.Checked && txtGLNo.Text != "" && txtLetterNumber.Text != "" && (cbDept.SelectedIndex != -1 || txtDeptOthers.Text != "") && txtOffice.Text != "" && cbToSection.SelectedIndex != -1 && cbToCaseWorker.SelectedIndex != -1 && txtSubject.Text != "")
                {
                    Save_Government_Letter();
                }
                else if (radLokayuktha.Checked && txtGLNo.Text != "" && txtLetterNumber.Text != "" && (cbDept.SelectedIndex != -1 || txtDeptOthers.Text != "") && txtOffice.Text != "" && cbToSection.SelectedIndex != -1 && cbToCaseWorker.SelectedIndex != -1 && txtSubject.Text != "")
                {
                     Save_Lokayukta_ABS_Letter();
                 }
               CleartextBoxes2();
            }
            catch (Exception)
            {

            }
        }


        // Save DO Letter Function

        private void Save_DO_Letter()
        {
            try
            {

                //cmd = new SqlCommand("Insert into tblUserMgnt(CaseWorker) values(N'" + txtSection.Text + "')", conn);
                string DO_str = "DOLetter";
                // string Inward_No = txtInwardNo.Text;
                string Letter_No = txtLetterNumber.Text;
                string Received_Date = dateTimePickerReceivedDate.Value.ToShortDateString();
                string Letter_Date = dateTimePickerLetterDate.Value.ToShortDateString();
                // (N'"+ txtSection.Text + "')
                //string FromDept = "N'"+ cbFromDept.Text +"'";
                //string Other_Dept = "N'"+  txtDeptOthers.Text +"'";
                //string FromOffice =  "N'" + cbFromOffice.Text +"'";
                //string Subject =  "N'" + txtSubject.Text +"'" ;
                //string ToSection = "N'" + cbToSection.Text +"'";
                //string ToSubSection = "N'" + cbToSubSection.Text +"'";
                //string ToCaseWorker = "N'" + cbToCaseWorker.Text +"'";

                //string InsertData = "Insert into tblReceiverNew(DO_Letter,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker)" +
                //                 "values(@DO_Letter,@Inward_No,@Letter_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToSubSection,@ToCaseWorker)";

                string InsertData = "Insert into tblGovernmentLetter_WO(DO_Letter,Letter_No,Received_Date,Letter_Date,FromDept,From_Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Hobli,Village)" +
                                "values(@DO_Letter,@Letter_No,@Received_Date,@Letter_Date,N'" + cbDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + txtOffice.Text + "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "',N'" + txtHobli.Text + "',N'" + txtVillage.Text + "')";

                cmd = new SqlCommand(InsertData, conn);



                //cmd.Parameters.AddWithValue("@Gl_NO", txtGLNo.Text);
                cmd.Parameters.AddWithValue("@DO_Letter", DO_str);
                //cmd.Parameters.AddWithValue("@General_Letter", radGeneralLetter.Text);
                //cmd.Parameters.AddWithValue("@Court_Case_Letter", radCourtCaseLetter.Text);
                // cmd.Parameters.AddWithValue("@Right_To_Info_Letter", radRightToInformationLetter.Text);
                // cmd.Parameters.AddWithValue("@Inward_No", Inward_No);
                cmd.Parameters.AddWithValue("@Letter_No", Letter_No);
                cmd.Parameters.AddWithValue("@Received_Date", Received_Date);
                cmd.Parameters.AddWithValue("@Letter_Date", Letter_Date);
                //cmd.Parameters.AddWithValue("@FromDept", FromDept);
                //cmd.Parameters.AddWithValue("@Other_Dept",Other_Dept);
                //cmd.Parameters.AddWithValue("@FromOffice", FromOffice);
                //cmd.Parameters.AddWithValue("@Subject", Subject);
                //cmd.Parameters.AddWithValue("@ToSection", ToSection);
                //cmd.Parameters.AddWithValue("@ToSubSection", cbToSubSection.Text);
                //cmd.Parameters.AddWithValue("@ToCaseWorker", ToCaseWorker);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Details saved Successfully , GL No : " + txtGLNo.Text);
                }
                conn.Close();
              
                
             CleartextBoxes2();



                //string DO_str = "DOLetter";
                //string InsertData = "if @Other_Dept is null " +
                //                    " Insert into tblReceiverNew(DO_Letter,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker)" +
                //                 "values(@DO_Letter,@Inward_No,@Letter_No,@Received_Date,@Letter_Date,@FromDept, '-' ,@FromOffice,@Subject,@ToSection,@ToSubSection,@ToCaseWorker)" +
                //                   "else " +
                //                    "Insert into tblReceiverNew(DO_Letter,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker)" +
                //                 "values(@DO_Letter,@Inward_No,@Letter_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToSubSection,@ToCaseWorker)";

                //cmd = new SqlCommand(InsertData, conn);
                ////cmd.Parameters.AddWithValue("@Gl_NO", txtGLNo.Text);
                //cmd.Parameters.AddWithValue("@DO_Letter", DO_str);
                ////cmd.Parameters.AddWithValue("@General_Letter", radGeneralLetter.Text);
                ////cmd.Parameters.AddWithValue("@Court_Case_Letter", radCourtCaseLetter.Text);
                //// cmd.Parameters.AddWithValue("@Right_To_Info_Letter", radRightToInformationLetter.Text);
                //cmd.Parameters.AddWithValue("@Inward_No", txtInwardNo.Text);
                //cmd.Parameters.AddWithValue("@Letter_No", txtLetterNumber.Text);
                //cmd.Parameters.AddWithValue("@Received_Date", dateTimePickerReceivedDate.Value.ToShortDateString());
                //cmd.Parameters.AddWithValue("@Letter_Date", dateTimePickerLetterDate.Value.ToShortDateString());
                //cmd.Parameters.AddWithValue("@FromDept", cbFromDept.Text);
                //cmd.Parameters.AddWithValue("@Other_Dept", txtDeptOthers.Text);
                //cmd.Parameters.AddWithValue("@FromOffice", cbFromOffice.Text);
                //cmd.Parameters.AddWithValue("@Subject", txtSubject.Text);
                //cmd.Parameters.AddWithValue("@ToSection", cbToSection.Text);
                //cmd.Parameters.AddWithValue("@ToSubSection", cbToSubSection.Text);
                //cmd.Parameters.AddWithValue("@ToCaseWorker", cbToCaseWorker.Text);
                //conn.Open();
                //int i = cmd.ExecuteNonQuery();
                //if (i > 0)
                //{
                //    MessageBox.Show("Details saved Successfully , GL No : " + txtGLNo.Text);
                //}
                //conn.Close();
                //CleartextBoxes2();

            }
            catch (Exception)
            {

            }
        }


        // Save Court Case Letter Function

        private void Save_Court_Case_Letter()
        {
            try
            {
                string Court_Case_Letter_str = "CourtCaseLetter";
                //string Inward_No = txtInwardNo.Text;
                string Letter_No = txtLetterNumber.Text;
                string Received_Date = dateTimePickerReceivedDate.Value.ToShortDateString();
                string Letter_Date = dateTimePickerLetterDate.Value.ToShortDateString();
                //string FromDept = "N'" + cbFromDept.Text + "'";
                //string Other_Dept = "N'" + txtDeptOthers.Text + "'";
                //string FromOffice = "N'" + cbFromOffice.Text + "'";
                //string Subject = "N'" + txtSubject.Text + "'";
                //string ToSection = "N'" + cbToSection.Text + "'";
                //string ToSubSection = "N'" + cbToSubSection.Text + "'";
                //string ToCaseWorker = "N'" + cbToCaseWorker.Text + "'";

               
                //string InsertData = "Insert into tblGovernmentLetter_WO(Court_Case_Letter,Letter_No,Received_Date,Letter_Date,FromDept,From_Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Hobli,Village)" +
                //                "values(@Court_Case_Letter,@Letter_No,@Received_Date,@Letter_Date,N'" + cbDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + txtOffice.Text + "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "',N'" + txtHobli.Text + "',N'" + txtVillage.Text + "')";

                string InsertData = "Insert into tblGovernmentLetter_WO(Court_Case_Letter,Letter_No,Received_Date,Letter_Date,FromDept,From_Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Hobli,Village)" +
                               "values(@Court_Case_Letter,@Letter_No,@Received_Date,@Letter_Date,N'" + cbDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + txtOffice.Text + "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "',N'" + txtHobli.Text + "',N'" + txtVillage.Text + "')";


                cmd = new SqlCommand(InsertData, conn);
                // cmd.Parameters.AddWithValue("@Gl_NO", txtGLNo.Text);
                //cmd.Parameters.AddWithValue("@DO_Letter", radDO.Text);
                //cmd.Parameters.AddWithValue("@General_Letter", radGeneralLetter.Text);
                cmd.Parameters.AddWithValue("@Court_Case_Letter", Court_Case_Letter_str);
                // cmd.Parameters.AddWithValue("@Right_To_Info_Letter", radRightToInformationLetter.Text);
                // cmd.Parameters.AddWithValue("@Inward_No", Inward_No);
                cmd.Parameters.AddWithValue("@Letter_No", Letter_No);
                cmd.Parameters.AddWithValue("@Received_Date", Received_Date);
                cmd.Parameters.AddWithValue("@Letter_Date", Letter_Date);
                //cmd.Parameters.AddWithValue("@FromDept", FromDept);
                //cmd.Parameters.AddWithValue("@Other_Dept", Other_Dept);
                //cmd.Parameters.AddWithValue("@FromOffice", FromOffice);
                //cmd.Parameters.AddWithValue("@Subject", Subject);
                //cmd.Parameters.AddWithValue("@ToSection", ToSection);
                //cmd.Parameters.AddWithValue("@ToSubSection", cbToSubSection.Text);
                //cmd.Parameters.AddWithValue("@ToCaseWorker", ToCaseWorker);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Details saved Successfully , GL No : " + txtGLNo.Text);
                }
                conn.Close();
               CleartextBoxes2();
            }

            catch (Exception)
            {

            }
        }

        // Save Court Right_To_Info_Letter Function

        private void Save_Right_To_Info_Letter()
        {
            try
            {
                string Right_To_Info_Letter_str = "RightToInfoLetter";
                // string Inward_No = txtInwardNo.Text;
                string Letter_No = txtLetterNumber.Text;
                string Received_Date = dateTimePickerReceivedDate.Value.ToShortDateString();
                string Letter_Date = dateTimePickerLetterDate.Value.ToShortDateString();
                //string FromDept = "N'" + cbFromDept.Text + "'";
                //string Other_Dept = "N'" + txtDeptOthers.Text + "'";
                //string FromOffice = "N'" + cbFromOffice.Text + "'";
                //string Subject = "N'" + txtSubject.Text + "'";
                //string ToSection = "N'" + cbToSection.Text + "'";
                //string ToSubSection = "N'" + cbToSubSection.Text + "'";
                //string ToCaseWorker = "N'" + cbToCaseWorker.Text + "'";

                //string InsertData = "Insert into tblReceiverNew(Right_To_Info_Letter,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker)" +
                //                 "values(@Right_To_Info_Letter,@Inward_No,@Letter_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToSubSection,@ToCaseWorker)";

                string InsertData = "Insert into tblGovernmentLetter_WO(Right_To_Info_Letter,Letter_No,Received_Date,Letter_Date,FromDept,From_Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Hobli,Village)" +
                                "values(@Right_To_Info_Letter,@Letter_No,@Received_Date,@Letter_Date,N'" + cbDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + txtOffice.Text + "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "',N'" + txtHobli.Text + "',N'" + txtVillage.Text + "')";

                cmd = new SqlCommand(InsertData, conn);
                //  cmd.Parameters.AddWithValue("@Gl_NO", txtGLNo.Text);
                //cmd.Parameters.AddWithValue("@DO_Letter", radDO.Text);
                //cmd.Parameters.AddWithValue("@General_Letter", radGeneralLetter.Text);
                // cmd.Parameters.AddWithValue("@Court_Case_Letter", Right_To_Info_Letter_str);
                cmd.Parameters.AddWithValue("@Right_To_Info_Letter", Right_To_Info_Letter_str);
                // cmd.Parameters.AddWithValue("@Inward_No", Inward_No);
                cmd.Parameters.AddWithValue("@Letter_No", Letter_No);
                cmd.Parameters.AddWithValue("@Received_Date", Received_Date);
                cmd.Parameters.AddWithValue("@Letter_Date", Letter_Date);
                //cmd.Parameters.AddWithValue("@FromDept", FromDept);
                //cmd.Parameters.AddWithValue("@Other_Dept", Other_Dept);
                //cmd.Parameters.AddWithValue("@FromOffice", FromOffice);
                //cmd.Parameters.AddWithValue("@Subject", Subject);
                //cmd.Parameters.AddWithValue("@ToSection", ToSection);
                //cmd.Parameters.AddWithValue("@ToSubSection", cbToSubSection.Text);
                //cmd.Parameters.AddWithValue("@ToCaseWorker", ToCaseWorker);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Details saved Successfully , GL No : " + txtGLNo.Text);
                }
                conn.Close();
             CleartextBoxes2();
            }
            catch (Exception)
            {

            }
        }

        // Save Government Letter Function

        private void Save_Government_Letter()
        {
            try
            {
                string Government_Letter_str = "GovernmentLetter";
                // string Inward_No = txtInwardNo.Text;
                string Letter_No = txtLetterNumber.Text;
                string Received_Date = dateTimePickerReceivedDate.Value.ToShortDateString();
                string Letter_Date = dateTimePickerLetterDate.Value.ToShortDateString();
                //string FromDept = "N'" + cbFromDept.Text + "'";
                //string Other_Dept = "N'" + txtDeptOthers.Text + "'";
                //string FromOffice = "N'" + cbFromOffice.Text + "'";
                //string Subject = "N'" + txtSubject.Text + "'";
                //string ToSection = "N'" + cbToSection.Text + "'";
                //string ToSubSection = "N'" + cbToSubSection.Text + "'";
                //string ToCaseWorker = "N'" + cbToCaseWorker.Text + "'";

                //string InsertData = "Insert into tblReceiverNew(Government_Letter,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,ToCaseWorker)" +
                //                 "values(@Government_Letter,@Inward_No,@Letter_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToSubSection,@ToCaseWorker)";

                string InsertData = "Insert into tblGovernmentLetter_WO(Government_Letter,Letter_No,Received_Date,Letter_Date,FromDept,From_Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Hobli,Village)" +
                                "values(@Government_Letter,@Letter_No,@Received_Date,@Letter_Date,N'" + cbDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + txtOffice.Text + "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "',N'" + txtHobli.Text + "',N'" + txtVillage.Text + "')";


                cmd = new SqlCommand(InsertData, conn);
                //cmd.Parameters.AddWithValue("@Gl_NO", txtGLNo.Text);
                // cmd.Parameters.AddWithValue("@DO_Letter", radDO.Text);
                cmd.Parameters.AddWithValue("@Government_Letter", Government_Letter_str);
                // cmd.Parameters.AddWithValue("@Court_Case_Letter", radCourtCaseLetter.Text);
                // cmd.Parameters.AddWithValue("@Right_To_Info_Letter", radRightToInformationLetter.Text);
                //cmd.Parameters.AddWithValue("@Inward_No", Inward_No);
                cmd.Parameters.AddWithValue("@Letter_No", Letter_No);
                cmd.Parameters.AddWithValue("@Received_Date", Received_Date);
                cmd.Parameters.AddWithValue("@Letter_Date", Letter_Date);
                //cmd.Parameters.AddWithValue("@FromDept", FromDept);
                //cmd.Parameters.AddWithValue("@Other_Dept", Other_Dept);
                //cmd.Parameters.AddWithValue("@FromOffice", FromOffice);
                //cmd.Parameters.AddWithValue("@Subject", Subject);
                //cmd.Parameters.AddWithValue("@ToSection", ToSection);
                //cmd.Parameters.AddWithValue("@ToSubSection", cbToSubSection.Text);
                //cmd.Parameters.AddWithValue("@ToCaseWorker", ToCaseWorker);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Details saved Successfully , GL No : " + txtGLNo.Text);
                }
                conn.Close();
               CleartextBoxes2();
            }
            catch (Exception)
            {

            }
        }


        // Save Lokayukta/ABS Letter Function

        private void Save_Lokayukta_ABS_Letter()
        {
            try
            {
                string Lokayukta_ABS_Letter_str = "LokayuktaLetter";
                // string Inward_No = txtInwardNo.Text;
                string Letter_No = txtLetterNumber.Text;
                string Received_Date = dateTimePickerReceivedDate.Value.ToShortDateString();
                string Letter_Date = dateTimePickerLetterDate.Value.ToShortDateString();
                //string FromDept = "N'" + cbFromDept.Text + "'";
                //string Other_Dept = "N'" + txtDeptOthers.Text + "'";
                //string FromOffice = "N'" + cbFromOffice.Text + "'";
                //string Subject = "N'" + txtSubject.Text + "'";
                //string ToSection = "N'" + cbToSection.Text + "'";
                //string ToSubSection = "N'" + cbToSubSection.Text + "'";
                //string ToCaseWorker = "N'" + cbToCaseWorker.Text + "'";

                //string InsertData = "Insert into tblReceiverNew(Government_Letter,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,ToCaseWorker)" +
                //                 "values(@Government_Letter,@Inward_No,@Letter_No,@Received_Date,@Letter_Date,@FromDept,@Other_Dept,@FromOffice,@Subject,@ToSection,@ToSubSection,@ToCaseWorker)";

                string InsertData = "Insert into tblGovernmentLetter_WO(Lokayukta_ABS_Letter,Letter_No,Received_Date,Letter_Date,FromDept,From_Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Hobli,Village)" +
                                "values(@Lokayukta_ABS_Letter,@Letter_No,@Received_Date,@Letter_Date,N'" + cbDept.Text + "',N'" + txtDeptOthers.Text + "',N'" + txtOffice.Text + "',N'" + txtSubject.Text + "',N'" + cbToSection.Text + "',N'" + cbToCaseWorker.Text + "',N'" + txtHobli.Text + "',N'" + txtVillage.Text + "')";


                cmd = new SqlCommand(InsertData, conn);
                //cmd.Parameters.AddWithValue("@Gl_NO", txtGLNo.Text);
                // cmd.Parameters.AddWithValue("@DO_Letter", radDO.Text);
                cmd.Parameters.AddWithValue("@Lokayukta_ABS_Letter", Lokayukta_ABS_Letter_str);
                // cmd.Parameters.AddWithValue("@Court_Case_Letter", radCourtCaseLetter.Text);
                // cmd.Parameters.AddWithValue("@Right_To_Info_Letter", radRightToInformationLetter.Text);
                //cmd.Parameters.AddWithValue("@Inward_No", Inward_No);
                cmd.Parameters.AddWithValue("@Letter_No", Letter_No);
                cmd.Parameters.AddWithValue("@Received_Date", Received_Date);
                cmd.Parameters.AddWithValue("@Letter_Date", Letter_Date);
                //cmd.Parameters.AddWithValue("@FromDept", FromDept);
                //cmd.Parameters.AddWithValue("@Other_Dept", Other_Dept);
                //cmd.Parameters.AddWithValue("@FromOffice", FromOffice);
                //cmd.Parameters.AddWithValue("@Subject", Subject);
                //cmd.Parameters.AddWithValue("@ToSection", ToSection);
                //cmd.Parameters.AddWithValue("@ToSubSection", cbToSubSection.Text);
                //cmd.Parameters.AddWithValue("@ToCaseWorker", ToCaseWorker);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Details saved Successfully , GL No : " + txtGLNo.Text);
                }
                conn.Close();
           //     CleartextBoxes2();
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

        //private void lblHobli_Click(object sender, EventArgs e)
        //{

        //}

        // To Clear textboxes

        public void CleartextBoxes2()
        {
            try
            {
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is TextBox)
                    {
                        this.Controls[i].Text = "";
                    }
                }


                cbToSection.SelectedIndex = -1;
                cbToCaseWorker.SelectedIndex = -1;
                cbDept.SelectedIndex = -1;
                chkOthers.Checked = false;

                // To Autoincrement GL No

                int k = 0;
                string Number1 = "Select count(GL_No_Id) from tblGovernmentLetter_WO";
                cmd = new SqlCommand(Number1, conn);
                conn.Open();
                k = (int)cmd.ExecuteScalar();
                double o = k + 100;
                txtGLNo.Text = Convert.ToString(o);
                conn.Close();
            }
            catch (Exception)
            {

            }
        }

        private void chkOthers_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkOthers.Checked == true)
                {
                    lblOtherDept.Visible = true;
                    txtDeptOthers.Visible = true;
                   // cbDept.Text = "";
                    cbDept.SelectedIndex = -1;
                }
                else
                {
                    lblOtherDept.Visible = false;
                    txtDeptOthers.Visible = false;
                    txtDeptOthers.Text = "";
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtSubject_Click(object sender, EventArgs e)
        {
            txtSubject.Text = "ಪತ್ರದ ಸಂಖ್ಯೆ : " + txtLetterNumber.Text + Environment.NewLine + "ಇಲಾಖೆ : " + cbDept.SelectedItem + Environment.NewLine + "ಹೋಬಳಿ : " + txtHobli.Text + Environment.NewLine + "ಗ್ರಾಮ : " + txtVillage.Text + Environment.NewLine + "ಸರ್ವೇ ಸಂಖ್ಯೆ :";
        }

        //private void txtVillage_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
