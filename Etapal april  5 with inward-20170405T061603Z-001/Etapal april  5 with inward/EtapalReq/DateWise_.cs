using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using EtapalReq;
using DGVPrinterHelper;
using EtapalUpdatedNew;

namespace EtapalReq
{
    public partial class DateWise_ : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS;initial catalog=EtapalReq;integrated security=true");
        SqlCommand cmd;
        public DateWise_()
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

            this.dataGridView2.Columns[0].ReadOnly = true;
            this.dataGridView2.Columns[1].ReadOnly = true;
            this.dataGridView2.Columns[2].ReadOnly = true;
            this.dataGridView2.Columns[3].ReadOnly = true;
            this.dataGridView2.Columns[4].ReadOnly = true;
            this.dataGridView2.Columns[5].ReadOnly = true;
            this.dataGridView2.Columns[6].ReadOnly = true;
            this.dataGridView2.Columns[7].ReadOnly = true;
            this.dataGridView2.Columns[8].ReadOnly = true;
            this.dataGridView2.Columns[9].ReadOnly = true;
            this.dataGridView2.Columns[10].ReadOnly = true;
            this.dataGridView2.Columns[11].ReadOnly = true;
            this.dataGridView2.Columns[12].ReadOnly = true;
            this.dataGridView2.Columns[13].ReadOnly = true;

            this.dataGridView3.Columns[0].ReadOnly = true;
            this.dataGridView3.Columns[1].ReadOnly = true;
            this.dataGridView3.Columns[2].ReadOnly = true;
            this.dataGridView3.Columns[3].ReadOnly = true;
            this.dataGridView3.Columns[4].ReadOnly = true;
            this.dataGridView3.Columns[5].ReadOnly = true;
            this.dataGridView3.Columns[6].ReadOnly = true;
            this.dataGridView3.Columns[7].ReadOnly = true;
            this.dataGridView3.Columns[8].ReadOnly = true;
            this.dataGridView3.Columns[9].ReadOnly = true;
            this.dataGridView3.Columns[10].ReadOnly = true;
            this.dataGridView3.Columns[11].ReadOnly = true;
            this.dataGridView3.Columns[12].ReadOnly = true;
            this.dataGridView3.Columns[13].ReadOnly = true;

            this.dataGridView4.Columns[0].ReadOnly = true;
            this.dataGridView4.Columns[1].ReadOnly = true;
            this.dataGridView4.Columns[2].ReadOnly = true;
            this.dataGridView4.Columns[3].ReadOnly = true;
            this.dataGridView4.Columns[4].ReadOnly = true;
            this.dataGridView4.Columns[5].ReadOnly = true;
            this.dataGridView4.Columns[6].ReadOnly = true;
            this.dataGridView4.Columns[7].ReadOnly = true;
            this.dataGridView4.Columns[8].ReadOnly = true;
            this.dataGridView4.Columns[9].ReadOnly = true;
            this.dataGridView4.Columns[10].ReadOnly = true;
            this.dataGridView4.Columns[11].ReadOnly = true;
            this.dataGridView4.Columns[12].ReadOnly = true;
            this.dataGridView4.Columns[13].ReadOnly = true;

