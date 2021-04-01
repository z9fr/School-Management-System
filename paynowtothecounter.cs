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
    public partial class paynowtothecounter : Form
    {
        public paynowtothecounter()
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

        public void printthething()
        {
         
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (feenum.Text == "" | stdid.Text == "" | stdname.Text == "" | period.Text == "" | Amount.Text == "")
            {
                MessageBox.Show("Please Fill all the Details about the fee before updating the database");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into FeesTbl values(" + Int32.Parse(feenum.Text) + " , " + Int32.Parse(stdid.Text) + " ,'" + stdname.Text + "' , '" + period.Text + "',  '" + Amount.Text + "');", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New payment for " + stdname.Text + " Added Successfully ");
                    con.Close();

                    //print the receipt when user add a new student 
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong error : " + ex);
                    this.Hide();
                }
            }
        }

        private void paynowtothecounter_Load(object sender, EventArgs e)
        {
            getstdid();
        }

        private void stdid_SelectedValueChanged(object sender, EventArgs e)
        {

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

        private void stdname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void period_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Amount_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen blackPen = new Pen(Color.DarkSlateGray, 3);
            Pen blacklow = new Pen(Color.AliceBlue, 2);

            Point p1 = new Point(20, 345);
            Point p2 = new Point(20, 375);

            Point p3 = new Point(0, 90);
            Point p4 = new Point(1000, 90);

            Point p5 = new Point(400, 125);
            Point p6 = new Point(400, 300);

            Point p7 = new Point(0, 500);
            Point p8 = new Point(1000, 500);

            // headder
            e.Graphics.DrawString("PAYMENT RECEIPT ", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(320, 20));

            e.Graphics.DrawString("School Management System 1.0v ", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(250, 50));
            e.Graphics.DrawLine(blacklow, p3, p4);

            e.Graphics.DrawLine(blackPen, p1, p2);

            e.Graphics.DrawLine(blacklow, p5, p6);

            e.Graphics.DrawLine(blacklow, p7, p8);



            // reciept number 
            e.Graphics.DrawString("Reciept Number ", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(200, 125));
            e.Graphics.DrawString(feenum.Text.ToString(), new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(505, 125));

            //student number 
            e.Graphics.DrawString("Student  Number ", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(200, 155));
            e.Graphics.DrawString(stdid.Text.ToString(), new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(505, 155));

            //student name
            e.Graphics.DrawString("Student Name ", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(200, 185));
            e.Graphics.DrawString(stdname.Text.ToString(), new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(505, 185));
            //period
            e.Graphics.DrawString("Period", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(200, 215));
            e.Graphics.DrawString(period.Text.ToString(), new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(505, 215));

            // price
            e.Graphics.DrawString("Price ", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(200, 245));
            e.Graphics.DrawString(Amount.Text.ToString(), new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(505, 245));


            //total 

            e.Graphics.DrawString("Total Amount  =  ", new Font("Century Gothic,", 13, FontStyle.Regular), Brushes.Black, new Point(30, 345));
            e.Graphics.DrawString(Amount.Text.ToString(), new Font("Century Gothic", 13, FontStyle.Regular), Brushes.Black, new Point(180, 345));


            //computer genarated message
            e.Graphics.DrawString("This is a computer generated recipient.", new Font("Century Gothic,", 8, FontStyle.Regular), Brushes.LightGray, new Point(300, 485));

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
