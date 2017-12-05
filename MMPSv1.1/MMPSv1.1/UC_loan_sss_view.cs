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
    public partial class UC_loan_sss_view : UserControl
    {
        Objloan_sss sss = new Objloan_sss();
        Objemployee_profiles profile = new Objemployee_profiles();
        Objmode mode = new Objmode();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public UC_loan_sss_view()
        {
            InitializeComponent();

            txtbox_empname = profile.GetProfiles(txtbox_empname);
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

        private void btn_view_all_Click(object sender, EventArgs e)
        {
            dgv_sss = sss.getViewAllsssLoan(dgv_sss);
            SetGrid();
        }
        void SetGrid()
        {

            dgv_sss.Columns["employee_name"].Width = 160;
            dgv_sss.Columns["sss_loan_amount"].Width = 150;
            dgv_sss.Columns["loan_dategranted"].Width = 150;
            dgv_sss.Columns["loan_amount_deducted"].Width = 150;
            dgv_sss.Columns["loan_deduction_start"].Width = 150;
            dgv_sss.Columns["employee_sss_id"].Width = 150;
            dgv_sss.Columns["deduction_mode"].Width = 120;

            foreach (DataGridViewColumn col in dgv_sss.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txtbox_empname.Text.Length > 0)
            {

                sss.Profile_id = profile.Profile_id;
                dgv_sss = sss.getViewSearchsssLoan(dgv_sss);
                SetGrid();

            }
            else
            {
                MessageBox.Show("Please Enter a name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
