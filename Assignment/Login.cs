using Assignment;
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
namespace Assignment
{
    public partial class LOGIN : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PNRBN04\SQLEXPRESS;Initial Catalog=WAD;Persist Security Info=True;User ID=pencil;Password=***********");

        public LOGIN()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusername.Text == "admin" || txtpw.Text == "admin123")
            {
                MessageBox.Show(" Login Successful for the Admin");

                Visible = false;
                CreateUser frm = new CreateUser();
                LOGIN Log = new LOGIN();
                frm.Show();
            }

            else if (txtusername.Text == "cordinator" || txtpw.Text == "cor123")
            {
                MessageBox.Show(" Login Successful for the Cordinator");

                Visible = false;
                Cordinator frm = new Cordinator();
                LOGIN Log = new LOGIN();
                frm.Show();
            }

            else if (txtusername.Text == "student" || txtpw.Text == "student")
            { 

                MessageBox.Show(" Login Successful for the Student");


                Visible = false;
                Student frm = new Student();
                LOGIN Log = new LOGIN();
                frm.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}