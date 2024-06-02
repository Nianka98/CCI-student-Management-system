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
    public partial class Student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6FMHLM\SQLEXPRESS;Initial Catalog=CCI;Integrated Security=True");
        public Student()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter das1 = new SqlDataAdapter("select * from Personal_Profile where Name= '" + txtname.Text + "'and Student_Id = '" + txtid.Text + "'", con);
            DataTable dt1 = new DataTable();
            das1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter das2 = new SqlDataAdapter("select * from Acedamic_Details where Name= '" + txtname.Text + "'and Student_Id = '" + txtid.Text + "'", con);
            DataTable dt2 = new DataTable();
            das2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter das3 = new SqlDataAdapter("select * from Assignments_Submission where Student_Name= '" + txtname.Text + "'and Student_Id = '" + txtid.Text + "'", con);
            DataTable dt3 = new DataTable();
            das3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter das4 = new SqlDataAdapter("select * from Reults where Student_Name= '" + txtname.Text + "'and Student_Id = '" + txtid.Text + "'", con);
            DataTable dt4 = new DataTable();
            das4.Fill(dt4);
            dataGridView1.DataSource = dt4;
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
