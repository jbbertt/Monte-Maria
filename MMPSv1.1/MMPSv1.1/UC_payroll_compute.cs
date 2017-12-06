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
    public partial class UC_payroll_compute : UserControl
    {
        Objdtr_payroll_date dates = new Objdtr_payroll_date();
        Objall_queries query = new Objall_queries();
        Objemployee_profiles profile = new Objemployee_profiles();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public UC_payroll_compute()
        {
            InitializeComponent();
            cmbox_date = dates.GetDates(cmbox_date);

            txtbox_name = profile.GetProfiles(txtbox_name);
        }

        private void cmbox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_date.SelectedIndex != -1)
            {

                query.Payroll_date_id = dates.Payroll_date_id;

                dates.Payroll_date = DateTime.Parse(cmbox_date.Text);
                dates.Payroll_date_id = dates.GetDateId();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query.Payroll_date_id = dates.Payroll_date_id;

            dgv_attendance = query.GetEmployees_by_Payrolldate(dgv_attendance);
            SetGrid();
        }
        void SetGrid()
        {

            dgv_attendance.Columns["employee_name"].Width = 200;
           


            foreach (DataGridViewColumn col in dgv_attendance.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }

        private void txtbox_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_name.AutoCompleteCustomSource.Contains(txtbox_name.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_name.Text));

                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("deduct the 15th");
            }

            else if (checkBox2.Checked && !checkBox1.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("deduct the 30th");
            }

            else if (checkBox4.Checked && checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("deduct the per payroll and 15th");
            }

            else if (checkBox4.Checked && !checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("deduct the per payroll and 30th");
            }

            else if (checkBox4.Checked && checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("You can only check only 2 checkbox!");
            }
            else if (!checkBox4.Checked && !checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Please check the checkbox for deductions.");
            }
        }

        //add button
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtbox_name.Text.Length > 0 && cmbox_date.SelectedIndex != -1)
            {
                query.Payroll_date_id = dates.Payroll_date_id;
                query.Profile_id = profile.Profile_id;

                dgv_salary = query.GetEmployee_Salary_Detailed(dgv_salary);
                SetGrid2();
            }
            else
            {
                MessageBox.Show("Input Name and Date!");
            }
        }
        void SetGrid2()
        {

            dgv_salary.Columns["employee_name"].Width = 170;
            dgv_salary.Columns["payroll_date"].Width = 120;
            dgv_salary.Columns["regular_pay"].Width = 120;
            dgv_salary.Columns["special_pay"].Width = 120;
            dgv_salary.Columns["legal_pay"].Width = 120;
            dgv_salary.Columns["total"].Width = 120;
            
            foreach (DataGridViewColumn col in dgv_salary.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }



    }
}
