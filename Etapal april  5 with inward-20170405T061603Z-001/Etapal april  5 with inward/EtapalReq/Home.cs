using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using EtapalUpdatedNew;
using EtapalReq;

using System.Data.SqlClient;

using System.Configuration;

namespace EtapalReq
{
    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
       

        public Home()
        {
            InitializeComponent();
        }


        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                btnAddDepartment.Visible = false;
                btnSectionManagement.Visible = false;
                btnUserManagement.Visible = false;

                btnGeneralLetter.Visible = false;
                btnGovtLetter.Visible = false;
                btnSearchGeneral.Visible = false;
                btnSearchGov.Visible = false;
               
                btnEditCourt.Visible = false;
                btnGovt.Visible = false;
                btnModifySection.Visible = false;


                //Tooltips
                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnManagement, "Click to select Management");
                toolTip1.SetToolTip(this.btnReceive, "Click to select type of Receive Letter");
                toolTip1.SetToolTip(this.btnSearch, "Click to select type of Letter for Search");
                toolTip1.SetToolTip(this.bnReport, "Report");
                //toolTip1.SetToolTip(this.btnManagement, "Click to select Management");
                toolTip1.SetToolTip(this.btnSectionManagement, "Section and Subsection Management");
                toolTip1.SetToolTip(this.btnUserManagement, "User/Caseworker Management");
                toolTip1.SetToolTip(this.btnExit, "Exit");
                toolTip1.SetToolTip(this.btnGeneralLetter, "General Letter's");
                toolTip1.SetToolTip(this.btnGovtLetter, "Government Letters");
                toolTip1.SetToolTip(this.btnAddDepartment, "Add Department");
                toolTip1.SetToolTip(this.btnSearchGeneral, "Search General Letter's");
                toolTip1.SetToolTip(this.btnSearchGov, "Search Government Letters");

                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            catch (Exception)
            {
            }

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGeneralLetter.Visible == true && btnGovtLetter.Visible == true)
                {
                    btnGeneralLetter.Visible = false;
                    btnGovtLetter.Visible = false;
                }
                else
                {
                    btnGeneralLetter.Visible = true;
                    btnGovtLetter.Visible = true;
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
                if (btnSearchGeneral.Visible == true && btnSearchGov.Visible == true)
                {
                    btnSearchGeneral.Visible = false;
                    btnSearchGov.Visible = false;
                   
                }
                else
                {
                    btnSearchGeneral.Visible = true;
                    btnSearchGov.Visible = true;
                   
                }
            }
            catch (Exception)
            {
            }
        }

        private void bnReport_Click(object sender, EventArgs e)
        {
            try
            {
                var Search = new Report_IN();
                Search.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
            //try
            //{
            //    var Search = new Report_IN();
            //    Search.Show();
            //    this.Hide();
            //}
            //catch (Exception)
            //{

            //}

        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (btnSectionManagement.Visible == true && btnUserManagement.Visible == true && btnAddDepartment.Visible == true && btnModifySection.Visible == true)
                {
                    btnSectionManagement.Visible = false;
                    btnUserManagement.Visible = false;
                    btnAddDepartment.Visible = false;
                    btnModifySection.Visible = false;
                }
                else
                {
                    btnSectionManagement.Visible = true;
                    btnUserManagement.Visible = true;
                    btnAddDepartment.Visible = true;
                    btnModifySection.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            try
            {
                var UserManagement = new UserManagement();
                UserManagement.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnSectionManagement_Click(object sender, EventArgs e)
        {
            try
            {
                var SectionManagement = new SectionSubsectionManagement();
                SectionManagement.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                var Exit = new Login();
                Exit.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnGeneralLetter_Click(object sender, EventArgs e)
        {
            try
            {
                var General = new CourtCaseLetter_IN();
                General.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnGovtLetter_Click(object sender, EventArgs e)
        {
            try
            {
                var Govt = new GovtLetters_IN();
                Govt.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        //private void btnAddDepartment_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var AddDepartment = new Department_Add();
        //        AddDepartment.Show();
        //        this.Hide();
        //    }
        //    catch (Exception)
        //    {

        //    }

        //}

        private void btnSearchGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                var SearchGeneral = new SearchCourtCase_IN();
                SearchGeneral.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnSearchGov_Click(object sender, EventArgs e)
        {
            try
            {
                var SearchGov = new SearchGovernment_IN();
                SearchGov.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnAddDepartment_Click_1(object sender, EventArgs e)
        {
            try
            {
                var AddDept = new Department_Add();
                AddDept.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnReAssignment_Click(object sender, EventArgs e)
        {
            try
            {
                var ChangeCaseWorker = new ChangeCaseWorker();
                ChangeCaseWorker.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

    

        private void btnEditCourt_Click(object sender, EventArgs e)
        {
            try
            {
                var EditCourt = new EditCourtCaseLetter();
                EditCourt.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnGovt_Click(object sender, EventArgs e)
        {
            try
            {
                var EditGovt = new EditGovtLetter();
                EditGovt.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditCourt.Visible == true && btnGovt.Visible == true)
                {
                    btnEditCourt.Visible = false;
                    btnGovt.Visible = false;
                }
                else
                {
                    btnEditCourt.Visible = true;
                    btnGovt.Visible = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnModifySection_Click(object sender, EventArgs e)
        {
            try
            {
                var ModifySection = new CaseSecSubSec();
                ModifySection.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }

        }

    }
}
