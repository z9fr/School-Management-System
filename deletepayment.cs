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
    public partial class deletepayment : Form
    {
        public deletepayment()
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


        private void stdname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void feenum_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void stdid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deletepayment_Load(object sender, EventArgs e)
        {
            getstdid();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(feenum.Text == "")
            {
                MessageBox.Show("Please Enter the Fee Number ");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from FeesTbl where [FeesNumber]=" + feenum.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Deleted Successfully");
                    con.Close();
                    this.Hide();
                }
                catch (Exception ec)
                {
                    MessageBox.Show("Something Went Wrong error :" + ec);
                    this.Hide();
                }
            }
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
    }
}
