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
    public partial class OT_eggs : UserControl
    {
        Objod_employee_eggs eggs = new Objod_employee_eggs();
        Objmode mode = new Objmode();
        Objemployee_profiles profile = new Objemployee_profiles();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public OT_eggs()
        {
            
            InitializeComponent();

            txtbox_empname = profile.GetProfiles(txtbox_empname);
            dgv_eggs = eggs.getviewOD_Eggs(dgv_eggs);
            SetGrid();
        }

        void SetGrid()
        {
            dgv_eggs.Columns["employee_name"].Width = 200;
            dgv_eggs.Columns["amount"].Width = 150;
            dgv_eggs.Columns["invoice_no"].Width = 150;
            dgv_eggs.Columns["date"].Width = 140;

            foreach (DataGridViewColumn col in dgv_eggs.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
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
            if(txtbox_empname.Text.Length > 0 & txtbox_amount.Text.Length > 0 & dtp_date.Value != null & txtbox_invoice.Text.Length > 0){

                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    eggs.Eggs_id = eggs.generate_eggs_id();
                    eggs.Invoice_no = txtbox_invoice.Text;
                    eggs.Date = dtp_date.Value;
                    eggs.Amount = double.Parse(txtbox_amount.Text);
                    eggs.Profile_id = profile.Profile_id;

                    if(eggs.Insert()){
                        MessageBox.Show("New Egg Sale has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insert Failure, Please check the data inputed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dgv_eggs = eggs.getviewOD_Eggs(dgv_eggs);
            SetGrid();
        }
    }
}
