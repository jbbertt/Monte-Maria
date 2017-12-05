using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using monte_marai_library;
using System.Globalization;


namespace MMPSv1._1
{
    public partial class Add_dependents : Form
    {
        Objemployee_profiles profile = new Objemployee_profiles();
        Objemployee_dependent emp_dependents = new Objemployee_dependent();
        Objdependent dependent = new Objdependent();
        Objmode mode = new Objmode();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public Add_dependents()
        {
            InitializeComponent();

            txtbox_employe_name = profile.GetProfiles(txtbox_employe_name);
            dgv_dependents = dependent.getviewddependents(dgv_dependents);
            SetGrid();
        }

        void SetGrid()
        {
            dgv_dependents.Columns["employee_name"].Width = 200;
            dgv_dependents.Columns["dependent_name"].Width = 200;
            dgv_dependents.Columns["birth_date"].Width = 200;


            foreach (DataGridViewColumn col in dgv_dependents.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }

        //employee
        private void txtbox_employe_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_employe_name.AutoCompleteCustomSource.Contains(txtbox_employe_name.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_employe_name.Text));

                }
            }
        }

        //add employee dependent
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtbox_dependent.Text.Length > 0 & txtbox_employe_name.Text.Length > 0 & dtp_bdate.Value != null){
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                 if (answer == DialogResult.Yes)
                 {
                     dependent.Dependent_id = dependent.generate_dependent_id();
                     dependent.Dependent_name = txtbox_dependent.Text;
                     dependent.Birth_date = dtp_bdate.Value;

                     if(dependent.Insert())
                     {
                         emp_dependents.Dependent_id = dependent.Dependent_id;
                         emp_dependents.Profile_id = profile.Profile_id;

                         if (emp_dependents.Insert())
                         {
                             MessageBox.Show("New Salary Dependent has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }                    
                     }
                 }
            }

        }

   
    }
}
