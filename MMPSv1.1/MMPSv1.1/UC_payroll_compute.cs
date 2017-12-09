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
        Objdeductions deduc = new Objdeductions();
        Objnet_salary net = new Objnet_salary();
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
            if (checkBox1.Checked && !checkBox2.Checked  && txtbox_name.Text.Length > 0)
            {
                deduc.Mode_id = 1;
                deduc.Profile_id = profile.Profile_id;

                deduc.Deduction_id = deduc.generate_deduction_id();
                deduc.Profile_id = profile.Profile_id;

                deduc.Sss_contribution = deduc.getEmp_sss_contribution();
                deduc.Philhealth_contribution = deduc.getEmp_philhealth_contribution();
                deduc.Pagibig_contribution = deduc.getEmp_pafibig_contribution();
                deduc.Od_ca = deduc.getEmp_od_ca();
                deduc.Od_eggs = deduc.getEmp_od_eggs();
                deduc.Od_hcard = deduc.getEmp_od_health_card();
                deduc.Od_hmo = deduc.getEmp_od_hmo();
                deduc.Od_phic = deduc.getEmp_od_phic();
                deduc.Od_tin = deduc.getEmp_od_tin();
                deduc.Od_uniform = deduc.getEmp_od_uniform();
                deduc.Od_vehicle = deduc.getEmp_od_vehicle_plan();
                deduc.Loan_sss = deduc.getEmp_loan_sss();
                deduc.Loan_pagibig = deduc.getEmp_loan_pagibig();

                deduc.Attendance_id = dates.Payroll_date_id;

                deduc.Deduction_total = deduc.getEmp_sss_contribution() + deduc.getEmp_philhealth_contribution() + deduc.getEmp_pafibig_contribution()
                                       + deduc.getEmp_od_ca() + deduc.getEmp_od_eggs() + deduc.getEmp_od_health_card() + deduc.getEmp_od_hmo() + deduc.getEmp_od_phic()
                                       + deduc.getEmp_od_tin() + deduc.getEmp_od_uniform() + deduc.getEmp_od_vehicle_plan() + deduc.getEmp_loan_sss() + deduc.getEmp_loan_pagibig();

                if (deduc.Insert())
                {
                    net.Profile_id = profile.Profile_id;

                    net.Net_salary_id = net.generate_net_salary_id();
                    net.Employee_net_salary = net.getsalary() - deduc.Deduction_total;
                    net.Profile_id = profile.Profile_id;
                    net.Attendance_id = dates.Payroll_date_id;
                    if (net.Insert())
                    {
                        MessageBox.Show("Employee Salary and Deduction has Computed");
                        txtbox_name.Clear();
                    }
                    
                }
            }

            else if (checkBox2.Checked && !checkBox1.Checked  && txtbox_name.Text.Length > 0)
            {
                deduc.Mode_id = 1;
                deduc.Profile_id = profile.Profile_id;

                deduc.Deduction_id = deduc.generate_deduction_id();
                deduc.Profile_id = profile.Profile_id;
                deduc.Sss_contribution = deduc.getEmp_sss_contribution();
                deduc.Philhealth_contribution = deduc.getEmp_philhealth_contribution();
                deduc.Pagibig_contribution = deduc.getEmp_pafibig_contribution();
                deduc.Od_ca = deduc.getEmp_od_ca();
                deduc.Od_eggs = deduc.getEmp_od_eggs();
                deduc.Od_hcard = deduc.getEmp_od_health_card();
                deduc.Od_hmo = deduc.getEmp_od_hmo();
                deduc.Od_phic = deduc.getEmp_od_phic();
                deduc.Od_tin = deduc.getEmp_od_tin();
                deduc.Od_uniform = deduc.getEmp_od_uniform();
                deduc.Od_vehicle = deduc.getEmp_od_vehicle_plan();
                deduc.Loan_sss = deduc.getEmp_loan_sss();
                deduc.Loan_pagibig = deduc.getEmp_loan_pagibig();

                deduc.Attendance_id = dates.Payroll_date_id;

                deduc.Deduction_total = deduc.getEmp_sss_contribution() + deduc.getEmp_philhealth_contribution() + deduc.getEmp_pafibig_contribution()
                                      + deduc.getEmp_od_ca() + deduc.getEmp_od_eggs() + deduc.getEmp_od_health_card() + deduc.getEmp_od_hmo() + deduc.getEmp_od_phic()
                                      + deduc.getEmp_od_tin() + deduc.getEmp_od_uniform() + deduc.getEmp_od_vehicle_plan() + deduc.getEmp_loan_sss() + deduc.getEmp_loan_pagibig();

                if(deduc.Insert()){

                    net.Profile_id = profile.Profile_id;

                    net.Net_salary_id = net.generate_net_salary_id();
                    net.Employee_net_salary = net.getsalary() - deduc.Deduction_total;
                    net.Profile_id = profile.Profile_id;
                    net.Attendance_id = dates.Payroll_date_id;
                    if (net.Insert())
                    {
                        MessageBox.Show("Employee Salary and Deduction has Computed");
                        txtbox_name.Clear();
                    }
                }
               
            }

            if(!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Please check the checkbox!");
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
