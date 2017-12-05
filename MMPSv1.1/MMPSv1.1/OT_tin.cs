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
    public partial class OT_tin : UserControl
    {
        Objod_tin tin = new Objod_tin();
        Objmode mode = new Objmode();
        Objemployee_profiles profile = new Objemployee_profiles();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
       

        public OT_tin()
        {
            InitializeComponent();

            txtbox_empname = profile.GetProfiles(txtbox_empname);
            cmbox_mode = mode.GetModeName(cmbox_mode);
            dgv_tin = tin.getviewOD_tin(dgv_tin);
            SetGrid();
        }
        void SetGrid()
        {
            dgv_tin.Columns["employee_name"].Width = 280;
            dgv_tin.Columns["withholding_taax_rate"].Width = 240;
            dgv_tin.Columns["mode_desc"].Width = 240;


            foreach (DataGridViewColumn col in dgv_tin.Columns)
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
            

            tin.Tin_id = tin.generate_tin_id();
            tin.Withholding_taax_rate = double.Parse(txtbox_tax.Text);
            tin.Tin_mode = mode.GetModeId();
            tin.Profile_id = profile.Profile_id;

            if (tin.Insert())
            {
               MessageBox.Show("New tin Contribution has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtbox_empname.Text = string.Empty;
               txtbox_tax.Text = string.Empty;
               cmbox_mode.Text = string.Empty;
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dgv_tin = tin.getviewOD_tin(dgv_tin);
            SetGrid();
        }
    }
}
