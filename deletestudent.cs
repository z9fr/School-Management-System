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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\studentdatabase.mdf;Integrated Security=True");

        private void delete_Click(object sender, EventArgs e)
        {
            if (stdid.Text == "")
            {
                MessageBox.Show("Please Enter The Teacher ID to be Removed");
            }
            try
            {
                con.Open();
                string query = "delete from StudentTbl where [StdID]=" + stdid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Removed Successfully ");
                con.Close();
                this.Hide();

            }
            catch (Exception ec)
            {
                MessageBox.Show("Something Went Wrong error :" + ec);
                this.Hide();
            }

        }

        private void stdname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void stdid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
