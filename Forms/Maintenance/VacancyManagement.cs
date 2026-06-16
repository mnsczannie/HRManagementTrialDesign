using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trial_hr_system.Forms.HR;

namespace trial_hr_system.Forms.Maintenance
{
    public partial class VacancyManagement : Form
    {
        public VacancyManagement()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplicantReview dash = new ApplicantReview();
            dash.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports dash = new Reports();
            dash.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HRMaintenance dash = new HRMaintenance();
            dash.Show();

            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HRLogIn login = new HRLogIn();
            login.Show();

            this.Hide();
        }
    }
}
