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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\studentdatabase.mdf;Integrated Security=True");
        //fill department

        public void fulldep()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select DeptName  from DepartmentTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DeptName", typeof(string));
            dt.Load(rdr);
            department.ValueMember = "DeptName";
            department.DataSource = dt;
            con.Close();

        }

        //update the table
        public void pupdatetableopulate()
        {
            try
            {
                con.Open();
                string query = "select * from TeacherTble";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                teachertablesbox.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {
                MessageBox.Show("something went wrong");
            }
        }

        //search for a teacher
        public void searchforteacher()
        {
            try
            {
                con.Open();
                string query = "select * from TeacherTble where [Teacher Name]='"+searchbtn.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                teachertablesbox.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {
                MessageBox.Show("something went wrong");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Mainform themainform = new Mainform();
            themainform.Show();
            this.Hide();
        }

        private void teacherid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void theaddbaluebox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherid.Text = teachertablesbox.SelectedRows[0].Cells[0].Value.ToString();
            teachername.Text = teachertablesbox.SelectedRows[0].Cells[1].Value.ToString();
            gender.Text = teachertablesbox.SelectedRows[0].Cells[2].Value.ToString();
            dob.Text = teachertablesbox.SelectedRows[0].Cells[3].Value.ToString();
            phone.Text = teachertablesbox.SelectedRows[0].Cells[4].Value.ToString();
            department.Text = teachertablesbox.SelectedRows[0].Cells[5].Value.ToString();
            address.Text = teachertablesbox.SelectedRows[0].Cells[6].Value.ToString();
        }

    
        //adding a new Teacher
        private void add_Click(object sender, EventArgs e)
        {
            if (teacherid.Text == "" | phone.Text == "" | teachername.Text == "" | department.Text =="" | address.Text == "" | dob.Text == "" | gender.Text == "" )
            {
                MessageBox.Show("Please Fill All the Fields");
            }
            else
            {
                try
                {
                    int theteacherid = Int32.Parse(teacherid.Text);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TeacherTble ([Teacher ID ], [Teacher Name], [TeacherGender] , [BirthDay], [PhoneNumber] , [Department] , [Address]) values ( " + theteacherid + ", '" + teachername.Text + "' ,  '" + gender.Text + "' ,  '" + dob.Text + "' ,  '" + phone.Text + "' ,  '" + department.Text + "' ,   '" + address.Text + "');", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Added Success");
                    con.Close();
                    pupdatetableopulate();
                    fulldep();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong" + ex.Message);

                }
            }


        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            pupdatetableopulate();
            fulldep();
        }

        private void edit_Click(object sender, EventArgs e)
        {

            if (teacherid.Text == "" | phone.Text == "" | teachername.Text == "" | department.Text == "" | address.Text == "" | dob.Text == "" | gender.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields");
            }
            else
            {
                try
                {
                    con.Open();
                    int theuserid = Int32.Parse(teacherid.Text);
                    string query = "update TeacherTble set [Teacher Name]='" + teachername.Text + "', TeacherGender='" + gender.Text + "' , BirthDay='" + dob.Text + "' , PhoneNumber='" + phone.Text + "'  , Department='" + department.Text + "'     , Address='" + address.Text + "'   where [Teacher ID ]=" + Int32.Parse(teacherid.Text) + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Changed Successfully ");
                    con.Close();
                    fulldep();
                    pupdatetableopulate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Something Went Wrong error : " + ex);

                }

            }
         
        }

        //deleting a teacher
        private void delete_Click(object sender, EventArgs e)
        {
            if(teacherid.Text == "")
            {
                MessageBox.Show("Please Enter The Teacher ID to be Removed");
            }
            try
            {
                con.Open();
                string query = "delete from TeacherTble where [Teacher ID ]=" + teacherid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Removed Success");
                con.Close();
                pupdatetableopulate();
                fulldep();
            }
            catch(Exception ec)
            {
                MessageBox.Show("Something Went Wrong error :" + ec);
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are about to Log-Out for the current User. Are You Sure ?", "Log out for the Current User",
                             MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                loginpage theloginpage = new loginpage();
                theloginpage.Show();
                this.Hide();

            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            pupdatetableopulate();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            searchforteacher();
        }

        private void searchbtn_OnValueChanged(object sender, EventArgs e)
        {
            if(searchbtn.Text == "")
            {
                pupdatetableopulate();
            }
            else
            {
                searchforteacher();
            }
            
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“School Management System”\n\n" +
    "This is a opensource school management system using C#. This application has a simple User interface, "
    + "Fast and easy to use for anyone. To find the documentation of this project please go to (https://github.com/d4az ). "
    + "\n\nQuick Documentation \n\n"
    + "In this application you can different tabs that you can go to in each of the tabs you can add remove or edit things related to that tab. Also, the software provides you the thing like search function, refresh, and logout.\n\n "
    + "The buttons for search refresh and logout can be seen in blue color in each section.\n\n "
    + "\n\n In the Dashboard section you can see the state of the school now, in that section you can see the all the students, teachers, departments in the school and all the fees collected will be displayed in the dashboard."
    + "\n\nWhen we go to the fees tab there’s option to pay. In that option you can basically add new payments to the students and whenever you pay the software will issue a receipt. Also, you can get the receipts for each transaction by just clicking on the student’s name in the Fee Details section. "
    + "\n\nIn the user section you can add a new user of just change the password. ");
        }
    }
}
