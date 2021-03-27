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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\studentdatabase.mdf;Integrated Security=True");
        //updating tables
        public void updatetable()
        {
            con.Open();
            string query = "select * from FeesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            feedetails.DataSource = ds.Tables[0];
            con.Close();
            
        }

        //search funtion 
        public void thesearchfuntion()
        {
            con.Open();
            string query = "select * from FeesTbl where StdName='"+searchbtn.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            feedetails.DataSource = ds.Tables[0];
            con.Close();

        }

        private void home_Click(object sender, EventArgs e)
        {
            Mainform themainform = new Mainform();
            this.Hide();
            themainform.Show();
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            updatetable();
        }

        private void add_Click(object sender, EventArgs e)
        {
            paynowtothecounter paynow = new paynowtothecounter();
            paynow.Show();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

            editpayment editthepayment = new editpayment();
            editthepayment.Show();
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
            updatetable();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            thesearchfuntion();
        }

        private void searchbtn_OnValueChanged(object sender, EventArgs e)
        {
            if(searchbtn.Text == "")
            {
                updatetable();
            }
            else
            {
                thesearchfuntion();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deletepayment deletethepayment = new deletepayment();
            deletethepayment.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
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

            Point p7 = new Point(0 , 500);
            Point p8 = new Point(1000 , 500);

            // headder
            e.Graphics.DrawString("PAYMENT RECEIPT ", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(320 , 20));

            e.Graphics.DrawString("School Management System 1.0v ", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(250, 50));
            e.Graphics.DrawLine(blacklow, p3, p4);
            
            e.Graphics.DrawLine(blackPen,p1, p2);

            e.Graphics.DrawLine(blacklow, p5, p6);

            e.Graphics.DrawLine(blacklow, p7, p8);


            // reciept number 
            e.Graphics.DrawString("Reciept Number ", new Font("Century Gothic", 10 , FontStyle.Regular), Brushes.Black, new Point(200, 125));
            e.Graphics.DrawString(feedetails.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(505, 125));

            //student number 
            e.Graphics.DrawString("Student  Number ", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(200, 155));
            e.Graphics.DrawString(feedetails.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(505, 155));

            //student name
            e.Graphics.DrawString("Student Name ", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(200, 185));
            e.Graphics.DrawString(feedetails.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(505, 185));
            //period
            e.Graphics.DrawString("Perioud", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(200, 215));
            e.Graphics.DrawString(feedetails.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(505, 215));

            // price
            e.Graphics.DrawString("Price ", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(200, 245));
            e.Graphics.DrawString(feedetails.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(505, 245));


            //total 

            e.Graphics.DrawString("Total Amount  =  ", new Font("Century Gothic,", 13, FontStyle.Regular), Brushes.Black, new Point(30, 345));
            e.Graphics.DrawString(feedetails.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century Gothic", 13, FontStyle.Regular), Brushes.Black, new Point(180, 345));


            //computer genarated message
            e.Graphics.DrawString("This is a computer generated recipient.", new Font("Century Gothic,", 8, FontStyle.Regular), Brushes.LightGray, new Point(300, 485));
        }

        private void feedetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
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
    }
}
