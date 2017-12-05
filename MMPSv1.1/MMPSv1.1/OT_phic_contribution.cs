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
    public partial class OT_phic_contribution : UserControl
    {
        Objod_phic phic = new Objod_phic();
        Objmode mode = new Objmode();
        Objemployee_profiles profile = new Objemployee_profiles();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        
   
        public OT_phic_contribution()
        {
            InitializeComponent();
            txtbox_emp_name = profile.GetProfiles(txtbox_emp_name);
            cmbox_mode = mode.GetModeName(cmbox_mode);
            dgv_phic = phic.getviewOD_phic(dgv_phic);
            SetGrid();
        }
        void SetGrid()
        {
            dgv_phic.Columns["employee_name"].Width = 280;
            dgv_phic.Columns["phic_employee_contribution"].Width = 240;
            dgv_phic.Columns["mode_desc"].Width = 240;


            foreach (DataGridViewColumn col in dgv_phic.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }


        private void save_btn_Click(object sender, EventArgs e)
        {
            if(txtbox_emp_name.Text.Length > 0 & txtbox_employee_con.Text.Length > 0 & txtbox_employer_con.Text.Length > 0 & cmbox_mode.SelectedIndex != -1)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                   

                    phic.Phic_id = phic.generate_phic_id();
                    phic.Phic_employee_contribution = double.Parse(txtbox_employee_con.Text);
                    phic.Phic_employer_contribution = double.Parse(txtbox_employer_con.Text);
                    phic.Phic_mode = mode.GetModeId();
                    phic.Profile_id = profile.Profile_id;

                    if(phic.Insert())
                    {
                        MessageBox.Show("New Phic Contribution has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtbox_emp_name.Text = string.Empty;
                        txtbox_employee_con.Text = string.Empty;
                        txtbox_employer_con.Text = string.Empty;
                        cmbox_mode.Text = string.Empty;
                    }                  
                }
            }
            else
            {
                MessageBox.Show("Please Fill well the fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtbox_emp_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_emp_name.AutoCompleteCustomSource.Contains(txtbox_emp_name.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_emp_name.Text));

                }
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dgv_phic = phic.getviewOD_phic(dgv_phic);
            SetGrid();
        }
    }
}
