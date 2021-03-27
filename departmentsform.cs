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
{using System.Data.SqlClient;
    public partial class departmentsform : Form
    {
        public departmentsform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\studentdatabase.mdf;Integrated Security=True");
        //update the table
        public void updatetableopulate()
        {
            try
            {
                con.Open();
                string query = "select * from DepartmentTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                descbox.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something Went Wrong error: "+ex);
            }
        }


        //search funtion
        public void searchfordepartment()
        {
            try
            {
                con.Open();
                string query = "select * from DepartmentTbl where DeptName='"+searchbtn.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                descbox.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong error: " + ex);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }



        private void home_Click(object sender, EventArgs e)
        {
            Mainform themainform = new Mainform();
            themainform.Show();
            this.Hide();
        }

        private void departmentsform_Load(object sender, EventArgs e)
        {
            updatetableopulate();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(dptname.Text == "" | depDesc.Text == "" | deptDuration.Text == "")
            {
                MessageBox.Show("Please Fill all The Fields Given About Before Updating Data");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into DepartmentTbl values('" + dptname.Text + "' , '" + depDesc.Text + "' , " + deptDuration.Text + ");", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Data About Department Added Successfully ");
                    con.Close();
                    updatetableopulate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Something Went Wrong error: " + ex);

                }
            }
        }

        //deleting a department
        private void delete_Click(object sender, EventArgs e)
        {
            if(dptname.Text == "")
            {
                MessageBox.Show("Please Enter all The Department Name You Want to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from DepartmentTbl where [DeptName]='"+dptname.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Deleted Successfully");
                    con.Close();
                    updatetableopulate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong error : " + ex);
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dptname.Text == "" | depDesc.Text == "" | deptDuration.Text == "")
            {
                MessageBox.Show("Please Fill all The Fields Given About Before Updating Data");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update DepartmentTbl set  [DepDesc] = '" + depDesc.Text + "' , [DepDuration ] = '" + deptDuration.Text + "' where DeptName='"+dptname.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Values Updated Successfully to " + dptname.Text);
                    updatetableopulate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong error : " + ex);

                }
            }

        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
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

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            updatetableopulate();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            searchfordepartment();
        }

        private void descbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbtn_OnValueChanged(object sender, EventArgs e)
        {
            if (searchbtn.Text == "")
            {
                updatetableopulate();
            }
            else
            {
                searchfordepartment();
            }
            
        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
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

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
