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
    public partial class UC_loan_pagibig : UserControl
    {
        Objloan_pagibig pagibig = new Objloan_pagibig();
        Objemployee_profiles profile = new Objemployee_profiles();
        Objmode mode = new Objmode();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        public UC_loan_pagibig()
        {
            InitializeComponent();

            txtbox_name = profile.GetProfiles(txtbox_name);
            cmbox_mode = mode.GetModeName(cmbox_mode);

            dtv_pagibig = pagibig.getViewPagibigLoan(dtv_pagibig);
            SetGrid();
        }

        void SetGrid()
        {

            dtv_pagibig.Columns["employee_name"].Width = 190;
            dtv_pagibig.Columns["loan_amount"].Width = 150;
            dtv_pagibig.Columns["loan_granted"].Width = 150;

            foreach (DataGridViewColumn col in dtv_pagibig.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
                
            }
        }
        private void txtbox_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_name.AutoCompleteCustomSource.Contains(txtbox_name.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_name.Text));

                }
            }
        }

        private void cmbox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_mode.SelectedIndex != -1)
            {
                mode.Mode_desc = cmbox_mode.Text;
                mode.Mode_id = mode.GetModeId();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(txtbox_name.Text.Length > 0 & txtbox_deduction.Text.Length > 0 & txtbox_amount.Text.Length > 0 & cmbox_mode.SelectedIndex != -1 & dtp_pagibigloan.Value != null
                & dtp_start.Value != null & txtbox_pagid.Text.Length > 0){

                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    pagibig.Pagibig_loan_id = pagibig.generate_pagibig_loan_id();
                    pagibig.Profile_id = profile.Profile_id;
                    pagibig.Loan_amount = double.Parse(txtbox_amount.Text);
                    pagibig.Loan_granted = dtp_pagibigloan.Value;
                    pagibig.Loan_deduc_mode = mode.Mode_id;
                    pagibig.Loan_deduction_amount = double.Parse(txtbox_deduction.Text);
                    pagibig.Loan_deduction_starts = dtp_start.Value;
                    pagibig.Employee_pagibig_id = txtbox_pagid.Text;

                    if(pagibig.Insert()){
                        MessageBox.Show("New Pagibig Loan has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtbox_amount.Clear();
                        txtbox_name.Clear();
                        txtbox_deduction.Clear();
                    }
                }
                }
            else
            {
                MessageBox.Show("Please Fill well the fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dtv_pagibig = pagibig.getViewPagibigLoan(dtv_pagibig);
            SetGrid();
        }


    }
}
