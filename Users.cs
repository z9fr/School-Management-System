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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\studentdatabase.mdf;Integrated Security=True");
        private void home_Click(object sender, EventArgs e)
        {
            Mainform themainform = new Mainform();
            themainform.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userid_OnValueChanged(object sender, EventArgs e)
        {
        }

        public void populate()
        {
            con.Open();
            string query = "select Userid , UserName  from Usertable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            theaddbaluebox.DataSource = ds.Tables[0];
            con.Close();

        }

        //search funtion 

        public void searchfuntion()
        {
            con.Open();
            string query = "select * from Usertable Where UserName='"+searchbtn.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            theaddbaluebox.DataSource = ds.Tables[0];
            con.Close();

        }
        

        // adding the user 

        private void add_Click(object sender, EventArgs e)
        {
                try
                {
                    if (userid.Text == "" || username.Text == "" || passw.Text == "")
                    {
                        MessageBox.Show("Please Fill all the informaiton");


                    }
                    else
                    {
                        int theuserid = Int32.Parse(userid.Text);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into UserTable ([Userid], [UserName], [password]) values ( "+theuserid+", '"+username.Text+"' , '"+passw.Text+"');", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Added Success");
                        con.Close();
                        populate();
                    }
        

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Something went wrong" + ex.Message);

                }
            

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userid.Text = theaddbaluebox.SelectedRows[0].Cells[0].Value.ToString();
            username.Text = theaddbaluebox.SelectedRows[0].Cells[1].Value.ToString();
            passw.Text = theaddbaluebox.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(userid.Text == "" )
                {
                    MessageBox.Show("Enter User Name");
                }
                else
                {
                    con.Open();
                    string query = "delete from UserTable where Userid=" + userid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Success");
                    con.Close();
                    populate();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went Wrong " + ex.Message);

            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            ChangePassword changemypassword = new ChangePassword();
            changemypassword.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void searchbtn_OnValueChanged(object sender, EventArgs e)
        {
           if(searchbtn.Text == "")
            {
                populate();
            }
            else
            {
                searchfuntion();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
