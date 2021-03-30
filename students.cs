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
    public partial class students : Form
    {
        public students()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\studentdatabase.mdf;Integrated Security=True");
        //update the department
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
            stddepartment.ValueMember = "DeptName";
            stddepartment.DataSource = dt;
            con.Close();
        }

        //update the table
        public void updatetableopulate()
        {
            try
            {
                con.Open();
                //updating
                string query = "select * from StudentTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                studenttablebox.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("something went wrong erro : "+ex);
            }
        }

        //search option
        public void seachoption()
        {
            try
            {
                con.Open();
                string theusertext = searchbtn.Text;
                string query = "select * from StudentTbl where [Student Name]='" + theusertext+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                studenttablebox.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("something went wrong" + ex);
            }
        }

        // students that have to 
        public void topaystudents()
        {
            try
            {
                con.Open();
                string theusertext = searchbtn.Text;
                string query = "select * from StudentTbl where [Fees] <= 0";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                studenttablebox.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("something went wrong" + ex);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            Mainform themainfrom = new Mainform();
            themainfrom.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(stdid.Text == "" | stdname.Text == "" | phone.Text == "" | stddepartment.Text == ""  )
            {
                MessageBox.Show("Please Fill all the Fileds Before Adding to the Database");
            }
            else
            {
                try
                {

                    //addning new values
                    int thestdid = Int32.Parse(stdid.Text);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl values (" + thestdid + ", '" + stdname.Text + "', '" + gender.Text + "' , '" + dateofbirth.Text + "', '" + phone.Text + "' , '" + stddepartment.Text + "');", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Student Added Successfully ");
                    con.Close();
                    updatetableopulate();
                    fulldep();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong error : "+ex);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteStudent deletethestudent = new DeleteStudent();
            deletethestudent.Show();
            updatetableopulate();
            fulldep();
        }


        private void students_Load(object sender, EventArgs e)
        {
            updatetableopulate();
            fulldep();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (stdid.Text == "" | stdname.Text == "" | phone.Text == "" | stddepartment.Text == "" )
            {
                MessageBox.Show("Please Fill all the Fileds Before Updating User to the Database");
            }
            else
            {
                try
                {
                    con.Open();
                    int thestudentid = Int32.Parse(stdid.Text);
                    string query = "update StudentTbl set [Student Name]='" + stdname.Text + "', Gender='" + gender.Text + "' , Birthday='" + dateofbirth.Text + "' , [Phone Number]='" + phone.Text + "'  , Department='" + stddepartment.Text + "'  where [StdID]=" + Int32.Parse(stdid.Text) + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Changed Successfully ");
                    con.Close();
                    updatetableopulate();
                    fulldep();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong error : " + ex);

                }
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (searchbtn.Text == "")
            {
                updatetableopulate();
            }
            else
            {
                seachoption();

            }
           

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            seachoption();

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            updatetableopulate();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            topaystudents();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are about to Log-Out for the current User. Are You Sure ?", "Log out for the Current User",
                                         MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                loginpage theloginpage = new loginpage();
                theloginpage.Show();
                this.Hide();
                
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
