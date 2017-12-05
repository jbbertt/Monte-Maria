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
    public partial class UC_loan_sss : UserControl
    {
        Objloan_sss sss = new Objloan_sss();
        Objemployee_profiles profile = new Objemployee_profiles();
        Objmode mode = new Objmode();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public UC_loan_sss()
        {
            InitializeComponent();

            txtbox_employee = profile.GetProfiles(txtbox_employee);
            cmbox_mode =  mode.GetModeName(cmbox_mode);
            dgv_sss = sss.getViewSSSLoan(dgv_sss);
            SetGrid();
        }


        void SetGrid()
        {

            dgv_sss.Columns["employee_name"].Width = 200;
            dgv_sss.Columns["sss_loan_amount"].Width = 160;
            dgv_sss.Columns["loan_dategranted"].Width = 160;

            foreach (DataGridViewColumn col in dgv_sss.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dgv_sss = sss.getViewSSSLoan(dgv_sss);
            SetGrid();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(txtbox_employee.Text.Length > 0 & txtbox_amount_deducted.Text.Length > 0 & txtbox_sssloan.Text.Length > 0 & cmbox_mode.SelectedIndex != -1 
                & dtp_deduction_starts.Value != null & dtp_loan_granted.Value != null & txtbox_sssid.Text.Length > 0){

                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    sss.Loan_id = sss.generate_loan_id();
                    sss.Sss_loan_amount = double.Parse(txtbox_sssloan.Text);
                    sss.Loan_dategranted = dtp_loan_granted.Value;
                    sss.Loan_deduction_mode = mode.Mode_id;
                    sss.Loan_amount_deducted = double.Parse(txtbox_amount_deducted.Text);
                    sss.Loan_deduction_start = dtp_deduction_starts.Value;
                    sss.Profile_id = profile.Profile_id;
                    sss.Employee_sss_id = txtbox_sssid.Text;

                    if(sss.Insert()){
                        MessageBox.Show("New SSS Loan has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }else{
                 MessageBox.Show("Please Fill well the fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtbox_employee_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_employee.AutoCompleteCustomSource.Contains(txtbox_employee.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_employee.Text));

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
    }
}
