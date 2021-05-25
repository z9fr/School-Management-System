using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
        }
        int strtops = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            strtops += 2;
            Myprogressbar.Value = strtops;

            if(Myprogressbar.Value == 100)
            {
                Myprogressbar.Value = 0;
                timer1.Stop();
                loginpage theloginpage = new loginpage();
           
                theloginpage.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Myprogressbar_Click(object sender, EventArgs e)
        {
            Myprogressbar.ForeColor = Color.White;
            Myprogressbar.BackColor = Color.Blue;
        }

        private void Myprogressbar_progressChanged(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
