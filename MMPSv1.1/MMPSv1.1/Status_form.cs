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
    public partial class Status_form : Form
    {
        Objstatus status = new Objstatus();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        

        public Status_form()
        {
            InitializeComponent();

            dgv_status = status.getviewstatus(dgv_status);
            SetGrid();
         
        }
        void SetGrid()
        {

            dgv_status.Columns["status_id"].Width = 157;
            dgv_status.Columns["status_desc"].Width = 260;
            

            foreach (DataGridViewColumn col in dgv_status.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            }
        }

        //walay labot ni
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //save status
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (txtbox_status.Text.Length > 0)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);

                if (answer == DialogResult.Yes)
                {
                    status.Status_id = status.generate_status_id();
                    status.Status_desc = txtbox_status.Text;

                    if (status.Insert())
                    {
                        MessageBox.Show("New Status Saved.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtbox_status.Text = string.Empty;
                    }
                }

            }
            else
            {
                MessageBox.Show("Fill the Field.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
           

            dgv_status = status.getviewstatus(dgv_status);
            SetGrid();
        }
    }
}
