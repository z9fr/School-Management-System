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
    public partial class editpayment : Form
    {
        public editpayment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\studentdatabase.mdf;Integrated Security=True");

        //get the student id 
        public void getstdid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select StdID from StudentTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdID", typeof(int));
            dt.Load(rdr);
            stdid.ValueMember = "StdID";
            stdid.DataSource = dt;
            con.Close();
        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void editpayment_Load(object sender, EventArgs e)
        {
            getstdid();

        }

        private void stdid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from StudentTbl where StdID=" + stdid.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter dataadd = new SqlDataAdapter(cmd);
            dataadd.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stdname.Text = dr["Student Name"].ToString();
            }
            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (feenum.Text == "" || stdid.Text == "" || stdname.Text == "" || period.Text == "" || Amount.Text == "")
                {
                    MessageBox.Show("Please Enter all the details before updating the payment ");


                }
                else
                {
                    con.Open();
                    string query = "update FeesTbl set  StdID='" + stdid.Text + "' , StdName= '" + stdname.Text + "' , Period='" + period.Text + "'  , Amount= '" + Amount.Text + "'   where FeesNumber = " + feenum.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Changed Success");
                    con.Close();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex.Message);
                this.Hide();

            }
        }
    }
}
