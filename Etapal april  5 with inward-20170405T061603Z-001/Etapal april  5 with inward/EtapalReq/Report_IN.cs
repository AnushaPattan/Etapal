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
using System.Configuration;

namespace EtapalReq
{
    public partial class Report_IN : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

     

        public Report_IN()
        {
            InitializeComponent();
        }

        private void optDateWise_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var Datewise = new DateWise_IN();
                Datewise.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void optCaseWorker_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var CaseWorker = new CaseWorker_IN();
                CaseWorker.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var back = new Home();
                back.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void Report_IN_Load(object sender, EventArgs e)
        {
            try
            {
                //Tooltips
                ToolTip toolTip1 = new ToolTip();

                toolTip1.SetToolTip(this.btnBack, "Back");
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            catch (Exception)
            {

            }

        }
    }
}
