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
    public partial class UC_payroll_viewpayroll : UserControl
    {
        Objdtr_payroll_date dates = new Objdtr_payroll_date();
        Objall_queries query = new Objall_queries();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public UC_payroll_viewpayroll()
        {
            InitializeComponent();

            cmbox_date = dates.GetDates(cmbox_date);

        }


        private void cmbox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_date.SelectedIndex != -1)
            {

                dates.Payroll_date = DateTime.Parse(cmbox_date.Text);
                dates.Payroll_date_id = dates.GetDateId();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmbox_date.SelectedIndex != -1)
            {
                query.Payroll_date_id = dates.Payroll_date_id;

                dgv_details = query.GetPayroll_Details(dgv_details);
                SetGrid();
            }
            else
            {
                MessageBox.Show("Please choose a payroll date");
            }
        }

        void SetGrid()
        {

            dgv_details.Columns["employee_name"].Width = 180;
            dgv_details.Columns["payroll_date"].Width = 140;
            dgv_details.Columns["days_present"].Width = 150;
            dgv_details.Columns["days_legal_holiday"].Width = 150;
            dgv_details.Columns["special_non_workingday"].Width = 150;
            dgv_details.Columns["salary"].Width = 100;
            dgv_details.Columns["deduction_total"].Width = 100;

            foreach (DataGridViewColumn col in dgv_details.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }
    }
}
