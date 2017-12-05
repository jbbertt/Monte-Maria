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
    public partial class OT_health_card : UserControl
    {
        Objod_health_card hcard = new Objod_health_card();
        Objmode mode = new Objmode();
        Objemployee_profiles profile = new Objemployee_profiles();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        public OT_health_card()
        {
            InitializeComponent();

            txtbox_empname = profile.GetProfiles(txtbox_empname);
            cmbox_mode = mode.GetModeName(cmbox_mode);
            dgv_hcard = hcard.getviewOD_Hcard(dgv_hcard);
            SetGrid();
        }
        void SetGrid()
        {
            dgv_hcard.Columns["employee_name"].Width = 200;
            dgv_hcard.Columns["amount"].Width = 150;
            dgv_hcard.Columns["date_granted"].Width = 150;
            dgv_hcard.Columns["amount_deducted"].Width = 140;
            dgv_hcard.Columns["deduction_start"].Width = 140;
            dgv_hcard.Columns["deduction_mode"].Width = 140;

            foreach (DataGridViewColumn col in dgv_hcard.Columns)
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

        private void txtbox_empname_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_empname.AutoCompleteCustomSource.Contains(txtbox_empname.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_empname.Text));

                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(txtbox_empname.Text.Length > 0 & txtbox_amount.Text.Length > 0 & txtbox_deduction.Text.Length > 0 &
                cmbox_mode.SelectedIndex != -1 & dtp_dategranted.Value != null & dtp_deduction_starts.Value != null)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    hcard.Health_card_id = hcard.generate_health_card_id();
                    hcard.Amount = double.Parse(txtbox_amount.Text);
                    hcard.Date_granted = dtp_dategranted.Value;
                    hcard.Mode_id = mode.Mode_id;
                    hcard.Amount_deducted = double.Parse(txtbox_deduction.Text);
                    hcard.Profile_id = profile.Profile_id;

                    if(hcard.Insert()){
                        MessageBox.Show("New Health Card has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


    }
}
