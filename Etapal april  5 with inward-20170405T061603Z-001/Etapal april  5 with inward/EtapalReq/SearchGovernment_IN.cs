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
    public partial class SearchGovernment_IN : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        SqlCommand cmd;
        public SearchGovernment_IN()
        {
            InitializeComponent();
        }

        private void SearchGovernment_IN_Load(object sender, EventArgs e)
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


                lblLetterDetails.Visible = false;

                //Default
                optGLNo.Checked = true;

                // UneditableGridColumn();

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

                //Load Fin Year
                LoadFinYear();
            }
            catch (Exception)
            {

            }
        }


        ////Search Function for DO Letter

        //private void Search_DO_Letter()
        //{
        //    try
        //    {

        //        // string Dept = "FromDept" + " ''" + "Other_Dept as Department" ;
        //        //string DO_Letter = "Select DO_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker from tblReceiverNew where DO_Letter = @p1";
        //        //string DO_Letter = "Select Gl_No,Inward_No,Subject from tblReceiverNew where DO_Letter = @p1";
        //        //string DO_Letter_str = "DOLetter";
        //        //need
        //        string DO_Letter = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection,Applicant_Name from tblGovernmentLetter_IN where DO_Letter = @p1  Order by GL_No_Id";

        //        // string DO_Letter = "Select * from tblGovernmentLetter_IN where DO_Letter = @p1";
        //        //string DO_Letter = "Select DO_Letter,Inward_No,Letter_No,Letter_Date,FromDept,isnull(Other_Dept,'-'),FromOffice,Subject,Gl_No,Signature,ToSection,ToSubSection,ToCaseWorker from tblReceiverNew where DO_Letter = @p1";
        //        cmd = new SqlCommand(DO_Letter, conn);
        //        cmd.Parameters.AddWithValue("@p1", "DOLetter");
        //        // cmd.Parameters.AddWithValue("@Dept", Dept);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridViewDOLetter.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found ");
        //            lblLetterDetails.Visible = false;
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the DO Letters";
        //        }
        //        //foreach (DataGridViewRow row in dataGridView1.Rows)
        //        //{
        //        //    DataGridViewLinkCell link = new DataGridViewLinkCell();
        //        //    link.Value = row.Cells[1].Value;
        //        //    row.Cells[1] = link;
        //        //}


        //        // Datagridview  function call

        //        // DatagridProp();
        //    }
        //    catch (Exception)
        //    {

        //    }

        //}

        ////Search Function for DO Letter

        //private void Search_General_Letter()
        //{
        //    try
        //    {

        //        // string Dept = "FromDept" + " ''" + "Other_Dept as Department" ;
        //        //string DO_Letter = "Select DO_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker from tblReceiverNew where DO_Letter = @p1";
        //        //string DO_Letter = "Select Gl_No,Inward_No,Subject from tblReceiverNew where DO_Letter = @p1";
        //        //string DO_Letter_str = "DOLetter";
        //        //need
        //        string General_Letter = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection,Applicant_Name from tblGovernmentLetter_IN where General_Letter = @p1 Order by GL_No_Id";

        //        // string DO_Letter = "Select * from tblGovernmentLetter_IN where DO_Letter = @p1";
        //        //string DO_Letter = "Select DO_Letter,Inward_No,Letter_No,Letter_Date,FromDept,isnull(Other_Dept,'-'),FromOffice,Subject,Gl_No,Signature,ToSection,ToSubSection,ToCaseWorker from tblReceiverNew where DO_Letter = @p1";
        //        cmd = new SqlCommand(General_Letter, conn);
        //        cmd.Parameters.AddWithValue("@p1", "GeneralLetter");
        //        // cmd.Parameters.AddWithValue("@Dept", Dept);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridViewDOLetter.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found ");
        //            lblLetterDetails.Visible = false;
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the General Letters";
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }

        //}


        ////Search Function for Right To Info Letter

        //private void Search_Right_To_Info_Letter()
        //{
        //    try
        //    {
        //        string Right_To_Info_Letter_str = "RightToInfoLetter";
        //        //string Dept = "FromDept" + "''" + "Others_Dept as Department";
        //        //string Right_To_Info_Letter = "Select Right_To_Info_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker  from tblReceiverNew  where Right_To_Info_Letter = @p1";

        //        string Right_To_Info_Letter = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection from tblGovernmentLetter_IN where Right_To_Info_Letter = @p1 Order by GL_No_Id";
        //        cmd = new SqlCommand(Right_To_Info_Letter, conn);
        //        cmd.Parameters.AddWithValue("@p1", Right_To_Info_Letter_str);
        //        // cmd.Parameters.AddWithValue("@Dept", Dept);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridViewDOLetter.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found ");
        //            lblLetterDetails.Visible = false;
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the Right To Information Letters";
        //        }


        //        //foreach (DataGridViewRow row in dataGridView1.Rows)
        //        //{
        //        //    DataGridViewLinkCell link = new DataGridViewLinkCell();
        //        //    link.Value = row.Cells[0].Value;
        //        //    row.Cells[0] = link;
        //        //}


        //        // Datagridview  function call

        //        //DatagridProp();
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        ////Search Function for Govt Letter

        //private void Search_Government_Letter()
        //{
        //    try
        //    {
        //        string Government_Letter_str = "GovernmentLetter";
        //        //string Dept = "FromDept" + "''" + "Others_Dept as Department";
        //        //string Right_To_Info_Letter = "Select Right_To_Info_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker  from tblReceiverNew  where Right_To_Info_Letter = @p1";

        //        string Government_Letter = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection from tblGovernmentLetter_IN where Government_Letter = @p1 Order by GL_No_Id";
        //        cmd = new SqlCommand(Government_Letter, conn);
        //        cmd.Parameters.AddWithValue("@p1", Government_Letter_str);
        //        // cmd.Parameters.AddWithValue("@Dept", Dept);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridViewDOLetter.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found");
        //            lblLetterDetails.Visible = false;
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the Government Letters";
        //        }


        //        //foreach (DataGridViewRow row in dataGridView1.Rows)
        //        //{
        //        //    DataGridViewLinkCell link = new DataGridViewLinkCell();
        //        //    link.Value = row.Cells[0].Value;
        //        //    row.Cells[0] = link;
        //        //}


        //        // Datagridview  function call

        //        //DatagridProp();
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}


        ////Search Function for Lokayukta/ABS Letter

        //private void Search_Lokayukta_ABS_Letter()
        //{
        //    try
        //    {
        //        string Lokayukta_ABS_Letter_str = "LokayuktaLetter";
        //        //string Dept = "FromDept" + "''" + "Others_Dept as Department";
        //        //string Right_To_Info_Letter = "Select Right_To_Info_Letter,Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,@Dept,FromOffice,ToSection,ToCaseWorker  from tblReceiverNew  where Right_To_Info_Letter = @p1";

        //        string Lokayukta_ABS_Letter = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection  from tblGovernmentLetter_IN where Lokayukta_ABS_Letter = @p1 Order by GL_No_Id";
        //        cmd = new SqlCommand(Lokayukta_ABS_Letter, conn);
        //        cmd.Parameters.AddWithValue("@p1", Lokayukta_ABS_Letter_str);
        //        // cmd.Parameters.AddWithValue("@Dept", Dept);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridViewDOLetter.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found ");
        //            lblLetterDetails.Visible = false;
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the Lokayukta/ACB Letters";
        //        }


        //        //foreach (DataGridViewRow row in dataGridView1.Rows)
        //        //{
        //        //    DataGridViewLinkCell link = new DataGridViewLinkCell();
        //        //    link.Value = row.Cells[0].Value;
        //        //    row.Cells[0] = link;
        //        //}


        //        // Datagridview  function call

        //        //DatagridProp();
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}


        ////Search Function for Subject

        //private void Search_Subject()
        //{
        //    try
        //    {
        //        string s = "";
        //        //s = string.Concat

        //        s = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection,isnull(DO_Letter, '    ------') as DOletter,isnull(Right_To_Info_Letter,'    ---------') as RightToInfoLetter, isnull(Government_Letter,'    -------') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -------') as LokayuktaABSLetter   from tblGovernmentLetter_IN R Order by GL_No_Id";
        //        //  s = string.Concat(s);
        //        string sub = " where (R.Subject LIKE @Search)";
        //        s = string.Concat(s, sub);
        //        SqlCommand cmd = new SqlCommand(s, conn);
        //        cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridView_Search_GL_No.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found for Subject : " + "'" + txtSearch.Text + "'");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //// Search Function for Letter Number

        //private void Search_Letter_Number()
        //{
        //    try
        //    {
        //        //string Letter_Number = "Select * from tblGovernmentLetter_WO where Letter_No = @p1";
        //        string Letter_Number = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection,isnull(DO_Letter, '    -----') as DOletter,isnull(Right_To_Info_Letter,'    -------') as RightToInfoLetter, isnull(Government_Letter,'    ------') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -------') as LokayuktaABSLetter  from tblGovernmentLetter_IN where Letter_No = @p1 Order by GL_No_Id";

        //        //  string Letter_Number = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection,isnull(DO_Letter, '    ------') as DOletter,isnull(Right_To_Info_Letter,'    ------') as RightToInfoLetter, isnull(Government_Letter,'    ------') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -----') as LokayuktaABSLetter   from tblGovernmentLetter_IN where  GL_No_Id ='" + txtSearch.Text + "'";

        //        cmd = new SqlCommand(Letter_Number, conn);
        //        cmd.Parameters.AddWithValue("@p1", txtSearch.Text);

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridView_Search_GL_No.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found for Letter Number : " + "'" + txtSearch.Text + "'");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //// Search Function for Inward Number

        //private void Search_Inward_No()
        //{
        //    try
        //    {
        //        //string Letter_Number = "Select * from tblGovernmentLetter_WO where Letter_No = @p1";
        //        string Inward_No = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection,isnull(DO_Letter, '    -----') as DOletter,isnull(Right_To_Info_Letter,'    -------') as RightToInfoLetter, isnull(Government_Letter,'    ------') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -------') as LokayuktaABSLetter  from tblGovernmentLetter_IN where Inward_No = @p1 Order by GL_No_Id";
        //        cmd = new SqlCommand(Inward_No, conn);
        //        cmd.Parameters.AddWithValue("@p1", txtSearch.Text);

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridView_Search_GL_No.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found for Inward Number : " + "'" + txtSearch.Text + "'");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //// Search Function for  GL No

        //private void Search_GL_No()
        //{
        //    try
        //    {
        //        string GL_No = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection,isnull(DO_Letter, '    ------') as DOletter,isnull(Right_To_Info_Letter,'    ------') as RightToInfoLetter, isnull(Government_Letter,'    ------') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -----') as LokayuktaABSLetter   from tblGovernmentLetter_IN where  GL_No_Id ='" + txtSearch.Text + "' Order by GL_No_Id";
        //        cmd = new SqlCommand(GL_No, conn);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridView_Search_GL_No.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found for GL Number : " + "'" + txtSearch.Text + "'");
        //        }

        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        ////Search Function for All Letter

        //private void Search_All_Letters()
        //{
        //    try
        //    {
        //        string All_Letters = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,Hobli,Village,GL_No_Id,Inward_No,ToSubsection,isnull(DO_Letter, '    ------') as DOletter,isnull(Right_To_Info_Letter,'    -----') as RightToInfoLetter, isnull(Government_Letter,'    -----') as GovernmentLetter,isnull(Lokayukta_ABS_Letter,'    -----') as LokayuktaABSLetter,Applicant_Name  from tblGovernmentLetter_IN  Order by GL_No_Id";
        //        //string DO_Letter = "Select DO_Letter,Inward_No,Letter_No,Letter_Date,FromDept,isnull(Other_Dept,'-'),FromOffice,Subject,Gl_No,Signature,ToSection,ToSubSection,ToCaseWorker from tblReceiverNew where DO_Letter = @p1";
        //        cmd = new SqlCommand(All_Letters, conn);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridView_All_letters.DataSource = dt;
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No Document's Found");
        //            lblLetterDetails.Visible = false;
        //        }
        //        else
        //        {
        //            lblLetterDetails.Visible = true;
        //            lblLetterDetails.Text = "The following are the Details of All Letters";
        //        }
        //        //foreach (DataGridViewRow row in dataGridView1.Rows)
        //        //{
        //        //    DataGridViewLinkCell link = new DataGridViewLinkCell();
        //        //    link.Value = row.Cells[1].Value;
        //        //    row.Cells[1] = link;
        //        //}


        //        // Datagridview  function call

        //        // DatagridProp();
        //    }
        //    catch (Exception)
        //    {

        //    }

        //}

        // To Search  Record on button click

        //private void SearchAll()
        //{
        //    try
        //    {
        //        if (optDOLetter.Checked && txtSearch.Text == "")
        //        {
        //            Search_DO_Letter();
        //            dataGridView_Search_GL_No.Visible = false;
        //            dataGridViewDOLetter.Visible = true;
        //            dataGridView_All_letters.Visible = false;

        //        }
        //        else if (optGeneral.Checked && txtSearch.Text == "")
        //        {
        //            Search_General_Letter();
        //            dataGridViewDOLetter.Visible = true;
        //            dataGridView_All_letters.Visible = false;
        //            dataGridView_Search_GL_No.Visible = false;
        //        }
        //        else if (optRightToInformationLetter.Checked && txtSearch.Text == "")
        //        {
        //            Search_Right_To_Info_Letter();
        //            dataGridView_Search_GL_No.Visible = false;
        //            dataGridViewDOLetter.Visible = true;
        //            dataGridView_All_letters.Visible = false;

        //        }
        //        else if (optGovtLetter.Checked && txtSearch.Text == "")
        //        {
        //            Search_Government_Letter();
        //            dataGridView_Search_GL_No.Visible = false;
        //            dataGridViewDOLetter.Visible = true;
        //            dataGridView_All_letters.Visible = false;
        //       }
        //        else if (radLokayuktaLetter.Checked && txtSearch.Text == "")
        //        {
        //            Search_Lokayukta_ABS_Letter();
        //            dataGridView_Search_GL_No.Visible = false;
        //            dataGridViewDOLetter.Visible = true;
        //            dataGridView_All_letters.Visible = false;
        //        }
        //        else if (radAllLetters.Checked && txtSearch.Text == "")
        //        {
        //            Search_All_Letters();
        //            dataGridView_Search_GL_No.Visible = false;
        //            dataGridViewDOLetter.Visible = false;
        //            dataGridView_All_letters.Visible = true;

        //        }
        //        else if (optGLNo.Checked && txtSearch.Text != "")
        //        {
        //            Search_GL_No();
        //            lblLetterDetails.Visible = false;
        //            dataGridView_Search_GL_No.Visible = true;
        //            dataGridViewDOLetter.Visible = false;
        //            dataGridView_All_letters.Visible = false;

        //        }
        //        else if (radLetterNo.Checked && txtSearch.Text != "")
        //        {
        //            Search_Letter_Number();
        //            lblLetterDetails.Visible = false;
        //            dataGridView_Search_GL_No.Visible = true;
        //            dataGridViewDOLetter.Visible = false;
        //            dataGridView_All_letters.Visible = false;

        //        }
        //        else if (optInwardNo.Checked && txtSearch.Text != "")
        //        {
        //            Search_Inward_No();
        //            lblLetterDetails.Visible = false;
        //            dataGridView_Search_GL_No.Visible = true;
        //            dataGridViewDOLetter.Visible = false;
        //            dataGridView_All_letters.Visible = false;

        //        }

        //        else if (optSubject.Checked && txtSearch.Text != "")
        //        {
        //            Search_Subject();
        //            lblLetterDetails.Visible = false;
        //            dataGridView_Search_GL_No.Visible = true;
        //            dataGridViewDOLetter.Visible = false;
        //            dataGridView_All_letters.Visible = false;


        //        }
        //        else if (optGLNo.Checked && txtSearch.Text == "")
        //        {
        //            MessageBox.Show("Please Enter GL Number");
        //        }
        //        else if (optSubject.Checked && txtSearch.Text == "")
        //        {
        //            MessageBox.Show("Please Enter Subject");
        //        }
        //        else if (radLetterNo.Checked && txtSearch.Text == "")
        //        {
        //            MessageBox.Show("Please Enter Letter Number");
        //        }
        //        else if (optInwardNo.Checked && txtSearch.Text == "")
        //        {
        //            MessageBox.Show("Please Enter Inward Number");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        private void btnBack_Click_1(object sender, EventArgs e)
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

        private void dataGridView_Search_GL_No_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView_Search_GL_No.Columns[e.ColumnIndex].Name == "GlNoId")
                {

                    dataGridView_Search_GL_No.Rows[e.RowIndex].ReadOnly = true;

                    string LetterNo = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string ReceiveDate = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string LetterDate = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string FromDept = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string FromOffice = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string ToSection = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string ToCaseWorker = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[7].Value.ToString();
                    string Subject = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[8].Value.ToString();
                    //   string Hobli = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[9].Value.ToString();
                    //     string Village = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string GLNoId = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[9].Value.ToString();
                    //  string Signature = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[12].Value.ToString();
                    string InwardNo = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string ToSubsection = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string DOLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[12].Value.ToString();
                    //  string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    string RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[13].Value.ToString();
                    string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[14].Value.ToString();
                    string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    string GeneralLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();


                    // Imp
                    string message = "GL Number\t\t   : " + GLNoId + "\nLetter Number\t\t   : " + LetterNo + "\nInward Number\t\t   : " + InwardNo + "\nReceived Date\t\t   : " + ReceiveDate + "\nLetter Date\t\t   : " + LetterDate + "\nFrom Department\t\t   : " + FromDept + "\nFrom Office\t\t   : " + FromOffice + "\nTo Section\t\t   : " + ToSection + "\nTo Subsection\t\t   : " + ToSubsection + "\nTo Case Worker\t\t   :" + ToCaseWorker + "\n DO Letter\t\t\t   : " + DOLetter + "\n Right to Information Letter\t  :  " + RightToInfoLetter + "\n Government Letter\t\t   : " + GovernmentLetter + " \nLokayukta/ACB\t\t   : " + LokayuktaABSLetter + "\nGeneralLetter\t\t : " + GeneralLetter + "" + "\nSubject\t\t\t :\n  " + Subject;


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
                    // string Hobli = dataGridView_All_letters.Rows[e.RowIndex].Cells[9].Value.ToString();
                    //  string Village = dataGridView_All_letters.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string GLNoId = dataGridView_All_letters.Rows[e.RowIndex].Cells[9].Value.ToString();
                    //  string Signature = dataGridView_All_letters.Rows[e.RowIndex].Cells[12].Value.ToString();
                    string InwardNo = dataGridView_All_letters.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string ToSubsection = dataGridView_All_letters.Rows[e.RowIndex].Cells[11].Value.ToString();


                    //string DOLetter = dataGridViewDOLetter.Rows[e.RowIndex].Cells[14].Value.ToString();
                    //string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    //string  RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();
                    //string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[17].Value.ToString();
                    //string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[18].Value.ToString();

                    // Imp
                    string message = "GL Number\t :   " + GLNoId + "\nLetter Number\t :  " + LetterNo + "\nInward Number\t : " + InwardNo + "\nReceived Date\t :   " + ReceiveDate + "\nLetter Date\t :     " + LetterDate + "\nFrom Department\t :  " + FromDept + "\nFrom Office\t : " + FromOffice + "\nTo Section\t :  " + ToSection + "\nTo Subsection\t : " + ToSubsection + "\nTo Case Worker\t :     " + ToCaseWorker + "\nSubject\t\t  :   \n  " + Subject;
                    MessageBox.Show(message);
                }

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
                    // string Hobli = dataGridViewDOLetter.Rows[e.RowIndex].Cells[9].Value.ToString();
                    //  string Village = dataGridViewDOLetter.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string GLNoId = dataGridViewDOLetter.Rows[e.RowIndex].Cells[9].Value.ToString();
                    //  string Signature = dataGridView_All_letters.Rows[e.RowIndex].Cells[12].Value.ToString();
                    string InwardNo = dataGridViewDOLetter.Rows[e.RowIndex].Cells[10].Value.ToString();
                    string ToSubsection = dataGridViewDOLetter.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string ApplicantName = dataGridViewDOLetter.Rows[e.RowIndex].Cells[12].Value.ToString();

                    //string DOLetter = dataGridViewDOLetter.Rows[e.RowIndex].Cells[14].Value.ToString();
                    //string CourtCaseLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[15].Value.ToString();
                    //string  RightToInfoLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[16].Value.ToString();
                    //string GovernmentLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[17].Value.ToString();
                    //string LokayuktaABSLetter = dataGridView_Search_GL_No.Rows[e.RowIndex].Cells[18].Value.ToString();

                    // Imp
                    string message = "GL Number\t : " + GLNoId + "\nLetter Number\t : " + LetterNo + "\nInward Number\t : " + InwardNo + "\nReceived Date\t : " + ReceiveDate + "\nLetter Date\t: " + LetterDate + "\nFrom Department\t : " + FromDept + "\nFrom Office\t : " + FromOffice + "\nTo Section\t  :  " + ToSection + "\nTo Subsection\t  : " + ToSubsection + "\nTo Case Worker\t :     " + ToCaseWorker + "\nSubject\t\t :\n  " + Subject;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (optGLNo.Checked && txtSearch.Text == "")
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
                else if (optInwardNo.Checked && txtSearch.Text == "")
                {
                    MessageBox.Show("Please Enter Inward Number");
                }
                else if (optGLNo.Checked == true || radLetterNo.Checked == true || optInwardNo.Checked == true || optSubject.Checked == true)
                {
                    Search_Number_2017();
                }
                else if (optDOLetter.Checked == true || optGeneralLetter.Checked == true || optRightToInformationLetter.Checked == true || radLokayuktaLetter.Checked == true || optGovtLetter.Checked == true)
                {
                    Search_Government_2017();
                }
                else if (radAllLetters.Checked == true)
                {
                    Search_All_2017();
                }

                txtSearch.Text = "";
            }
            catch (Exception)
            {

            }
        }

        //Save Government Letters from 2017
        private void Search_Government_2017()
        {
            try
            {
                //string following = " The following are the ";
                //string DO = " DO ";
                //string Government = " Government ";
                //string CourtCase = " CourtCase "; 
                //string Right_To_Information = " Right To Information ";
                //string Lokayukta = " Lokayukta ";
                //string Letters = " Letters Between ";
                //string C_2017_2018 = " 1st April 2017 and 31 March 2018 ";

                string s = "";
                string Govt = "";
                string Common1 = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,GL_No_Id,Inward_No,ToSubsection,Applicant_Name from ";
                string Common2 = " and Entry_Date Between @p1 and @p2 Order by GL_No_Id ";
                string Common_2017_2018 = "  tblGovernmentLetter_IN_2017_2018  where ";
                string Common_2018_2019 = "  tblGovernmentLetter_IN_2018_2019  where ";
                string Common_2019_2020 = "  tblGovernmentLetter_IN_2019_2020  where ";
                string Common_2020_2021 = "  tblGovernmentLetter_IN_2020_2021  where ";
                string Common_2021_2022 = "  tblGovernmentLetter_IN_2021_2022  where ";
                string Common_2022_2023 = "  tblGovernmentLetter_IN_2022_2023  where ";
                string Common_2023_2024 = "  tblGovernmentLetter_IN_2023_2024  where ";
                string Common_2024_2025 = "  tblGovernmentLetter_IN_2024_2025  where ";

                //  s = string.Concat(Common1, Common_2016_2017, Govt, Common2);
                lblLetterDetails.Visible = true;

                //2017-2018
                if (cbFinYear.Text == "2017-2018")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2017 and 31 March 2018";
                        // lblLetterDetails.Text = following + DO + Letters + C_2017_2018;
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2017 and 31 March 2018";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2017 and 31 March 2018";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Letters Between 1st April 2017 and 31 March 2018";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2017 and 31 March 2018";
                    }
                    s = string.Concat(Common1, Common_2017_2018, Govt, Common2);
                }

                //2018-2019
                else if (cbFinYear.Text == "2018-2019")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2018 and 31 March 2019";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2018 and 31 March 2019";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2018 and 31 March 2019";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Letters Between 1st April 2018 and 31 March 2019";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2018 and 31 March 2019";
                    }
                    s = string.Concat(Common1, Common_2018_2019, Govt, Common2);
                }

               //2019-2020
                else if (cbFinYear.Text == "2019-2020")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2019 and 31 March 2020";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2019 and 31 March 2020";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2019 and 31 March 2020";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2019 and 31 March 2020";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2019 and 31 March 2020";
                    }
                    s = string.Concat(Common1, Common_2019_2020, Govt, Common2);
                }

                 //2020-2021
                else if (cbFinYear.Text == "2020-2021")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2020 and 31 March 2021";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2020 and 31 March 2021";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2020 and 31 March 2021";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2020 and 31 March 2021";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2020 and 31 March 2021";
                    }
                    s = string.Concat(Common1, Common_2020_2021, Govt, Common2);
                }

                //2021-2022
                else if (cbFinYear.Text == "2021-2022")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2021 and 31 March 2022";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2021 and 31 March 2022";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2021 and 31 March 2022";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2021 and 31 March 2022";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2021 and 31 March 2022";
                    }
                    s = string.Concat(Common1, Common_2021_2022, Govt, Common2);
                }

               //2022-2023
                else if (cbFinYear.Text == "2022-2023")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2022 and 31 March 2023";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2022 and 31 March 2023";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2022 and 31 March 2023";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2022 and 31 March 2023";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2022 and 31 March 2023";
                    }
                    s = string.Concat(Common1, Common_2022_2023, Govt, Common2);
                }

               //2023-2024
                else if (cbFinYear.Text == "2023-2024")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2023 and 31 March 2024";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2023 and 31 March 2024";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2023 and 31 March 2024";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2023 and 31 March 2024";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2023 and 31 March 2024";
                    }
                    s = string.Concat(Common1, Common_2023_2024, Govt, Common2);
                }

                //2024-2025
                else if (cbFinYear.Text == "2024-2025")
                {
                    if (optDOLetter.Checked == true)
                    {
                        Govt = " DO_Letter='DoLetter' ";
                        lblLetterDetails.Text = "The following are the DO Letters Between 1st April 2024 and 31 March 2025";
                    }
                    else if (optGovtLetter.Checked == true)
                    {
                        Govt = " Government_Letter='GovernmentLetter' ";
                        lblLetterDetails.Text = "The following are the Government Letters Between 1st April 2024 and 31 March 2025";
                    }
                    else if (optGeneralLetter.Checked == true)
                    {
                        Govt = "  General_Letter='GeneralLetter' ";
                        lblLetterDetails.Text = "The following are the General Letters Between 1st April 2024 and 31 March 2025";
                    }
                    else if (optRightToInformationLetter.Checked == true)
                    {
                        Govt = " Right_To_Info_Letter='RightToInfoLetter' ";
                        lblLetterDetails.Text = "The following are the Right To Information Between 1st April 2024 and 31 March 2025";
                    }
                    else if (radLokayuktaLetter.Checked == true)
                    {
                        Govt = " Lokayukta_ABS_Letter='LokayuktaLetter' ";
                        lblLetterDetails.Text = "The following are the Lokayukta Letters Between 1st April 2024 and 31 March 2025";
                    }
                    s = string.Concat(Common1, Common_2024_2025, Govt, Common2);
                }

                //Command 
                cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDOLetter.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found,Select Different Date!");
                    lblLetterDetails.Visible = false;

                }

                else
                {
                    lblLetterDetails.Visible = true;
                }
                dataGridViewDOLetter.Visible = true;
                dataGridView_All_letters.Visible = false;
                dataGridView_Search_GL_No.Visible = false;
                dataGridViewDOLetter.ForeColor = Color.Black;

            }
            catch (Exception)
            {

            }
        }

        //Save GlNo,LetterNo,InwardNo,Subject Letters from 2017
        private void Search_Number_2017()
        {
            try
            {
                string s = "";
                //string Common = "";
                //string Common1 = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,"
                //+ " Hobli,Village,GL_No_Id,Signature,isnull(DO_Letter, '    -----') as DOletter,isnull(Court_Case_Letter, '   ------') as CourtCaseLetter,"
                //+ " isnull(Right_To_Info_Letter,'    -------') as RightToInfoLetter, isnull(Government_Letter,'    ------') as GovernmentLetter,"
                //+ " isnull(Lokayukta_ABS_Letter,'    -------') as LokayuktaABSLetter  from ";


                string Common1 = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate , "
                              + " FromDept,FromOffice,ToSection,ToCaseWorker,Subject,GL_No_Id,Inward_No,ToSubsection,Applicant_Name,isnull(DO_Letter, '    -----') as DOletter, "
                                + " isnull(Right_To_Info_Letter,'    -------') as RightToInfoLetter, isnull(Government_Letter,'    ------') as GovernmentLetter, "
                              + " isnull(Lokayukta_ABS_Letter,'    -------') as LokayuktaABSLetter,isnull(General_Letter, '     -------') as General_Letter  from ";

                // string Common1 = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate,CONVERT(varchar, Letter_Date, 103) as LetterDate , "
                //                + " FromDept,FromOffice,ToSection,ToCaseWorker,Subject,GL_No_Id,Inward_No,ToSubsection,Applicant_Name  from ";


                string Common4 = " R  where (R.Subject LIKE @Search)  Order by GL_No_Id ";
                string Common3 = " Order by GL_No_Id  ";
                string Common2 = " where ";
                // string Common6 = " R ";
                //  string Common7 = " (R.Subject LIKE @Search) ";
                string Common_2017_2018 = "  tblGovernmentLetter_IN_2017_2018   ";
                string Common_2018_2019 = "  tblGovernmentLetter_IN_2018_2019   ";
                string Common_2019_2020 = "  tblGovernmentLetter_IN_2019_2020   ";
                string Common_2020_2021 = "  tblGovernmentLetter_IN_2020_2021   ";
                string Common_2021_2022 = "  tblGovernmentLetter_IN_2021_2022   ";
                string Common_2022_2023 = "  tblGovernmentLetter_IN_2022_2023   ";
                string Common_2023_2024 = "  tblGovernmentLetter_IN_2023_2024   ";
                string Common_2024_2025 = "  tblGovernmentLetter_IN_2024_2025   ";

                lblLetterDetails.Visible = true;

                //GlNo Condition
                string GlNo_Condition = " GL_No_Id ='" + txtSearch.Text + "'";
                //Letter  Condition
                string Letter_Condition = " Letter_No = N'" + txtSearch.Text + "'";
                //Inward Condition 
                string Inward_Condition = " Inward_No = N'" + txtSearch.Text + "'";

                //GlNo query
                string GlNo = string.Concat(Common1, Common_2017_2018, Common2, GlNo_Condition, Common3);
                //Letter No query
                string LetterNo = string.Concat(Common1, Common_2017_2018, Common2, Letter_Condition, Common3);
                //Inward No query
                string InwardNo = string.Concat(Common1, Common_2017_2018, Common2, Inward_Condition, Common3);
                //Subject Query
                string Subject = string.Concat(Common1, Common_2017_2018, Common4);

                //2017-2018
                if (cbFinYear.Text == "2017-2018")
                {
                    if (optGLNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                        s = string.Concat(Common1, Common_2017_2018, Common2, GlNo_Condition, Common3);
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2017_2018, Common2, Letter_Condition, Common3);
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2017_2018, Common2, Inward_Condition, Common3);
                    }
                    else if (optSubject.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2017_2018, Common4);
                    }
                }

                //2018-2019
                if (cbFinYear.Text == "2018-2019")
                {
                    if (optGLNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                        s = string.Concat(Common1, Common_2018_2019, Common2, GlNo_Condition, Common3);
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2018_2019, Common2, Letter_Condition, Common3);
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2018_2019, Common2, Inward_Condition, Common3);
                    }
                    else if (optSubject.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2018_2019, Common4);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                }

                //2019-2020
                if (cbFinYear.Text == "2019-2020")
                {
                    if (optGLNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                        s = string.Concat(Common1, Common_2019_2020, Common2, GlNo_Condition, Common3);
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2019_2020, Common2, Letter_Condition, Common3);
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2019_2020, Common2, Inward_Condition, Common3);
                    }
                    else if (optSubject.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2019_2020, Common4);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                }

                //2020-2021
                if (cbFinYear.Text == "2020-2021")
                {
                    if (optGLNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                        s = string.Concat(Common1, Common_2020_2021, Common2, GlNo_Condition, Common3);
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2020_2021, Common2, Letter_Condition, Common3);
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2020_2021, Common2, Inward_Condition, Common3);
                    }
                    else if (optSubject.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2020_2021, Common4);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                }

                //2021-2022
                if (cbFinYear.Text == "2021-2022")
                {
                    if (optGLNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                        s = string.Concat(Common1, Common_2021_2022, Common2, GlNo_Condition, Common3);
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2021_2022, Common2, Letter_Condition, Common3);
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2021_2022, Common2, Inward_Condition, Common3);
                    }
                    else if (optSubject.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2021_2022, Common4);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                }

                //2022-2023
                if (cbFinYear.Text == "2022-2023")
                {
                    if (optGLNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                        s = string.Concat(Common1, Common_2022_2023, Common2, GlNo_Condition, Common3);
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2022_2023, Common2, Letter_Condition, Common3);
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2022_2023, Common2, Inward_Condition, Common3);
                    }
                    else if (optSubject.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2022_2023, Common4);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                }

                //2023-2024
                if (cbFinYear.Text == "2023-2024")
                {
                    if (optGLNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                        s = string.Concat(Common1, Common_2023_2024, Common2, GlNo_Condition, Common3);
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2023_2024, Common2, Letter_Condition, Common3);
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2023_2024, Common2, Inward_Condition, Common3);
                    }
                    else if (optSubject.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2023_2024, Common4);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                }

                //2024-2025
                if (cbFinYear.Text == "2024-2025")
                {
                    if (optGLNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered GL Number : " + txtSearch.Text + "";
                        s = string.Concat(Common1, Common_2024_2025, Common2, GlNo_Condition, Common3);
                    }
                    else if (radLetterNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Letter Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2024_2025, Common2, Letter_Condition, Common3);
                    }
                    else if (optInwardNo.Checked == true)
                    {
                        lblLetterDetails.Text = "Entered Inward Number : '" + txtSearch.Text + "'";
                        s = string.Concat(Common1, Common_2024_2025, Common2, Inward_Condition, Common3);
                    }
                    else if (optSubject.Checked == true)
                    {
                        s = string.Concat(Common1, Common_2024_2025, Common4);
                        lblLetterDetails.Text = "Entered Subject : '" + txtSearch.Text + "'";
                    }
                }

                //Command 
                cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
                cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDOLetter.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found for " + txtSearch.Text + "");
                    lblLetterDetails.Visible = false;
                }

                else
                {
                    lblLetterDetails.Visible = true;
                }
                // dataGridView_Search_GL_No.Visible = true;
                dataGridViewDOLetter.Visible = true;

                //  dataGridViewDOLetter.Visible = false;
                dataGridView_All_letters.Visible = false;
                dataGridView_Search_GL_No.Visible = false;
                // dataGridView_Search_GL_No.ForeColor = Color.Black;
                dataGridViewDOLetter.ForeColor = Color.Black;
            }

            catch (Exception)
            {

            }
        }

        //Save ALL Letters from 2017
        private void Search_All_2017()
        {
            try
            {
                string Common1 = "Select Letter_No,CONVERT(varchar, Received_Date, 103) as ReceivedDate, "
                + " CONVERT(varchar, Letter_Date, 103) as LetterDate ,FromDept,FromOffice,ToSection,ToCaseWorker,Subject, "
                + " GL_No_Id,Inward_No,ToSubsection, "
                 + " isnull(Applicant_Name,'    -----------') as ApplicantName, "
                + " isnull(DO_Letter, '    ------') as DOletter, "
                + " isnull(Right_To_Info_Letter,'    -----') as RightToInfoLetter, "
                + " isnull(Government_Letter,'    -----') as GovernmentLetter, "
                + " isnull(Lokayukta_ABS_Letter,'    -----') as LokayuktaABSLetter, "
                + " isnull(General_Letter, '     -------') as General_Letter from ";




                string s = "";
                string Common = "";
                // string Common1 = "Select Letter_No,Received_Date,Letter_Date,FromDept,FromOffice,ToSection,ToCaseWorker,Subject,"
                //+ " Hobli,Village,GL_No_Id,Signature,isnull(DO_Letter, '    ------') as DOletter,isnull(Court_Case_Letter, '   ------') as CourtCaseLetter,"
                //+ " isnull(Right_To_Info_Letter,'    -----') as RightToInfoLetter, isnull(Government_Letter,'    -----') as GovernmentLetter,"
                //+ " isnull(Lokayukta_ABS_Letter,'    -----') as LokayuktaABSLetter  from ";

                string Common2 = " Entry_Date Between @p1 and @p2 Order by GL_No_Id ";
                lblLetterDetails.Visible = true;


                //2017-2018
                if (cbFinYear.Text == "2017-2018")
                {
                    Common = " tblGovernmentLetter_IN_2017_2018  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2017 and 31 March 2018";
                }

                //2018-2019
                else if (cbFinYear.Text == "2018-2019")
                {
                    Common = " tblGovernmentLetter_IN_2018_2019  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2018 and 31 March 2019";
                }

               //2019-2020
                else if (cbFinYear.Text == "2019-2020")
                {
                    Common = " tblGovernmentLetter_IN_2019_2020  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2019 and 31 March 2020";
                }

                 //2020-2021
                else if (cbFinYear.Text == "2020-2021")
                {
                    Common = " tblGovernmentLetter_IN_2020_2021  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2020 and 31 March 2021";
                }

               //2021-2022
                else if (cbFinYear.Text == "2021-2022")
                {
                    Common = " tblGovernmentLetter_IN_2021_2022  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2021 and 31 March 2022";
                }

               //2022-2023
                else if (cbFinYear.Text == "2022-2023")
                {
                    Common = " tblGovernmentLetter_IN_2022_2023  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2022 and 31 March 2023";
                }

               //2023-2024
                else if (cbFinYear.Text == "2023-2024")
                {
                    Common = " tblGovernmentLetter_IN_2023_2024  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2023 and 31 March 2024";
                }

               //2024-2025
                else if (cbFinYear.Text == "2024-2025")
                {
                    Common = " tblGovernmentLetter_IN_2024_2025  where ";
                    lblLetterDetails.Text = "The following are the Details of All Government Letters Between 1st April 2024 and 31 March 2025";
                }


                //Command 
                s = string.Concat(Common1, Common, Common2);
                cmd = new SqlCommand(s, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.Date);
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_All_letters.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found for " + txtSearch.Text + "");
                    lblLetterDetails.Visible = false;
                }

                else
                {
                    lblLetterDetails.Visible = true;
                }
                dataGridView_All_letters.Visible = true;
                dataGridView_Search_GL_No.Visible = false;
                dataGridViewDOLetter.Visible = false;
                dataGridView_All_letters.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        //Load Fin Year value
        private void LoadFinYear()
        {
            try
            {
                if (lblFinYearValue.Text == "2017-2018")
                {
                    cbFinYear.Text = "2017-2018";
                }
                else if (lblFinYearValue.Text == "2018-2019")
                {
                    cbFinYear.Text = "2018-2019";
                }
                else if (lblFinYearValue.Text == "2019-2020")
                {
                    cbFinYear.Text = "2019-2020";
                }
                else if (lblFinYearValue.Text == "2020-2021")
                {
                    cbFinYear.Text = "2020-2021";
                }
                else if (lblFinYearValue.Text == "2021-2022")
                {
                    cbFinYear.Text = "2021-2022";
                }
                else if (lblFinYearValue.Text == "2022-2023")
                {
                    cbFinYear.Text = "2022-2023";
                }
                else if (lblFinYearValue.Text == "2023-2024")
                {
                    cbFinYear.Text = "2023-2024";
                }
                else if (lblFinYearValue.Text == "2024-2025")
                {
                    cbFinYear.Text = "2024-2025";
                }
            }
            catch (Exception)
            {

            }
        }

        private void optGLNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optGLNo.Checked == true)
                {
                    grpNumber.Visible = true;
                    grpDate.Visible = false;
                    lblNumber.Text = "Enter GL Number(Only Numbers Allowed)";
                }
                else if (optGLNo.Checked == false)
                {
                    grpNumber.Visible = false;
                    grpDate.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void radLetterNo_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (radLetterNo.Checked == true)
                {
                    grpNumber.Visible = true;
                    grpDate.Visible = false;
                    lblNumber.Text = "Enter Letter Number";
                }
                else if (radLetterNo.Checked == false)
                {
                    grpNumber.Visible = false;
                    grpDate.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optInwardNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optInwardNo.Checked == true)
                {
                    grpNumber.Visible = true;
                    grpDate.Visible = false;
                    lblNumber.Text = "Enter Inward Number";
                }
                else if (optInwardNo.Checked == false)
                {
                    grpNumber.Visible = false;
                    grpDate.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optSubject_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optSubject.Checked == true)
                {
                    grpNumber.Visible = true;
                    grpDate.Visible = false;
                    lblNumber.Text = "Enter Subject";
                }
                else if (optSubject.Checked == false)
                {
                    grpNumber.Visible = false;
                    grpDate.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optGeneralLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optGeneralLetter.Checked == true)
                {
                    grpDate.Visible = true;
                    grpNumber.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'GENERAL LETTER'";
                }
                else if (optGeneralLetter.Checked == false)
                {
                    grpDate.Visible = false;
                    grpNumber.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void radLokayuktaLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radLokayuktaLetter.Checked == true)
                {
                    grpDate.Visible = true;
                    grpNumber.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'LOKAYUKTA LETTER'";
                }
                else if (radLokayuktaLetter.Checked == false)
                {
                    grpDate.Visible = false;
                    grpNumber.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optDOLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optDOLetter.Checked == true)
                {
                    grpDate.Visible = true;
                    grpNumber.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'DO LETTER'";
                }
                else if (optDOLetter.Checked == false)
                {
                    grpDate.Visible = false;
                    grpNumber.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optRightToInformationLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optRightToInformationLetter.Checked == true)
                {
                    grpDate.Visible = true;
                    grpNumber.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'RTI LETTER'";
                }
                else if (optRightToInformationLetter.Checked == false)
                {
                    grpDate.Visible = false;
                    grpNumber.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void optGovtLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optGovtLetter.Checked == true)
                {
                    grpDate.Visible = true;
                    grpNumber.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'GOVERNMENT LETTER'";
                }
                else if (optGovtLetter.Checked == false)
                {
                    grpDate.Visible = false;
                    grpNumber.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void radAllLetters_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radAllLetters.Checked == true)
                {
                    grpDate.Visible = true;
                    grpNumber.Visible = false;
                    lblTypeOfLetter.Text = "You have selected 'ALL GOVERNMENT's LETTER'";
                }
                else if (radAllLetters.Checked == false)
                {
                    grpDate.Visible = false;
                    grpNumber.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbFinYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbFinYear.Text == "2017-2018")
                {
                    lblDateBetween.Text = "1st April 2017 and 31 March 2018";
                }
                else if (cbFinYear.Text == "2018-2019")
                {
                    lblDateBetween.Text = "1st April 2018 and 31 March 2019";
                }
                else if (cbFinYear.Text == "2019-2020")
                {
                    lblDateBetween.Text = "1st April 2019 and 31 March 2020";
                }
                else if (cbFinYear.Text == "2020-2021")
                {
                    lblDateBetween.Text = "1st April 2020 and 31 March 2021";
                }
                else if (cbFinYear.Text == "2021-2022")
                {
                    lblDateBetween.Text = "1st April 2021 and 31 March 2022";
                }
                else if (cbFinYear.Text == "2022-2023")
                {
                    lblDateBetween.Text = "1st April 2022 and 31 March 2023";
                }
                else if (cbFinYear.Text == "2023-2024")
                {
                    lblDateBetween.Text = "1st April 2023 and 31 March 2024";
                }
                else if (cbFinYear.Text == "2024-2025")
                {
                    lblDateBetween.Text = "1st April 2024 and 31 March 2025";
                }
                lblDateBetween.BackColor = System.Drawing.Color.Red;

            }
            catch (Exception)
            {

            }
        }

        private void btnGotoGovtLetterPagee_Click(object sender, EventArgs e)
        {
            try
            {
                var Back = new SearchCourtCase_IN();
                Back.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
