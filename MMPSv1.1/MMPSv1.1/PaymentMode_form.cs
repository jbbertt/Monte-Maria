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
    public partial class PaymentMode_form : Form
    {
        Objmode mode = new Objmode();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public PaymentMode_form()
        {
            InitializeComponent();

            dgv_mode = mode.getviewmode(dgv_mode);
            SetGrid();
        }
        void SetGrid()
        {

            dgv_mode.Columns["mode_id"].Width = 157;
            dgv_mode.Columns["mode_desc"].Width = 260;


            foreach (DataGridViewColumn col in dgv_mode.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (mode_txtbox.Text.Length > 0)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);

                if (answer == DialogResult.Yes)
                {
                    mode.Mode_id = mode.generate_mode_id();
                    mode.Mode_desc = mode_txtbox.Text;

                    if (mode.Insert())
                    {
                        MessageBox.Show("New Mode Saved.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mode_txtbox.Text = string.Empty;
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
            dgv_mode = mode.getviewmode(dgv_mode);
            SetGrid();
        }
    }
}
