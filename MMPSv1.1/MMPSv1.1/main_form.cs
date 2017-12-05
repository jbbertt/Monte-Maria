using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPSv1._1
{
    public partial class main_form : Form
    {
        UC_setup setup = new UC_setup();
        UC_employee employee = new UC_employee();
        UC_home home = new UC_home();
        UC_dtr time = new UC_dtr();
        UC_payroll payroll = new UC_payroll();
        UC_loan loan = new UC_loan();
        UC_reports report = new UC_reports();

        public main_form()
        {
            InitializeComponent();

            home.Name = "Home";
            home.Dock = DockStyle.Fill;

            setup.Name = "Setup";
            setup.Dock = DockStyle.Fill;

            employee.Name = "Employee";
            employee.Dock = DockStyle.Fill;

            time.Name = "Time";
            time.Dock = DockStyle.Fill;

            payroll.Name = "Payroll";
            payroll.Dock = DockStyle.Fill;

            loan.Name = "Loan";
            loan.Dock = DockStyle.Fill;

            report.Name = "Report";
            report.Dock = DockStyle.Fill;

            changing_panel.Controls.Add(home);
            changing_panel.Controls.Add(setup);
            changing_panel.Controls.Add(employee);
            changing_panel.Controls.Add(time);
            changing_panel.Controls.Add(payroll);
            changing_panel.Controls.Add(loan);
            changing_panel.Controls.Add(report);

            HandleControl("Home");

        }
        void HandleControl(string cntrlName)
        {
            changing_panel.Controls[cntrlName].BringToFront();
        }

        //setup button 
        private void button1_Click(object sender, EventArgs e)
        {
            HandleControl("Setup");
        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            HandleControl("Employee");
        }

        //home
        private void button2_Click(object sender, EventArgs e)
        {
            HandleControl("Home");
        }

        //time record
        private void dtr_Click(object sender, EventArgs e)
        {
            HandleControl("Time");
        }

        private void btn_patroll_Click(object sender, EventArgs e)
        {
            HandleControl("Payroll");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleControl("Loan");
        }

        //report button
        private void button3_Click(object sender, EventArgs e)
        {
            HandleControl("Report");
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                new login().ShowDialog();
                this.Close();
            }
            else
            {

            }
        }
    }
}
