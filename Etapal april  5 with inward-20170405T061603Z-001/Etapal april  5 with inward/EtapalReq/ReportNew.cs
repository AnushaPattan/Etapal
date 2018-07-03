using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace EtapalUpdatedNew
{
    public partial class ReportNew : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
       // SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
       

     //   SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
      //   SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
        // SqlCommand cmd;
        public ReportNew()
        {
            InitializeComponent();
        }

        private void optDateWise_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var Datewise = new DateWiseWO();
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
                var CaseWorker = new CaseWorkerWO();
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

        private void ReportNew_Load(object sender, EventArgs e)
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
