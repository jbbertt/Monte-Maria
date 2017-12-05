using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using monte_marai_library;

namespace MMPSv1._1
{
    public partial class UC_reports : UserControl
    {
        UC__Payslip_generate payslip = new UC__Payslip_generate();
        public UC_reports()
        {
            InitializeComponent();

            payslip.Name = "Generate";
            payslip.Dock = DockStyle.Fill;

            changing_panel.Controls.Add(payslip);

            HandleControl("Generate");
        }
         void HandleControl(string cntrlName)
        {
            changing_panel.Controls[cntrlName].BringToFront();
        }
        
        //generate payslip button
        private void button1_Click(object sender, EventArgs e)
        {
            HandleControl("Generate");
        }
    }
}
