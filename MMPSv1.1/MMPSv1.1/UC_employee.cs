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
    public partial class UC_employee : UserControl
    {
        UC_employee_list list = new UC_employee_list();
        UC_employee_otherDeductions profiling = new UC_employee_otherDeductions();
        public UC_employee()
        {
            InitializeComponent();

            list.Name = "List";
            list.Dock = DockStyle.Fill;

            profiling.Name = "Resignation";
            profiling.Dock = DockStyle.Fill;



            em_changing_panel.Controls.Add(list);
            em_changing_panel.Controls.Add(profiling);

            HandleControl("List");
        }
        void HandleControl(string cntrlName)
        {
            em_changing_panel.Controls[cntrlName].BringToFront();
        }

        //List button click
        private void button1_Click(object sender, EventArgs e)
        {
            HandleControl("List");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //HandleControl("Profiling");
           new Add_employee_form().ShowDialog();
        }

        private void resignation_btn_Click(object sender, EventArgs e)
        {
            HandleControl("Resignation");
        }

        //add dependents button
        private void button3_Click(object sender, EventArgs e)
        {
            new Add_dependents().ShowDialog();
            
        }

    }
}
