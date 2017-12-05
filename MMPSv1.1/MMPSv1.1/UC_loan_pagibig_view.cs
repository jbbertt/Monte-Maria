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
using System.Globalization;

namespace MMPSv1._1
{
    public partial class UC_loan_pagibig_view : UserControl
    {
        Objloan_pagibig pagibig = new Objloan_pagibig();
        Objemployee_profiles profile = new Objemployee_profiles();
        Objmode mode = new Objmode();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public UC_loan_pagibig_view()
        {
            InitializeComponent();

            txtbox_empname = profile.GetProfiles(txtbox_empname);
        }

        //walay labot
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //view all ni
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dgv_view = pagibig.getViewallPagibigLoan(dgv_view);
            SetGrid();
        }
        void SetGrid()
        {

            dgv_view.Columns["employee_name"].Width = 160;
            dgv_view.Columns["loan_amount"].Width = 150;
            dgv_view.Columns["loan_granted"].Width = 150;
            dgv_view.Columns["loan_deduction_amount"].Width = 150;
            dgv_view.Columns["loan_deduction_starts"].Width = 150;
            dgv_view.Columns["employee_pagibig_id"].Width = 150;
            dgv_view.Columns["deduction_mode"].Width = 120;

            foreach (DataGridViewColumn col in dgv_view.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_empname.AutoCompleteCustomSource.Contains(txtbox_empname.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_empname.Text));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtbox_empname.Text.Length > 0){

                pagibig.Profile_id = profile.Profile_id;
                dgv_view = pagibig.getViewSearchPagibigLoan(dgv_view);
                SetGrid();

            }
            else
            {
                MessageBox.Show("Please Enter a name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
