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
    public partial class UC_loan : UserControl
    {
        UC_loan_pagibig pagibig = new UC_loan_pagibig();
        UC_loan_pagibig_view viewpag = new UC_loan_pagibig_view();
        UC_loan_sss sss = new UC_loan_sss();
        UC_loan_sss_view vsss = new UC_loan_sss_view();

        public UC_loan()
        {
            InitializeComponent();

            sss.Name = "SSS";
            sss.Dock = DockStyle.Fill;

            vsss.Name = "Vsss";
            vsss.Dock = DockStyle.Fill;

            pagibig.Name = "PAGIBIG";
            pagibig.Dock = DockStyle.Fill;

            viewpag.Name = "Viewpag";
            viewpag.Dock = DockStyle.Fill;


            pan.Controls.Add(sss);
            pan.Controls.Add(vsss);
            pan.Controls.Add(pagibig);
            pan.Controls.Add(viewpag);
 

            HandleControl("SSS");

        }
        void HandleControl(string cntrlName)
        {
            pan.Controls[cntrlName].BringToFront();
        }

        //sss loan
        private void button1_Click(object sender, EventArgs e)
        {
            HandleControl("SSS");
        }

        private void btn_view_sss_Click(object sender, EventArgs e)
        {
            HandleControl("Vsss");
        }

        private void pagibig_loan_Click(object sender, EventArgs e)
        {
            HandleControl("PAGIBIG");
        }

        private void btn_view_pagibig_Click(object sender, EventArgs e)
        {
            HandleControl("Viewpag");
        }


    }
}
