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
using System.Configuration;


namespace EtapalReq
{
    public partial class CaseWorkerWO : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        //SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
       
        //SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
      //  SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        public CaseWorkerWO()
        {
            InitializeComponent();
        }

        // To make datagridview columns uneditable
        //private void UneditableGridColumn()
        //{
        //    try
        //    {

        //        // dataGridView2.Rows[e.RowIndex].ReadOnly = true;
        //        //  dataGridView2.Rows[e.RowIndex].ReadOnly = true;
        //        //dataGridView3.Rows[e.RowIndex].ReadOnly = true;
        //        //dataGridView4.Rows[e.RowIndex].ReadOnly = true;
        //        // dataGridView1.Rows[e.RowIndex].ReadOnly = true;
        //        //dataGridView_Lokayukta.Rows[e.RowIndex].ReadOnly = true;

        //        this. dataGridView2.Columns[0].ReadOnly = true;
        //        this. dataGridView2.Columns[1].ReadOnly = true;
        //        this. dataGridView2.Columns[2].ReadOnly = true;
        //        this. dataGridView2.Columns[3].ReadOnly = true;
        //        this. dataGridView2.Columns[4].ReadOnly = true;
        //        this. dataGridView2.Columns[5].ReadOnly = true;
        //        this. dataGridView2.Columns[6].ReadOnly = true;
        //        this. dataGridView2.Columns[7].ReadOnly = true;
        //        this. dataGridView2.Columns[8].ReadOnly = true;
        //        this. dataGridView2.Columns[9].ReadOnly = true;
        //        this. dataGridView2.Columns[10].ReadOnly = true;
        //        this. dataGridView2.Columns[11].ReadOnly = true;
                

        //        this.  dataGridView2.Columns[0].ReadOnly = true;
        //        this.  dataGridView2.Columns[1].ReadOnly = true;
        //        this.  dataGridView2.Columns[2].ReadOnly = true;
        //        this.  dataGridView2.Columns[3].ReadOnly = true;
        //        this.  dataGridView2.Columns[4].ReadOnly = true;
        //        this.  dataGridView2.Columns[5].ReadOnly = true;
        //        this.  dataGridView2.Columns[6].ReadOnly = true;
        //        this.  dataGridView2.Columns[7].ReadOnly = true;
        //        this.  dataGridView2.Columns[8].ReadOnly = true;
        //        this.  dataGridView2.Columns[9].ReadOnly = true;
        //        this.  dataGridView2.Columns[10].ReadOnly = true;
        //        this.  dataGridView2.Columns[11].ReadOnly = true;
                

        //        this.dataGridView3.Columns[0].ReadOnly = true;
        //        this.dataGridView3.Columns[1].ReadOnly = true;
        //        this.dataGridView3.Columns[2].ReadOnly = true;
        //        this.dataGridView3.Columns[3].ReadOnly = true;
        //        this.dataGridView3.Columns[4].ReadOnly = true;
        //        this.dataGridView3.Columns[5].ReadOnly = true;
        //        this.dataGridView3.Columns[6].ReadOnly = true;
        //        this.dataGridView3.Columns[7].ReadOnly = true;
        //        this.dataGridView3.Columns[8].ReadOnly = true;
        //        this.dataGridView3.Columns[9].ReadOnly = true;
        //        this.dataGridView3.Columns[10].ReadOnly = true;
        //        this.dataGridView3.Columns[11].ReadOnly = true;


        //        this.dataGridView4.Columns[0].ReadOnly = true;
        //        this.dataGridView4.Columns[1].ReadOnly = true;
        //        this.dataGridView4.Columns[2].ReadOnly = true;
        //        this.dataGridView4.Columns[3].ReadOnly = true;
        //        this.dataGridView4.Columns[4].ReadOnly = true;
        //        this.dataGridView4.Columns[5].ReadOnly = true;
        //        this.dataGridView4.Columns[6].ReadOnly = true;
        //        this.dataGridView4.Columns[7].ReadOnly = true;
        //        this.dataGridView4.Columns[8].ReadOnly = true;
        //        this.dataGridView4.Columns[9].ReadOnly = true;
        //        this.dataGridView4.Columns[10].ReadOnly = true;
        //        this.dataGridView4.Columns[11].ReadOnly = true;
                

