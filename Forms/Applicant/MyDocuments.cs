using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial_hr_system.Forms.Applicant
{
    public partial class MyDocuments : Form
    {
        public MyDocuments()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JobVacancies dash = new JobVacancies();
            dash.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyApplication dash = new MyApplication();
            dash.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ApplicationStatus dash = new ApplicationStatus();
            dash.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyProfile dash = new MyProfile();
            dash.Show();

            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();

            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }
    }
}
