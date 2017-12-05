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
    public partial class OT_hmo : UserControl
    {
        Objod_hmo hmo = new Objod_hmo();
        Objmode mode = new Objmode();
        Objemployee_profiles profile = new Objemployee_profiles();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        public OT_hmo()
        {
            InitializeComponent();

            txtbox_employename = profile.GetProfiles(txtbox_employename);
            cmbox_mode = mode.GetModeName(cmbox_mode);

            dgv_hmo = hmo.getviewOD_hmo(dgv_hmo);
            SetGrid();
        }

        void SetGrid()
        {
            dgv_hmo.Columns["employee_name"].Width = 180;
            dgv_hmo.Columns["intillecare_pay_amount"].Width = 140;
            dgv_hmo.Columns["date_granted"].Width = 140;
            dgv_hmo.Columns["amount_deducted"].Width = 130;
            dgv_hmo.Columns["deduction_start"].Width = 130;
            dgv_hmo.Columns["mode_desc"].Width = 100;

            foreach (DataGridViewColumn col in dgv_hmo.Columns)
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

        private void txtbox_employename_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_employename.AutoCompleteCustomSource.Contains(txtbox_employename.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_employename.Text));

                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(txtbox_employename.Text.Length > 0 & txtbox_deducted.Text.Length > 0 & txtbox_itellicare.Text.Length > 0
                & cmbox_mode.SelectedIndex != -1 & dtp_dategranted.Value != null & deduction_start.Value != null  & txtbox_itellicare.Text.Length > 0)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    hmo.Hmo_id = hmo.generate_hmo_id();
                    hmo.Intillecare_pay_amount = double.Parse(txtbox_itellicare.Text);
                    hmo.Date_granted = dtp_dategranted.Value;
                    hmo.Mode_id = mode.Mode_id;
                    hmo.Amount_deducted = double.Parse(txtbox_deducted.Text);
                    hmo.Deduction_start = deduction_start.Value;
                    hmo.Profile_id = profile.Profile_id;


                    if(hmo.Insert()){
                        MessageBox.Show("New HMO Contribution has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insert Failure, Please check the data inputed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }else{
                   MessageBox.Show("Please Fill well the fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
