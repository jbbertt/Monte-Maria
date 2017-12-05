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
    public partial class UC_setup_department : UserControl
    {
        Objdepartment department = new Objdepartment();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public UC_setup_department()
        {
            InitializeComponent();
            dpmnt_view = department.getviewdepartments(dpmnt_view);
            SetGrid();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (department_txtbox.Text.Length > 0)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    department.Department_id = department.generate_department_id();
                    department.Department_decs = department_txtbox.Text;

                    if (department.Insert())
                    {


                        MessageBox.Show("New Department has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        department_txtbox.Text = string.Empty;

                    }
                }
                else
                {
                    MessageBox.Show("Please Input the field.");

                }
            }
        }
        void SetGrid()
        {//--/bus_id bu_name seats depart_date depart_from going_to
            // DataGridViewButtonColumn button = new DataGridViewButtonColumn();

            dpmnt_view.Columns["department_id"].Width = 200;
            dpmnt_view.Columns["department_decs"].Width = 251;

            //   dataitems.Columns.Add(button);

            foreach (DataGridViewColumn col in dpmnt_view.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
                // col.HeaderText = col.HeaderText.Replace("Num", "#");
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dpmnt_view = department.getviewdepartments(dpmnt_view);
            SetGrid();
        }
    }
}
