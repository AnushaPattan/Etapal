using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EtapalUpdatedNew;

namespace EtapalReq
{
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
        }

        

        private void radReceive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var Receive = new Receive_();
                Receive.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
           // radReceive.AutoCheck = false;
        }

        private void radSearch_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var Search = new Search();
                Search.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
            //radReceive.AutoCheck = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    var Report = new SectionManagement();
                    Report.Show();
                    this.Hide();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    var Report = new UserManagement();
                    Report.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

            }
        }

        private void radReport_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                var Report = new ReportNew();
                Report.Show();
                this.Hide();

            }
            catch (Exception)
            {

            }
        }

        private void Home1_Load(object sender, EventArgs e)
        {
            try
            {
                //comboBox1.Items.Insert(0, "Please select any value");

                //Tooltips
                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.comboBox1, "Click to Select Management");
                this.WindowState = FormWindowState.Maximized;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var Report = new Login();
                Report.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
