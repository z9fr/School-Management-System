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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\studentdatabase.mdf;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Mainform themainui = new Mainform();
            // themainui.Show();
            //this.Hide();

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTable where UserName = '" + username.Text + "' and password = '" + password.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows[0][0].ToString() == "1")
                {
                    themainui.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("The User Name or Password is Wrong Please Try Agian ");
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something Went Wrong error : "+ex);
            }
            

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }
    }
}