        //        this. dataGridView1.Columns[0].ReadOnly = true;
        //        this. dataGridView1.Columns[1].ReadOnly = true;
        //        this. dataGridView1.Columns[2].ReadOnly = true;
        //        this. dataGridView1.Columns[3].ReadOnly = true;
        //        this. dataGridView1.Columns[4].ReadOnly = true;
        //        this. dataGridView1.Columns[5].ReadOnly = true;
        //        this. dataGridView1.Columns[6].ReadOnly = true;
        //        this. dataGridView1.Columns[7].ReadOnly = true;
        //        this. dataGridView1.Columns[8].ReadOnly = true;
        //        this. dataGridView1.Columns[9].ReadOnly = true;
        //        this. dataGridView1.Columns[10].ReadOnly = true;
        //        this. dataGridView1.Columns[11].ReadOnly = true;
                

        //        this.dataGridView_Lokayukta.Columns[0].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[1].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[2].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[3].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[4].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[5].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[6].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[7].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[8].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[9].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[10].ReadOnly = true;
        //        this.dataGridView_Lokayukta.Columns[11].ReadOnly = true;
                
        //        //this.  dataGridView2.Columns[13].ReadOnly = true;
        //        //this.  dataGridView2.Columns[14].ReadOnly = true;
        //        //this.  dataGridView2.Columns[15].ReadOnly = true;
        //        //this.  dataGridView2.Columns[12].ReadOnly = true;
        //        //this.  dataGridView2.Columns[13].ReadOnly = true;
        //        //this.  dataGridView2.Columns[14].ReadOnly = true;
        //        // this.  dataGridView2.Columns[15].ReadOnly = true;



        //        //this. dataGridView2.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 18);
        //        //this.  dataGridView2.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 18);
        //        //this.dataGridView3.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 18);
        //        //this.dataGridView4.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 18);
        //        //this. dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 18);
        //        //this.dataGridView_Lokayukta.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 18);

        //       //   dataGridView2.Columns["SlNo"].DisplayIndex = 0;
        //       //   dataGridView2.Columns["FromDept"].DisplayIndex = 1;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}


        private void CaseWorkerWO_Load(object sender, EventArgs e)
        {
            try
            {
                radDOLetter.Checked = true;
                  dataGridView2.Visible = false;
                 dataGridView5.Visible = false;
                
               // UneditableGridColumn();

                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                ToolTip tooltip1 = new ToolTip();
                tooltip1.SetToolTip(this.btnPrint, "Print");
                tooltip1.SetToolTip(this.btnBack, "Back to Report");
                tooltip1.SetToolTip(this.btnSearchCaseWorker, "Search");
                tooltip1.SetToolTip(this.btnBackHome, "Back to Home");

                //Load Section and Caseworker 
                SqlCommand cmd1 = new SqlCommand("select section from tblSectionManagement", conn);
                conn.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr[0].ToString();
                    ddlSection.Items.Add(name);
                }
                conn.Close();


                //add Case Worker

                SqlCommand cmd2 = new SqlCommand("select CaseWorker from tblUserMgnt", conn);
                conn.Open();
                SqlDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read())
                {
                    string name = dr1[0].ToString();
                    ddlCaseWorker.Items.Add(name);
                }

