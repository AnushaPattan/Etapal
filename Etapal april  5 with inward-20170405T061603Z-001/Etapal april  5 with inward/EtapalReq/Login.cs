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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //UnicodeConv_Bhoomi.UnicodeConversion uc = new UnicodeConv_Bhoomi.UnicodeConversion();
            
           
            try
            {
                if (txtUserName.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter Login Details");
                }
                else if (txtUserName.Text != "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter value for Password");
                }
                else if (txtUserName.Text == "" && txtPassword.Text != "")
                {
                    MessageBox.Show("Please enter value for UserName");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
                   // SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
       
                     // SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
                    
                  //  SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS;initial catalog=EtapalReqWO;integrated security=true");
                    //SqlConnection conn = new SqlConnection(@"data source=SOUTH-PC;initial catalog=EtapalReqWO;integrated security=true");
                    string s = "select UserName,passWord from tbllogin where UserName=@p1 and PassWord=@p2";
                    SqlCommand cmd = new SqlCommand(s, conn);
                    cmd.Parameters.AddWithValue("@p1", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        var home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName Or Password..!");
                        txtPassword.Text = "";
                        txtUserName.Text = "";
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                //PictureBox pic = new PictureBox();
                //pic.Image = new Bitmap(OpenFileDialog.);
                //pic.SizeMode = PictureBoxSizeMode.AutoSize;

                //PictureBox picture = new PictureBox
                //{
                //    Name = "pictureBox",
                //    Size = new Size(100, 50),
                //    Location = new Point(14, 17)
                //};
                //this.Controls.Add(picture);
                //picture.ImageLocation = @"C:\Users\VMD\Desktop\Perfect with try without exe\Perfect\EtapalUpdated\EtapalReq_NEW\EtapalReq\EtapalReq\Images\E1-F.png";

                //Tooltips
                ToolTip toolTip1 = new ToolTip();
                toolTip1.SetToolTip(this.btnlogin, "Login");
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
