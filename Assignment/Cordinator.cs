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
    public partial class Cordinator : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6FMHLM\SQLEXPRESS;Initial Catalog=CCI;Integrated Security=True");
        public Cordinator()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            name.Text = string.Empty;
            id.Text = string.Empty;
            dob.Text = string.Empty;
            address.Text = string.Empty;
            contact.Text = string.Empty;
            batch.Text = string.Empty;
           coursetype.Text = string.Empty;
           admission.Text = string.Empty;
            gender.Text = string.Empty;
            branch.Text = string.Empty;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Personal_Profile(Name,Student_ID,Date_of_Admission,Address,Contact_No,Date_of_Birth,Gender,Course,Batch,Branch) Values (@Name,@Student_ID,@Date_of_Admission,@Address,@Contact_No,@Date_of_Birth,@Gender,@Course,@Batch,@Branch)", con);
            cmd.Parameters.AddWithValue("Name", name.Text);
            cmd.Parameters.AddWithValue("Student_ID", id.Text);
            cmd.Parameters.AddWithValue("Date_of_Admission", admission.Text);
            cmd.Parameters.AddWithValue("Address", address.Text);
            cmd.Parameters.AddWithValue("Contact_No", contact.Text);
            cmd.Parameters.AddWithValue("Date_of_Birth", dob.Text);
            cmd.Parameters.AddWithValue("Gender", gender.Text);
            cmd.Parameters.AddWithValue("Course", coursetype.Text);
            cmd.Parameters.AddWithValue("Batch", batch.Text);
            
            cmd.Parameters.AddWithValue("Branch", branch.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted sucessfully");
            Bind();
            Clear();
        }

        private void Bind()
        {
            con.Open();
            SqlDataAdapter das1 = new SqlDataAdapter("select * from Personal_Profile", con);
            DataTable dt1 = new DataTable();
            das1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            id.Text = string.Empty;
            dob.Text = string.Empty;
            address.Text = string.Empty;
            contact.Text = string.Empty;
            batch.Text = string.Empty;
            coursetype.Text = string.Empty;
            admission.Text = string.Empty;
            gender.Text = string.Empty;
            branch.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update  Personal_Profile set(Name=@Name,Date_of_Admission=@Date_of_Admission,Address=@Address,Contact_No=@Contact_No,Date_of_Birth=@Date_of_Birth,Gende=@Gender,Course=@Course,Batch=@Batch,Branch=@Branch) Where (Student_ID=@Student_ID)", con);
            cmd.Parameters.AddWithValue("Name", name.Text);
            cmd.Parameters.AddWithValue("Student_ID", id.Text);
            cmd.Parameters.AddWithValue("Date_of_Admission", admission.Text);
            cmd.Parameters.AddWithValue("Address", address.Text);
            cmd.Parameters.AddWithValue("Contact_No", contact.Text);
            cmd.Parameters.AddWithValue("Date_of_Birth", dob.Text);
            cmd.Parameters.AddWithValue("Gender", gender.Text);
            cmd.Parameters.AddWithValue("Course", coursetype.Text);
            cmd.Parameters.AddWithValue("Batch", batch.Text);

            cmd.Parameters.AddWithValue("Branch", branch.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated sucessfully");
            Bind();
            Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter das1 = new SqlDataAdapter("select * from Personal_Profile", con);
            DataTable dt1 = new DataTable();
            das1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
        }
        private void Clear1()
        {
            yearhigh.Text = string.Empty;
            unihigh.Text = string.Empty;
            yearhigher.Text = string.Empty;
            unihigher.Text = string.Empty;
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Acedamic_Details(Name,Student_ID,Year_of_Passing_High_School,University_of_Passing_High_School,Year_of_Passing_Higher_Secondary,University_of_Passing_Higher_Secondary) Values (@Name,@Student_ID,@Year_of_Passing_High_School,@University_of_Passing_High_School,@Year_of_Passing_Higher_Secondary,@University_of_Passing_Higher_Secondary)", con);
            cmd.Parameters.AddWithValue("Name", name1.Text);
            cmd.Parameters.AddWithValue("Student_ID", id1.Text);
            cmd.Parameters.AddWithValue("Year_of_Passing_High_School",yearhigh.Text);
            cmd.Parameters.AddWithValue("University_of_Passing_High_School", unihigh.Text);
            cmd.Parameters.AddWithValue("Year_of_Passing_Higher_Secondary", yearhigher.Text);
            cmd.Parameters.AddWithValue("University_of_Passing_Higher_Secondary", unihigher.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Submitted sucessfully");
            Bind1();
            Clear1();
        }

        private void Bind1()
        {
            con.Open();
            SqlDataAdapter das2 = new SqlDataAdapter("select * from Acedamic_Details", con);
            DataTable dt2 = new DataTable();
            das2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Acedamic_Details set Name=@Name,Year_of_Passing_High_School=@Year_of_Passing_High_School,University_of_Passing_High_School=@University_of_Passing_High_School,Year_of_Passing_Higher_Secondary=@Year_of_Passing_Higher_Secondary,University_of_Passing_Higher_Secondary=@University_of_Passing_Higher_Secondary Where (Name=@Name,Student_ID=@Student_ID)", con);
            cmd.Parameters.AddWithValue("Name", name1.Text);
            cmd.Parameters.AddWithValue("Student_ID", id1.Text);
            cmd.Parameters.AddWithValue("Year_of_Passing_High_School", yearhigh.Text);
            cmd.Parameters.AddWithValue("University_of_Passing_High_School", unihigh.Text);
            cmd.Parameters.AddWithValue("Year_of_Passing_Higher_Secondary", yearhigher.Text);
            cmd.Parameters.AddWithValue("University_of_Passing_Higher_Secondary", unihigher.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updatedted sucessfully");
            Bind1();
            Clear1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yearhigh.Text = string.Empty;
            unihigh.Text = string.Empty;
            yearhigher.Text = string.Empty;
            unihigher.Text = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter das2 = new SqlDataAdapter("select * from Acedamic_Details", con);
            DataTable dt2 = new DataTable();
            das2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            con.Close();
        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear2()
        {
            name2.Text = string.Empty;
            id2.Text = string.Empty;
            mname.Text = string.Empty;
            gd.Text = string.Empty;

            dd.Text = string.Empty;

           sub.Text = string.Empty;



        }
        private void button7_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Assignments_Submission(Student_Name,Student_Id,Module_Name,Given_Date,Due_Date,Submission) Values (@Student_Name,@Student_Id,@Module_Name,@Given_Date,@Due_Date,@Submission)", con);



            cmd.Parameters.AddWithValue("Student_Name", name2.Text);
            cmd.Parameters.AddWithValue("Student_Id", id2.Text);
            cmd.Parameters.AddWithValue("Module_Name", mname.Text);
            cmd.Parameters.AddWithValue("Given_Date", gd.Text);
            cmd.Parameters.AddWithValue("Due_Date", dd.Text);
            cmd.Parameters.AddWithValue("Submission", sub.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted sucessfully");
            Bind2();
            Clear2();
        }

        private void Bind2()
        {
            con.Open();
            SqlDataAdapter das3 = new SqlDataAdapter("select * from Assignments_Submission", con);
            DataTable dt3 = new DataTable();
            das3.Fill(dt3);
            dataGridView4.DataSource = dt3;
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter das3 = new SqlDataAdapter("select * from Assignments_Submission", con);
            DataTable dt3 = new DataTable();
            das3.Fill(dt3);
            dataGridView4.DataSource = dt3;
            con.Close();
        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }
        private void Clear3()
        {
            name3.Text = string.Empty;
            id3.Text = string.Empty;
            m1.Text = string.Empty;
            m2.Text = string.Empty;

            m3.Text = string.Empty;

            m4.Text = string.Empty;
            m5.Text = string.Empty;
            m6.Text = string.Empty;

            m7.Text = string.Empty;

           
            m9.Text = string.Empty;
            m10.Text = string.Empty;

            m11.Text = string.Empty;
            
            m12.Text = string.Empty;
            m13.Text = string.Empty;
            m14.Text = string.Empty;

            m15.Text = string.Empty;

            m16.Text = string.Empty;
            m17.Text = string.Empty;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Reults(Student_Name,Student_Id,Fundamentals_in_Computer_Systems,Introduction_to_E_Commerce,Innovation_management,Computing_project,Database_Design_and_Development,Data_Structures_and_Algorithms, Fundamentals_in_Computer_Programming) Values (@Student_Name,@Student_Id,@Fundamentals_in_Computer_Systems,@Introduction_to_E_Commerce,@Innovation_management, @Computing_project,@Database_Design_and_Development, @Data_Structures_and_Algorithms, @Fundamentals_in_Computer_Programming)", con);

            cmd.Parameters.AddWithValue("Student_Name", name3.Text);
            cmd.Parameters.AddWithValue("Student_Id", id3.Text);
            cmd.Parameters.AddWithValue("Fundamentals_in_Computer_Systems", m1.Text);
            cmd.Parameters.AddWithValue("Introduction_to_E_Commerce", m2.Text);
            cmd.Parameters.AddWithValue("Innovation_management", m3.Text);
            cmd.Parameters.AddWithValue("Computing_project", m4.Text);
            cmd.Parameters.AddWithValue("Database_Design_and_Development", m5.Text);
            cmd.Parameters.AddWithValue("Data_Structures_and_Algorithms", m6.Text);
            cmd.Parameters.AddWithValue("Fundamentals_in_Computer_Programming", m7.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Submitted sucessfully");
            Bind3();
            Clear3();
        }

        private void Bind3()
        {
            con.Open();
            SqlDataAdapter das4 = new SqlDataAdapter("select * from Reults", con);
            DataTable dt4 = new DataTable();
            das4.Fill(dt4);
            dataGridView3.DataSource = dt4;
            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter das4 = new SqlDataAdapter("select * from Reults", con);
            DataTable dt4 = new DataTable();
            das4.Fill(dt4);
            dataGridView3.DataSource = dt4;
            con.Close();
        }

        private void dob_TextChanged(object sender, EventArgs e)
        {

        }

        private void branch_TextChanged(object sender, EventArgs e)
        {

        }

        private void batch_TextChanged(object sender, EventArgs e)
        {

        }

        private void coursetype_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*con.Open();
            SqlDataAdapter das1 = new SqlDataAdapter("select * from Personal_Profile where Name= '" + txtname.Text + "'and Student_Id = '" + txtid.Text + "'", con);
            DataTable dt1 = new DataTable();
            das1.Fill(dt1);
            dataGridView5.DataSource = dt1;
            con.Close();*/

            /*con.Open();
            SqlDataAdapter das2 = new SqlDataAdapter("select * from Acedamic_Details where Name= '" + txtname.Text + "'and Student_Id = '" + txtid.Text + "'", con);
            DataTable dt2 = new DataTable();
            das2.Fill(dt2);
            dataGridView5.DataSource = dt2;
            con.Close();

                con.Open();
            SqlDataAdapter das3 = new SqlDataAdapter("select * from Assignments_Submission where Student_Name= '" + txtname.Text + "'and Student_Id = '" + txtid.Text + "'", con);
            DataTable dt3 = new DataTable();
            das3.Fill(dt3);
            dataGridView5.DataSource = dt3;
            con.Close();*/

            con.Open();
            SqlDataAdapter das4 = new SqlDataAdapter("select * from Reults where Student_Name= '" + txtname.Text + "'and Student_Id = '" + txtid.Text + "'", con);
            DataTable dt4 = new DataTable();
            das4.Fill(dt4);
            dataGridView5.DataSource = dt4;
            con.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
