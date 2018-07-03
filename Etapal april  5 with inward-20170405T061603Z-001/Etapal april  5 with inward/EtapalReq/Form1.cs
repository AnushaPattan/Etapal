using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EtapalReq
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=VMD-PC\SQLEXPRESS; initial catalog=EtapalReq; integrated Security=true;");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "if @p1 is null" +
                            " Insert into tblSample(Sample) values(Default)"+
                            "else" +
                            " Insert into tblSample(Sample) values(@p1)";

            cmd = new SqlCommand(str,conn);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
               // insert into table1 values (5, DEFAULT, 10, DEFAULT)
            conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Success");
                }
                conn.Close();
            }
        }
    }

