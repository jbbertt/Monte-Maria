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
    public partial class OT_uniform : UserControl
    {
        Objod_uniform uniform = new Objod_uniform();
        Objmode mode = new Objmode();
        Objemployee_profiles profile = new Objemployee_profiles();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        public OT_uniform()
        {
            InitializeComponent();

            txtbox_employee_name = profile.GetProfiles(txtbox_employee_name);
            cmbox_mode = mode.GetModeName(cmbox_mode);
            dgv_uniform = uniform.getviewOD_Uniform(dgv_uniform);
            SetGrid();
        }
        void SetGrid()
        {
            dgv_uniform.Columns["employee_name"].Width = 200;
            dgv_uniform.Columns["ca_amount"].Width = 150;
            dgv_uniform.Columns["ca_granted"].Width = 150;
            dgv_uniform.Columns["ca_deduction_per_payroll"].Width = 140;

            foreach (DataGridViewColumn col in dgv_uniform.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
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

        private void txtbox_employee_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_employee_name.AutoCompleteCustomSource.Contains(txtbox_employee_name.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_employee_name.Text));

                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (txtbox_employee_name.Text.Length > 0 & txtbox_amount.Text.Length > 0 & dtp_dategranted.Value != null & cmbox_mode.SelectedIndex != -1 & 
                dtp_deduction_start.Value != null & txtbox_amount_deduction.Text.Length > 0)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {

                    uniform.Uniform_id = uniform.generate_uniform_id();
                    uniform.Amount = double.Parse(txtbox_amount.Text);
                    uniform.Date_granted = dtp_dategranted.Value;
                    uniform.Mode_id = mode.Mode_id;
                    uniform.Amount_deducted = double.Parse(txtbox_amount_deduction.Text);
                    uniform.Deduction_start = dtp_deduction_start.Value;
                    uniform.Profile_id = profile.Profile_id;

                    if(uniform.Insert())
                    {
                        MessageBox.Show("New Uniform  Deduction Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtbox_employee_name.Clear();
                        txtbox_amount.Clear();
                        txtbox_amount_deduction.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Insert Failure, Please check the data inputed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }else
            {
                MessageBox.Show("Please Fill well the fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dgv_uniform = uniform.getviewOD_Uniform(dgv_uniform);
            SetGrid();
        }
    }
}
