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
    public partial class UC_position_setup : UserControl
    {
        Objdepartment department = new Objdepartment();
        Objposition position = new Objposition();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
       // contextMenuStrip1 edit = new contextMenuStrip1();

        public UC_position_setup()
        {
            InitializeComponent();

            dpmnt_cmbbox = department.GetDepartmentName(dpmnt_cmbbox);

            dpmnt_view = position.getviewposition(dpmnt_view);
            SetGrid();
        }
        void SetGrid()
        {

            dpmnt_view.Columns["position_id"].Width = 100;
            dpmnt_view.Columns["position_decs"].Width = 200;
            dpmnt_view.Columns["department_decs"].Width = 200;

            //   dataitems.Columns.Add(button);

            foreach (DataGridViewColumn col in dpmnt_view.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dpmnt_view = position.getviewposition(dpmnt_view);
            SetGrid();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (position_txtbox.Text.Length > 0 & dpmnt_cmbbox.SelectedIndex != -1)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    position.Position_id = position.generate_position_id();
                    position.Department_id = department.GetDepartmentId();
                    position.Position_decs = position_txtbox.Text;

                    if (position.Insert())
                    {
                        MessageBox.Show("New Position has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                //message
                MessageBox.Show("Please Fill well the fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dpmnt_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dpmnt_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dpmnt_cmbbox.SelectedIndex != -1)
            {
                department.Department_decs = dpmnt_cmbbox.Text;
                department.Department_id = department.GetDepartmentId();
                
            }
        }

        int cont = 0;

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dpmnt_cmbbox.Text = dpmnt_view.Rows[0].Cells[2].Value.ToString();
            position_txtbox.Text = dpmnt_view.Rows[0].Cells[3].Value.ToString();

            if(cont == 1)
            {
               // Add_DTR.showdialog(;
                new Add_DTR().ShowDialog(); //walay gamit ni nga form
            }
        }
    }
}
