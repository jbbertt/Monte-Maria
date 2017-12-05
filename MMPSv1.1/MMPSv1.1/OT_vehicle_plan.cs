using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bggPgSql;
using monte_marai_library;
using System.Globalization;

namespace MMPSv1._1
{
    public partial class OT_vehicle_plan : UserControl
    {
        Objvehicle_plan vehicle = new Objvehicle_plan();
        Objmode mode = new Objmode();
        Objemployee_profiles profile = new Objemployee_profiles();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public OT_vehicle_plan()
        {
            InitializeComponent();

            txtbox_empname = profile.GetProfiles(txtbox_empname);
            cmbox_mode = mode.GetModeName(cmbox_mode);
            dgv_vehicle = vehicle.getviewOD_vehicle(dgv_vehicle);
            SetGrid();
        }

        void SetGrid()
        {
            dgv_vehicle.Columns["employee_name"].Width = 200;
            dgv_vehicle.Columns["vehicle_payable"].Width = 150;
            dgv_vehicle.Columns["date_granted"].Width = 150;
            dgv_vehicle.Columns["amount_deducted"].Width = 140;
            dgv_vehicle.Columns["deduction_start"].Width = 140;
            dgv_vehicle.Columns["mode_desc"].Width = 140;

            foreach (DataGridViewColumn col in dgv_vehicle.Columns)
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
            if (txtbox_empname.Text.Length > 0 & txtbox_deducted.Text.Length > 0 & txtbox_vehicle_payable.Text.Length > 0 & txtbox_vehicle_payable.Text.Length > 0
               &  dtp_date_granted != null & cmbox_mode.SelectedIndex != -1 )
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    vehicle.Vehicle_plan_id = vehicle.generate_vehicle_plan_id();
                    vehicle.Vehicle_payable = double.Parse(txtbox_vehicle_payable.Text);
                    vehicle.Date_granted = dtp_date_granted.Value;
                    vehicle.Mode_id = mode.GetModeId();
                    vehicle.Deduction_start = deduction_start.Value;
                    vehicle.Amount_deducted = double.Parse(txtbox_deducted.Text);
                    vehicle.Profile_id = profile.Profile_id;

                    if (vehicle.Insert())
                    {
                        MessageBox.Show("New Vehicle Plan has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill well the fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dgv_vehicle = vehicle.getviewOD_vehicle(dgv_vehicle);
            SetGrid();
        }
    }
}
