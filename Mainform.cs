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

namespace CollageManagementSystem
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\studentdatabase.mdf;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void student_Click(object sender, EventArgs e)
        {
            students thestudents = new students();
            thestudents.Show();
            this.Hide();
        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            Teacher theteacher = new Teacher();
            theteacher.Show();
            this.Hide();

        }

        private void Users_Click(object sender, EventArgs e)
        {
            Users theusers = new Users();
            theusers.Show();
            this.Hide();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            departmentsform thedep = new departmentsform();
            thedep.Show();
            this.Hide();
        }

        private void Fees_Click(object sender, EventArgs e)
        {
            Fees thefee = new Fees();
            thefee.Show();
            this.Hide();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            con.Open();

            //students 
            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from StudentTbl", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            studentcount.Text = dt1.Rows[0][0].ToString();

            //teachers 
            SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from TeacherTble", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Teacherssount.Text = dt2.Rows[0][0].ToString();

            //departments
            SqlDataAdapter sda3 = new SqlDataAdapter("Select count(*) from DepartmentTbl", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            depcount.Text = dt3.Rows[0][0].ToString();
      
            //fees collected 
            SqlDataAdapter sda4 = new SqlDataAdapter("Select SUM(Amount) FROM FeesTbl", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            feeciunt.Text = dt4.Rows[0][0].ToString();
            con.Close();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