            this.dataGridView5.Columns[0].ReadOnly = true;
            this.dataGridView5.Columns[1].ReadOnly = true;
            this.dataGridView5.Columns[2].ReadOnly = true;
            this.dataGridView5.Columns[3].ReadOnly = true;
            this.dataGridView5.Columns[4].ReadOnly = true;
            this.dataGridView5.Columns[5].ReadOnly = true;
            this.dataGridView5.Columns[6].ReadOnly = true;
            this.dataGridView5.Columns[7].ReadOnly = true;
            this.dataGridView5.Columns[8].ReadOnly = true;
            this.dataGridView5.Columns[9].ReadOnly = true;
            this.dataGridView5.Columns[10].ReadOnly = true;
            this.dataGridView5.Columns[11].ReadOnly = true;
            this.dataGridView5.Columns[12].ReadOnly = true;
            this.dataGridView5.Columns[13].ReadOnly = true;
           // this.dataGridView1.Columns[14].ReadOnly = true;
            //this.dataGridView1.Columns[13].ReadOnly = true;
            //this.dataGridView1.Columns[14].ReadOnly = true;
            //this.dataGridView1.Columns[15].ReadOnly = true;
            }
            catch (Exception)
            {

            }
            }

        private void DateWise__Load(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                dataGridView5.Visible = false;

                UneditableGridColumn();

                dataGridView1.AutoGenerateColumns = false;
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            catch (Exception)
            {

            }
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            try
            {
            if (radDOLetter.Checked == false && radGeneralLetter.Checked == false && radCourtCaseLetter.Checked == false && radRightToInformationLetter.Checked == false && radGovtLetter.Checked == false)
            {
                MessageBox.Show("Please Select category to Search..!!");
            }
            else if (radDOLetter.Checked == true)
            {
                Search_DOLetter();
            }
            else if (radGovtLetter.Checked == true)
            {
                Search_Government_Letter();
            }
            else if (radCourtCaseLetter.Checked == true)
            {
                Search_Court_Case_Letter();
            }
            else if (radRightToInformationLetter.Checked == true)
            {
                Search_Right_To_Info_Letter();
            }
            else if (radGeneralLetter.Checked == true)
            {
                Search_General_Letter();
            }
            }
            catch (Exception)
            {

            }
        }

        // To Search Datewise function

        private void Search_DOLetter()
        {
            try
            {
                UneditableGridColumn();
                string Date = "Select Gl_No,Inward_No,Letter_No,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew  where DO_Letter='DoLetter' and Received_Date Between @p1 and @p2";
              // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
                cmd = new SqlCommand(Date, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }

                dataGridView1.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        private void Search_Government_Letter()
        {
            try
            {
                UneditableGridColumn();
                string Date = "Select Gl_No,Inward_No,Letter_No,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew  where Government_Letter='GovernmentLetter' and Received_Date Between @p1 and @p2";
                // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
                cmd = new SqlCommand(Date, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }

                dataGridView2.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        private void Search_Court_Case_Letter()
        {
            try
            {
                UneditableGridColumn();
                string Date = "Select Gl_No,Inward_No,Letter_No,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew  where Court_Case_Letter='CourtCaseLetter' and Received_Date Between @p1 and @p2";
                // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
                cmd = new SqlCommand(Date, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }

                dataGridView3.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        private void Search_Right_To_Info_Letter()
        {
            try
            {
                UneditableGridColumn();
                string Date = "Select Gl_No,Inward_No,Letter_No,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew  where Right_To_Info_Letter='RightToInfoLetter' and Received_Date Between @p1 and @p2";
                // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
                cmd = new SqlCommand(Date, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }

                dataGridView4.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

        private void Search_General_Letter()
        {
            try
            {
                UneditableGridColumn();
                string Date = "Select Gl_No,Inward_No,Letter_No,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToCaseWorker,Signature from tblReceiverNew  where General_Letter='GeneralLetter' and Received_Date Between @p1 and @p2";
                // string Date = "Select * from tblReceiverNew where Received_Date Between @p1 and @p2";
                cmd = new SqlCommand(Date, conn);
                cmd.Parameters.AddWithValue("@p1", dateTimePickerFromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@p2", dateTimePickerToDate.Value.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                }

                dataGridView5.ForeColor = Color.Black;
            }
            catch (Exception)
            {

            }
        }

     

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
            if (radDOLetter.Checked == true )
            {
                Print_DO();
            }
            else if (radGovtLetter.Checked == true)
            {
                Print_Government_Letter();
            }
            else if (radCourtCaseLetter.Checked == true)
            {
                Print_Court_Case_Letter();
            }
            else if (radRightToInformationLetter.Checked == true)
            {
                Print_Right_To_Info_Letter();
            }
            else if (radGeneralLetter.Checked == true)
            {
                Print_General_Letter();
            }
            }
            catch (Exception)
            {

            }
        }

        private void Print_DO()
        {
            try
            {
            Label lblSubtitle = new Label();
            // Label lblTypeOfLetter = new Label();
            // lblTypeOfLetter.Text = " DO Letter";

            int CurrentYear = DateTime.Today.Year;
            int PreviousYear = DateTime.Today.Year - 1;
            int NextYear = DateTime.Today.Year + 1;
            string PreYear = PreviousYear.ToString();
            string NexYear = NextYear.ToString();
            string CurYear = CurrentYear.ToString();


            if (DateTime.Today.Month > 3)
                lblSubtitle.Text = CurYear + "-" + NexYear;
            else
                lblSubtitle.Text = PreYear + "-" + CurYear;


            DGVPrinter printer = new DGVPrinter();
            printer.Title = "General Register";
            printer.SubTitle = "DO Letter : " + " " + lblSubtitle.Text;
            printer.ShowTotalPageNumber = true;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Page";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
            }
            catch (Exception)
            {

            }
        }

        private void Print_Government_Letter()
        {
            Label lblSubtitle = new Label();
            // Label lblTypeOfLetter = new Label();
            // lblTypeOfLetter.Text = " DO Letter";

            int CurrentYear = DateTime.Today.Year;
            int PreviousYear = DateTime.Today.Year - 1;
            int NextYear = DateTime.Today.Year + 1;
            string PreYear = PreviousYear.ToString();
            string NexYear = NextYear.ToString();
            string CurYear = CurrentYear.ToString();


            if (DateTime.Today.Month > 3)
                lblSubtitle.Text = CurYear + "-" + NexYear;
            else
                lblSubtitle.Text = PreYear + "-" + CurYear;


            DGVPrinter printer = new DGVPrinter();
            printer.Title = "General Register";
            printer.SubTitle = "Government Letter : " + " " + lblSubtitle.Text;
            printer.ShowTotalPageNumber = true;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Page";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView2);

        }

        private void Print_Court_Case_Letter()
        {
            try
            {
            Label lblSubtitle = new Label();
            Label lblDate = new Label();

            string date = DateTime.Now.ToString("MM/dd/yyyy");
            lblDate.Text = date.ToString();
            

            // Label lblTypeOfLetter = new Label();
            // lblTypeOfLetter.Text = " DO Letter";

            int CurrentYear = DateTime.Today.Year;
            int PreviousYear = DateTime.Today.Year - 1;
            int NextYear = DateTime.Today.Year + 1;
            string PreYear = PreviousYear.ToString();
            string NexYear = NextYear.ToString();
            string CurYear = CurrentYear.ToString();


            if (DateTime.Today.Month > 3)
                lblSubtitle.Text = CurYear + "-" + NexYear;
            else
                lblSubtitle.Text = PreYear + "-" + CurYear;


            DGVPrinter printer = new DGVPrinter();
            printer.Title = "General Register : " + " " + lblSubtitle.Text; ;
            printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Court Case Letter ";
            printer.ShowTotalPageNumber = true;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Page";
            printer.FooterSpacing = 30;
            printer.PrintDataGridView(dataGridView3);
            printer.CellAlignment = StringAlignment.Far;
            }
            catch (Exception)
            {

            }

        }

        private void Print_Right_To_Info_Letter()
        {
            Label lblSubtitle = new Label();
            // Label lblTypeOfLetter = new Label();
            // lblTypeOfLetter.Text = " DO Letter";

            int CurrentYear = DateTime.Today.Year;
            int PreviousYear = DateTime.Today.Year - 1;
            int NextYear = DateTime.Today.Year + 1;
            string PreYear = PreviousYear.ToString();
            string NexYear = NextYear.ToString();
            string CurYear = CurrentYear.ToString();


            if (DateTime.Today.Month > 3)
                lblSubtitle.Text = CurYear + "-" + NexYear;
            else
                lblSubtitle.Text = PreYear + "-" + CurYear;


            DGVPrinter printer = new DGVPrinter();
            printer.Title = "General Register";
            printer.SubTitle = "Right To Information Letter : " + " " + lblSubtitle.Text;
            printer.ShowTotalPageNumber = true;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Page";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView4);

        }

        private void Print_General_Letter()
        {
            try
            {
            Label lblSubtitle = new Label();
            // Label lblTypeOfLetter = new Label();
            // lblTypeOfLetter.Text = " DO Letter";

            int CurrentYear = DateTime.Today.Year;
            int PreviousYear = DateTime.Today.Year - 1;
            int NextYear = DateTime.Today.Year + 1;
            string PreYear = PreviousYear.ToString();
            string NexYear = NextYear.ToString();
            string CurYear = CurrentYear.ToString();


            if (DateTime.Today.Month > 3)
                lblSubtitle.Text = CurYear + "-" + NexYear;
            else
                lblSubtitle.Text = PreYear + "-" + CurYear;


            DGVPrinter printer = new DGVPrinter();
            printer.Title = "General Register";
            printer.SubTitle = "General Letter : " + " " + lblSubtitle.Text;
            printer.ShowTotalPageNumber = true;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Page";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView5);
            }
            catch (Exception)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var back = new ReportNew();
                back.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void radDOLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (radDOLetter.Checked == true)
            {
                dataGridView1.Visible = true;

                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                dataGridView5.Visible = false;

            }
            else
            {
                dataGridView1.Visible = false;

                dataGridView2.Visible = true;
                dataGridView3.Visible = true;
                dataGridView4.Visible = true;
                dataGridView5.Visible = true;
            }
            }
            catch (Exception)
            {

            }
        }

        private void radGeneralLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (radGeneralLetter.Checked == true)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;

                dataGridView5.Visible = true;

            }
            else
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                dataGridView3.Visible = true;
                dataGridView4.Visible = true;

                dataGridView5.Visible = false;
            }
            }
            catch (Exception)
            {

            }
        }

        private void radCourtCaseLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (radCourtCaseLetter.Checked == true)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;

                dataGridView3.Visible = true;

                dataGridView4.Visible = false;
                dataGridView5.Visible = false;

            }
            else
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;

                dataGridView3.Visible = false;

                dataGridView4.Visible = true;
                dataGridView5.Visible = true;
            }
            }
            catch (Exception)
            {

            }
        }

        private void radRightToInformationLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (radRightToInformationLetter.Checked == true)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;

                dataGridView4.Visible = true;

                dataGridView5.Visible = false;

            }
            else
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                dataGridView3.Visible = true;

                dataGridView4.Visible = false;

                dataGridView5.Visible = true;
            }
            }
            catch (Exception)
            {

            }
        }

        private void radGovtLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (radGovtLetter.Checked == true)
            {
                dataGridView1.Visible = false;

                dataGridView2.Visible = true;

                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                dataGridView5.Visible = false;

            }
            else
            {
                dataGridView1.Visible = true;

                dataGridView2.Visible = false;

                dataGridView3.Visible = true;
                dataGridView4.Visible = true;
                dataGridView5.Visible = true;
            }
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {

                this.dataGridView1.Rows[e.RowIndex].Cells["SlNoDO"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {

                this.dataGridView2.Rows[e.RowIndex].Cells["SlNoGovt"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {

                this.dataGridView3.Rows[e.RowIndex].Cells["SlNoCourt"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void dataGridView4_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {

                this.dataGridView4.Rows[e.RowIndex].Cells["SlNoRight"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {
                
            }
        }  

        private void dataGridView5_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {

                this.dataGridView5.Rows[e.RowIndex].Cells["SlNoGen"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
