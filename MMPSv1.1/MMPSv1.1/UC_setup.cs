using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPSv1._1
{
    public partial class UC_setup : UserControl
    {
        UC_salary_setup salary = new UC_salary_setup();
        UC_position_setup position = new UC_position_setup();
        UC_setup_department department = new UC_setup_department();

        public UC_setup()
        {
            InitializeComponent();

            salary.Name = "Salary";
            salary.Dock = DockStyle.Fill;

            position.Name = "Position";
            position.Dock = DockStyle.Fill;

            department.Name = "Department";
            department.Dock = DockStyle.Fill;

            changing_panel.Controls.Add(salary);
            changing_panel.Controls.Add(position);
            changing_panel.Controls.Add(department);

            HandleControl("Department");
        }
        void HandleControl(string cntrlName)
        {
            changing_panel.Controls[cntrlName].BringToFront();
        }

        //department button
        private void button1_Click(object sender, EventArgs e)
        {
            HandleControl("Department");
        }

        //position
        private void button2_Click(object sender, EventArgs e)
        {
            HandleControl("Position");
        }

        //salary
        private void salary_setup_Click(object sender, EventArgs e)
        {
            HandleControl("Salary");
        }


    }
}
