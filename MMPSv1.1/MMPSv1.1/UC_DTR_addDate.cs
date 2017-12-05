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
    public partial class UC_DTR_addDate : UserControl
    {
        Objdtr_payroll_date pdate = new Objdtr_payroll_date();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public UC_DTR_addDate()
        {
            InitializeComponent();

            dgv_date = pdate.getViewPayrollDate(dgv_date);
            SetGrid();
        }

        void SetGrid()
        {
            dgv_date.Columns["payroll_date_id"].Width = 200;
            dgv_date.Columns["payroll_date"].Width = 250;


            foreach (DataGridViewColumn col in dgv_date.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (dtp_date.Value != null)
            {
                 DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                 if (answer == DialogResult.Yes)
                 {
                     pdate.Payroll_date_id = pdate.generate_payroll_date_id();
                     pdate.Payroll_date = dtp_date.Value;

                     if (pdate.Insert())
                     {
                         MessageBox.Show("New Payroll Date has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         
                     }
                 }
            }
            else
            {
                MessageBox.Show("Please Input the field.");
            }
        }
    }
}
