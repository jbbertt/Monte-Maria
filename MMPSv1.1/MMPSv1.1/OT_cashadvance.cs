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
    public partial class OT_cashadvance : UserControl
    {
        Objod_cash_advances ca = new Objod_cash_advances();
        Objmode mode = new Objmode();
        Objemployee_profiles profile = new Objemployee_profiles();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public OT_cashadvance()
        {
            InitializeComponent();

            txtbox_employeename = profile.GetProfiles(txtbox_employeename);
            dgv_ca = ca.getviewOD_CA(dgv_ca);
            SetGrid();
        }
        void SetGrid()
        {
            dgv_ca.Columns["employee_name"].Width = 200;
            dgv_ca.Columns["ca_amount"].Width = 150;
            dgv_ca.Columns["ca_granted"].Width = 150;
            dgv_ca.Columns["ca_deduction_per_payroll"].Width = 140;

            foreach (DataGridViewColumn col in dgv_ca.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            }
        }

        private void txtbox_employeename_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_employeename.AutoCompleteCustomSource.Contains(txtbox_employeename.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_employeename.Text));

                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (txtbox_employeename.Text.Length > 0 & txtbox_deduction.Text.Length > 0 & dtp_cadate.Value != null & txttbox_caamount.Text.Length > 0 &
                dtp_deduction_start.Value != null)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    ca.Ca_id = ca.generate_ca_id();
                    ca.Ca_amount = double.Parse(txttbox_caamount.Text);
                    ca.Ca_granted = dtp_cadate.Value;
                    ca.Ca_deduction_per_payroll = double.Parse(txtbox_deduction.Text);
                    ca.Profile_id = profile.Profile_id;

                    if(ca.Insert()){
                        MessageBox.Show("New Cash Advance has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insert Failure, Please check the data inputed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
