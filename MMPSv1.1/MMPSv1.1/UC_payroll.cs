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
    public partial class UC_payroll : UserControl
    {
        UC_payroll_viewpayroll view = new UC_payroll_viewpayroll();
        UC_payroll_compute com = new UC_payroll_compute();
        public UC_payroll()
        {
            InitializeComponent();

            view.Name = "View";
            view.Dock = DockStyle.Fill;

            com.Name = "Com";
            com.Dock = DockStyle.Fill;

            changing_panel.Controls.Add(view);
            changing_panel.Controls.Add(com);

            HandleControl("Com");
        }
        void HandleControl(string cntrlName)
        {
            changing_panel.Controls[cntrlName].BringToFront();
        }

        //compute button
        private void button1_Click(object sender, EventArgs e)
        {
            HandleControl("Com");
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            HandleControl("View");
        }


    }
}