                conn.Close();
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
                    dataGridView2.Visible = true;
                     dataGridView5.Visible = false;  
                }
                else
                {
                    dataGridView2.Visible = false;
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
                      dataGridView5.Visible = true;
                     dataGridView2.Visible = false;

                }
                else
                {
                    dataGridView5.Visible = false;
                    dataGridView2.Visible = true;
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
                    dataGridView2.Visible = true;
                    dataGridView5.Visible = false; 
                    
                }
                else
                {
                    dataGridView2.Visible = false;
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
                    dataGridView2.Visible = true;
                    dataGridView5.Visible = false; 
                }
                else
                {
                    dataGridView2.Visible = false;
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
                    dataGridView2.Visible = true;
                    dataGridView5.Visible = false;     
                }
                else
                {
                    dataGridView2.Visible = false;
                    dataGridView5.Visible = true; 
                }
            }
            catch (Exception)
            {

            }
        }
        private void optLokayuktaLetter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optLokayuktaLetter.Checked == true)
                {
                    dataGridView2.Visible = true;
                    dataGridView5.Visible = false; 
                }
                else

                {
                    dataGridView2.Visible = false;
                    dataGridView5.Visible = true; 
                 }
            }
            catch (Exception)
            {

            }
        }

        private void btnSearchCaseWorker_Click(object sender, EventArgs e)
        {
            try
            {
                if (radDOLetter.Checked == false && radGeneralLetter.Checked == false && radCourtCaseLetter.Checked == false && radRightToInformationLetter.Checked == false && radGovtLetter.Checked == false && optLokayuktaLetter.Checked == false)
                {
                    MessageBox.Show("Please Select category to Search..!!");
                }
                else if ((radDOLetter.Checked == true || radGeneralLetter.Checked == true || radCourtCaseLetter.Checked == true || radRightToInformationLetter.Checked == true || radGovtLetter.Checked == true || optLokayuktaLetter.Checked == true) && (ddlCaseWorker.SelectedIndex == -1 || ddlSection.SelectedIndex == -1))
                {
                    MessageBox.Show("Please Select Both Section and CaseWorker to Search..!!");
                }
                else if (radDOLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Search_DOLetter();
                    dataGridView2.Visible = true;
                     dataGridView5.Visible = false; 
                }
                else if (radCourtCaseLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Search_Court_Case_Letter();
                      dataGridView2.Visible = true;
                      dataGridView5.Visible = false; 
                }
                else if (radRightToInformationLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Search_Right_To_Info_Letter();
                      dataGridView2.Visible = true;
                      dataGridView5.Visible = false; 
                }
                else if (radGovtLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Search_Government_Letter();
                      dataGridView2.Visible = true;
                      dataGridView5.Visible = false; 
                }
                else if (optLokayuktaLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Search_Lokayukta_ABS_Letter();
                      dataGridView2.Visible = true;
                      dataGridView5.Visible = false; 
                }
                else if (radGeneralLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Search_General_Letter();
                     dataGridView2.Visible = false;
                     dataGridView5.Visible = true; 
                }
            }
            catch (Exception)
            {

            }
        }

        private void Search_DOLetter()
        {
            try
            {
              //  UneditableGridColumn();

                // SqlCommand cmd = new SqlCommand("select Ack_No,Gl_No,Received_Date,Letter_Date,FromDept,Subject,FromOffice,ToSection,ToCaseWorker,Signature from tblReceiverNew where ToSection='" + ddlSection.Text + "' and ToCaseWorker='" + ddlCaseWorker.Text + "'", conn);
                // SqlCommand cmd = new SqlCommand("Select * from tblReceiverNew where ToSection = '" +ddlSection.Text+ "' and ToCaseWorker = '" +ddlCaseWorker.Text+"'",conn);

             
               // SqlCommand cmd = new SqlCommand("Select Gl_No_Id,Letter_No, CONVERT(varchar, Received_Date, 103) as ReceivedDate,FromDept,Subject,ToSection as ToSection ,ToCaseWorker as ToCaseWorker,Signature as SignAndDate  from tblGovernmentLetter_WO where DO_Letter='DOLetter' and ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                
              //  SqlCommand cmd = new SqlCommand("Select Subject,CONVERT(varchar, Received_Date, 103) as ReceivedDate,ToSection as ToSection ,ToCaseWorker as ToCaseWorker,Gl_No_Id,Letter_No,FromDept,Signature as SignAndDate  from tblGovernmentLetter_WO where DO_Letter='DOLetter' and ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);
                
                // imp
                SqlCommand cmd = new SqlCommand("Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection ,ToCaseWorker as ToCaseWorker,Gl_No_Id,FromDept,Letter_No,Signature as Signature from tblGovernmentLetter_WO where DO_Letter='DOLetter' and ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);


                //SqlCommand cmd = new SqlCommand("Select * from  tblReceiverNew where ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew where ToSection = '" + ddlSection.Text + "' and ToCaseWorker = '" + ddlCaseWorker.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                  dataGridView2.DataSource = dt;
               //   dataGridView2.Columns["SlNo"].DisplayIndex = 0;
               //   dataGridView2.Columns["GL Number"].DisplayIndex = 1;
               //   dataGridView2.Columns["Letetr No"].DisplayIndex = 2;
               //   dataGridView2.Columns["From Dept"].DisplayIndex = 3;
               ////   dataGridView2.Columns["ReceivedDate"].DisplayIndex = 4;
               //   dataGridView2.Columns["Subject"].DisplayIndex = 5;
               //   dataGridView2.Columns["Section"].DisplayIndex = 6;
               //   dataGridView2.Columns["CaseWorker"].DisplayIndex = 7;
               //   dataGridView2.Columns["Sign and Date"].DisplayIndex = 8;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    ddlSection.SelectedIndex = -1;
                    ddlCaseWorker.SelectedIndex = -1;
                    lblLetterDetails.Visible = false;
                }  
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the DO Letters";
                }

                  dataGridView2.ForeColor = Color.Black;
                
            }


            catch (Exception)
            {

            }
        }

        public void Search_Court_Case_Letter()
        {
            try
            {
               // UneditableGridColumn();

                // SqlCommand cmd = new SqlCommand("select Ack_No,Gl_No,Received_Date,Letter_Date,FromDept,Subject,FromOffice,ToSection,ToCaseWorker,Signature from tblReceiverNew where ToSection='" + ddlSection.Text + "' and ToCaseWorker='" + ddlCaseWorker.Text + "'", conn);
                // SqlCommand cmd = new SqlCommand("Select * from tblReceiverNew where ToSection = '" +ddlSection.Text+ "' and ToCaseWorker = '" +ddlCaseWorker.Text+"'",conn);

                //  Imp
                SqlCommand cmd = new SqlCommand("Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection ,ToCaseWorker as ToCaseWorker,Gl_No_Id,FromDept,Letter_No,Signature as Signature from tblGovernmentLetter_WO where Court_Case_Letter='CourtCaseLetter' and ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select * from  tblReceiverNew where ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew where ToSection = '" + ddlSection.Text + "' and ToCaseWorker = '" + ddlCaseWorker.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                  dataGridView2.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    ddlSection.SelectedIndex = -1;
                    ddlCaseWorker.SelectedIndex = -1;
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Court Case Letters";
                }
                  dataGridView2.ForeColor = Color.Black;
                  

            }
            catch (Exception)
            {

            }
        }

        public void Search_Right_To_Info_Letter()
        {
            try
            {
              //  UneditableGridColumn();

                // SqlCommand cmd = new SqlCommand("select Ack_No,Gl_No,Received_Date,Letter_Date,FromDept,Subject,FromOffice,ToSection,ToCaseWorker,Signature from tblReceiverNew where ToSection='" + ddlSection.Text + "' and ToCaseWorker='" + ddlCaseWorker.Text + "'", conn);
                // SqlCommand cmd = new SqlCommand("Select * from tblReceiverNew where ToSection = '" +ddlSection.Text+ "' and ToCaseWorker = '" +ddlCaseWorker.Text+"'",conn);

                //  Imp
                SqlCommand cmd = new SqlCommand("Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection ,ToCaseWorker as ToCaseWorker,Gl_No_Id,FromDept,Letter_No,Signature as Signature from tblGovernmentLetter_WO where Right_To_Info_Letter='RightToInfoLetter' and ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select * from  tblReceiverNew where ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew where ToSection = '" + ddlSection.Text + "' and ToCaseWorker = '" + ddlCaseWorker.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                  dataGridView2.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    ddlSection.SelectedIndex = -1;
                    ddlCaseWorker.SelectedIndex = -1;
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Right to Information  Letters";
                }

                  dataGridView2.ForeColor = Color.Black;
                 

            }
            catch (Exception)
            {

            }
        }

        public void Search_Government_Letter()
        {
            try
            {
               // UneditableGridColumn();

                // SqlCommand cmd = new SqlCommand("select Ack_No,Gl_No,Received_Date,Letter_Date,FromDept,Subject,FromOffice,ToSection,ToCaseWorker,Signature from tblReceiverNew where ToSection='" + ddlSection.Text + "' and ToCaseWorker='" + ddlCaseWorker.Text + "'", conn);
                // SqlCommand cmd = new SqlCommand("Select * from tblReceiverNew where ToSection = '" +ddlSection.Text+ "' and ToCaseWorker = '" +ddlCaseWorker.Text+"'",conn);

                //  Imp
                SqlCommand cmd = new SqlCommand("Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection ,ToCaseWorker as ToCaseWorker,Gl_No_Id,FromDept,Letter_No,Signature as Signature from tblGovernmentLetter_WO where Government_Letter='GovernmentLetter' and ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select * from  tblReceiverNew where ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew where ToSection = '" + ddlSection.Text + "' and ToCaseWorker = '" + ddlCaseWorker.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                  dataGridView2.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    ddlSection.SelectedIndex = -1;
                    ddlCaseWorker.SelectedIndex = -1;
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Govt Letters";
                }

                  dataGridView2.ForeColor = Color.Black;
                

            }
            catch (Exception)
            {

            }
        }

        public void Search_General_Letter()
        {
            try
            {
              //  UneditableGridColumn();

                // SqlCommand cmd = new SqlCommand("select Ack_No,Gl_No,Received_Date,Letter_Date,FromDept,Subject,FromOffice,ToSection,ToCaseWorker,Signature from tblReceiverNew where ToSection='" + ddlSection.Text + "' and ToCaseWorker='" + ddlCaseWorker.Text + "'", conn);
                // SqlCommand cmd = new SqlCommand("Select * from tblReceiverNew where ToSection = '" +ddlSection.Text+ "' and ToCaseWorker = '" +ddlCaseWorker.Text+"'",conn);

                //  Imp
                SqlCommand cmd = new SqlCommand("Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection ,ToCaseWorker as ToCaseWorker,Signature as Signature,Gl_No_Id,Letter_No,Applicant_Name from tblGeneralLetter_WO where General_Letter ='GeneralLetter' and ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select * from  tblReceiverNew where ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew where ToSection = '" + ddlSection.Text + "' and ToCaseWorker = '" + ddlCaseWorker.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                 dataGridView5.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    ddlSection.SelectedIndex = -1;
                    ddlCaseWorker.SelectedIndex = -1;
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the General Letters";
                }

                 dataGridView5.ForeColor = Color.Black;
                 

            }
            catch (Exception)
            {

            }
        }


        public void Search_Lokayukta_ABS_Letter()
        {
            try
            {
             //   UneditableGridColumn();

                // SqlCommand cmd = new SqlCommand("select Ack_No,Gl_No,Received_Date,Letter_Date,FromDept,Subject,FromOffice,ToSection,ToCaseWorker,Signature from tblReceiverNew where ToSection='" + ddlSection.Text + "' and ToCaseWorker='" + ddlCaseWorker.Text + "'", conn);
                // SqlCommand cmd = new SqlCommand("Select * from tblReceiverNew where ToSection = '" +ddlSection.Text+ "' and ToCaseWorker = '" +ddlCaseWorker.Text+"'",conn);

                //  Imp
                SqlCommand cmd = new SqlCommand("Select CONVERT(varchar, Received_Date, 103) as ReceivedDate,Subject as Subject,ToSection as ToSection ,ToCaseWorker as ToCaseWorker,Gl_No_Id,FromDept,Letter_No,Signature as Signature from tblGovernmentLetter_WO where Lokayukta_ABS_Letter='LokayuktaLetter' and ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select * from  tblReceiverNew where ToSection = N'" + ddlSection.Text + "' and ToCaseWorker = N'" + ddlCaseWorker.Text + "'", conn);

                //SqlCommand cmd = new SqlCommand("Select Gl_No,Inward_No,Letter_No,Received_Date,Letter_Date,FromDept,Other_Dept,FromOffice,Subject,ToSection,ToSubSection,ToCaseWorker,Signature from tblReceiverNew where ToSection = '" + ddlSection.Text + "' and ToCaseWorker = '" + ddlCaseWorker.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                  dataGridView2.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Document's Found");
                    ddlSection.SelectedIndex = -1;
                    ddlCaseWorker.SelectedIndex = -1;
                    lblLetterDetails.Visible = false;
                }
                else
                {
                    lblLetterDetails.Visible = true;
                    lblLetterDetails.Text = "The following are the Lokayukta/ACB Letters";
                }

                  dataGridView2.ForeColor = Color.Black;
                  

            }
            catch (Exception)
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (radDOLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Print_DO();
                }
                else if (radCourtCaseLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Print_Court_Case();
                }
                else if (radRightToInformationLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Print_Right_To_Info_Letter();
                }
                else if (radGovtLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Print_Government_Letter();
                }
                else if (optLokayuktaLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
                {
                    Print_Lokayukta_ABS_Letter();
                }
                else if (radGeneralLetter.Checked == true && ddlSection.SelectedIndex != -1 && ddlCaseWorker.SelectedIndex != -1)
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
                Label lblDate = new Label();

                string date = DateTime.Now.ToString("dd/MM/yyyy");
                lblDate.Text = date.ToString();

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
                printer.Title = "General Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : DO Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
              //  printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "DO Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView2);
            }
            catch (Exception)
            {

            }
        }

        private void Print_Court_Case()
        {
            try
            {
                Label lblSubtitle = new Label();
                Label lblDate = new Label();

                string date = DateTime.Now.ToString("dd/MM/yyyy");
                lblDate.Text = date.ToString();

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
                printer.Title = "General Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Court Case Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
              //  printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Court Case Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(  dataGridView2);

            }
            catch (Exception)
            {

            }

        }

        private void Print_Right_To_Info_Letter()
        {
            try
            {
                Label lblSubtitle = new Label();
                Label lblDate = new Label();

                string date = DateTime.Now.ToString("dd/MM/yyyy");
                lblDate.Text = date.ToString();

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
                printer.Title = "General Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Right to Information Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
              //  printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Right to Information Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(  dataGridView2);
            }
            catch (Exception)
            {

            }
        }

        private void Print_Government_Letter()
        {
            try
            {
                Label lblSubtitle = new Label();
                Label lblDate = new Label();

                string date = DateTime.Now.ToString("dd/MM/yyyy");
                lblDate.Text = date.ToString();

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
                printer.Title = "General Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Government Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                //printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Government Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(  dataGridView2);
            }
            catch (Exception)
            {

            }
        }

        private void Print_Lokayukta_ABS_Letter()
        {
            try
            {
                Label lblSubtitle = new Label();
                Label lblDate = new Label();

                string date = DateTime.Now.ToString("dd/MM/yyyy");
                lblDate.Text = date.ToString();

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
                printer.Title = "General Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : Lokayukta / ABS  Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
              //  printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Lokayukta / ABS  Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(  dataGridView2);
            }
            catch (Exception)
            {

            }
        }

        private void Print_General_Letter()
        {
            try
            {
                Label lblSubtitle = new Label();
                Label lblDate = new Label();

                string date = DateTime.Now.ToString("dd/MM/yyyy");
                lblDate.Text = date.ToString();

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
                printer.Title = "General Register : " + " " + lblSubtitle.Text;
                printer.SubTitle = "Date : " + lblDate.Text + " " + " Type of Letter : General Letters ";
                printer.ShowTotalPageNumber = true;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
               // printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "General Letter's Page";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView( dataGridView5);
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

        
      
        private void btnBackHome_Click(object sender, EventArgs e)
        {
            try
            {
                var BackHome = new Home();
                BackHome.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

       

        

        

        
        private void dataGridView2_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dataGridView2.Rows[e.RowIndex].Cells["SlNoa"].Value = Convert.ToString((e.RowIndex + 1));
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView5_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dataGridView5.Rows[e.RowIndex].Cells["SlNob"].Value = Convert.ToString((e.RowIndex + 1));
            }
            catch (Exception)
            {

            }
        }

       
       
       
             
    }
}
