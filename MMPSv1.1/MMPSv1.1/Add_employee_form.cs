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

namespace MMPSv1._1
{
    public partial class Add_employee_form : Form

    {
        Objgender gender = new Objgender();
        Objcitezenship citezen = new Objcitezenship();
        Objcivil_status civil_stat = new Objcivil_status();
        Objdepartment dep = new Objdepartment();
        Objposition pos = new Objposition();
        Objstatus status = new Objstatus();
        Objmode mode = new Objmode();
        Objsss_con sss_con = new Objsss_con();
        Objpagibig_con pagibig_con = new Objpagibig_con();
        Objphilhealth ph = new Objphilhealth();
        Objemployee_profiles profile = new Objemployee_profiles();
        Objemployee_work emp_work = new Objemployee_work();
        Objgross_earning earnings = new Objgross_earning();
        Objmandatory_deduction man_deduc = new Objmandatory_deduction();
        Objmaster_employee master = new Objmaster_employee();
        public Add_employee_form()
        {
            InitializeComponent();

            cmbox_gender = gender.GetGender(cmbox_gender);
            cmbox_citezen = citezen.GetCitezenship(cmbox_citezen);
            cmbox_civil_status = civil_stat.Getcivil_status(cmbox_civil_status);
            cmbox_position = pos.GetPositionName(cmbox_position);
            cmbox_department = dep.GetDepartmentName(cmbox_department);
            cmbox_status = status.GetStatusName(cmbox_status);
            combox_sss_paymode = mode.GetModeName(combox_sss_paymode);
            cmbox_pagibig_paymode = mode.GetModeName(cmbox_pagibig_paymode);
            cmbox_ph_paymode = mode.GetModeName(cmbox_ph_paymode);
        }

        //to salary
        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbox_department.SelectedIndex != -1 & cmbox_position.SelectedIndex != -1 & cmbox_status.SelectedIndex != -1 & txtbox_emp_id.Text.Length > 0 &
                date_hired_date.Value != null)
            {
                tabcon_profiling.SelectedTab = salary;
            }
            
        }

        //to work
        private void button1_Click(object sender, EventArgs e)
        {
         
            if (txtbox_fname.Text.Length > 0 & txtbox_lname.Text.Length > 0 & txtbox_mname.Text.Length > 0 & txtbox_suffix.Text.Length > 0
                & txtbox_address.Text.Length > 0 & txtbox_mothername.Text.Length > 0 & txtbox_fathersname.Text.Length > 0 & txtbox_spouse.Text.Length > 0 &
                cmbox_gender.SelectedIndex != -1 & cmbox_civil_status.SelectedIndex != -1 & cmbox_citezen.SelectedIndex != -1 & dtp_birtdate.Value != null)
            {
                tabcon_profiling.SelectedTab = work;
            }
            else
            {
                MessageBox.Show("Please Fill The Fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //to deductions
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtbox_basic_pay.Text.Length > 0 & txtbox_daily_rate.Text.Length > 0 & txtbox_holiday_rate.Text.Length > 0 & txtbox_special_holiday.Text.Length > 0)
            {
                tabcon_profiling.SelectedTab = deductions;
            }
            else
            {
                MessageBox.Show("Please Fill The Fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //wala ni labot
        private void label51_Click(object sender, EventArgs e)
        {

        }

        //save button
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtbox_sss_con.Text.Length > 0 & txtbox_pagibig_con.Text.Length > 0  & txtbox_philhealth_con.Text.Length > 0 &
                txtbox_sss_employer_con.Text.Length > 0 & txtbox_pagibig_employer_con.Text.Length > 0 & txtbox_ph_employer_con.Text.Length > 0 &
                combox_sss_paymode.SelectedIndex != -1 & cmbox_pagibig_paymode.SelectedIndex != -1 & cmbox_ph_paymode.SelectedIndex != -1)
            {
                //save ni dre // magsugod sa profile ug save

                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    profile.Profile_id = profile.generate_profile_id();
                    profile.First_name = txtbox_fname.Text;
                    profile.Last_name = txtbox_lname.Text;
                    profile.Midle_initial = txtbox_mname.Text;
                    profile.Suffix = txtbox_suffix.Text;
                    profile.Birthdate = dtp_birtdate.Value;
                    profile.Gender_id = gender.GetGenderId();
                    profile.Citezenship_id = citezen.GetCitezenId();
                    profile.Civil_status_id = civil_stat.GetCivil_status_id();
                    profile.Address = txtbox_address.Text;
                    profile.Mother_name = txtbox_mothername.Text;
                    profile.Fathers_name = txtbox_fathersname.Text;
                    profile.Spouse_name = txtbox_spouse.Text;

                    if (profile.Insert())
                    {
                        //save na dre sa employee work
                        emp_work.Employee_work_id = emp_work.generate_employee_work_id();
                        emp_work.Department_id = dep.GetDepartmentId();
                        emp_work.Position_id = pos.GetPositionId();
                        emp_work.Employee_id = txtbox_emp_id.Text;
                        emp_work.Hired_date = date_hired_date.Value;
                        emp_work.Status_id = status.GetStatusId();

                        if(emp_work.Insert())
                        {
                            earnings.Emp_gross_earning_id = earnings.generate_emp_gross_earning_id();
                            earnings.Basic_pay = double.Parse(txtbox_basic_pay.Text);
                            earnings.Daily_rate = double.Parse(txtbox_daily_rate.Text);
                            earnings.Legal_holiday_rate = double.Parse(txtbox_holiday_rate.Text);
                            earnings.Special_holiday_rate = double.Parse(txtbox_special_holiday.Text);

                            if(earnings.Insert())
                            {
                                sss_con.Sss_mandatory_deduction_id = sss_con.generate_sss_mandatory_deduction_id_id();
                                sss_con.Sss_contribution = double.Parse(txtbox_sss_con.Text);
                                sss_con.Employer_contribution = double.Parse(txtbox_sss_employer_con.Text);
                                sss_con.Paymode_id = sss_con.Paymode_id;

                                if (sss_con.Insert())
                                {
                                    pagibig_con.Pag_ibig_mandatory_deduction_id = pagibig_con.generate_pag_ibig_mandatory_deduction_idid();
                                    pagibig_con.Pag_ibig_contribution = double.Parse(txtbox_pagibig_con.Text);
                                    pagibig_con.Employer_contribution = double.Parse(txtbox_pagibig_employer_con.Text);
                                    pagibig_con.Paymode_id = pagibig_con.Paymode_id;

                                    if(pagibig_con.Insert()){

                                        ph.Philhealth_contribution_id = ph.generate_philhealth_contribution_deduction_id();
                                        ph.Philhealth_contribution = double.Parse(txtbox_philhealth_con.Text);
                                        ph.Employer_contribution = double.Parse(txtbox_ph_employer_con.Text);
                                        ph.Philhealth_paymode_id = ph.Philhealth_paymode_id;

                                        if(ph.Insert()){

                                            man_deduc.Emp_mandatory_deduction_id = man_deduc.generate_emp_mandatory_deduction_id();
                                            man_deduc.Sss_madatory_deduction_id = sss_con.Sss_mandatory_deduction_id;
                                            man_deduc.Pag_ibig_mandatory_deduction_id = pagibig_con.Pag_ibig_mandatory_deduction_id;
                                            man_deduc.Philhealth_deduction_id = ph.Philhealth_contribution_id;

                                            if (man_deduc.Insert())
                                            {
                                                master.Master_employee_id = master.generate_master_employee_id();
                                                master.Emp_profile_id = profile.Profile_id;
                                                master.Emp_work_id = emp_work.Employee_work_id;
                                                master.Emp_gross_earning_id = earnings.Emp_gross_earning_id;
                                                master.Emp_mandatory_deduction_id = man_deduc.Emp_mandatory_deduction_id;

                                                if(master.Insert())
                                                {
                                                    MessageBox.Show("New Employee Has Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }                                                                                            
                                            }                                      
                                        }        
                                    }  
                                }  
                            }  
                        }  
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill The Fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cmbox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_gender.SelectedIndex != -1)
            {
                gender.Gender_desc = cmbox_gender.Text;
                gender.Gender_id = gender.GetGenderId();
                //dep.Department_decs = cmbox_department.Text;
                //dep.Department_id = dep.GetDepartmentId();
            }
        }

        private void cmbox_citezen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_citezen.SelectedIndex != -1)
            {
                citezen.Citezenship_desc = cmbox_citezen.Text;
                citezen.Citezenship_id = citezen.GetCitezenId();
            }
        }

        private void cmbox_civil_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_civil_status.SelectedIndex != -1)
            {
                civil_stat.Civil_status_desc = cmbox_civil_status.Text;
                civil_stat.Civil_status_id = civil_stat.GetCivil_status_id();
            }
        }

        private void cmbox_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_department.SelectedIndex != -1)
            {
                dep.Department_decs = cmbox_department.Text;
                dep.Department_id = dep.GetDepartmentId();
            } 
        }

        private void cmbox_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_position.SelectedIndex != -1)
            {
                pos.Position_decs = cmbox_position.Text;
                pos.Position_id = pos.GetPositionId();
            }
        }

        private void cmbox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_status.SelectedIndex != -1)
            {
                status.Status_desc = cmbox_status.Text;
                status.Status_id = status.GetStatusId();
            }

        }

        private void combox_sss_paymode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_sss_paymode.SelectedIndex != -1)
            {

                sss_con.Paymode_desc = combox_sss_paymode.Text;
                sss_con.Paymode_id = sss_con.GetsssPaymode_id();
                //mode
            }
        }

        private void cmbox_pagibig_paymode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_pagibig_paymode.SelectedIndex != -1)
            {
                pagibig_con.Paymode_desc = cmbox_pagibig_paymode.Text;
                pagibig_con.Paymode_id = pagibig_con.Getpag_ibigPaymode_id();
                //pagibig
            }
        }

        private void cmbox_ph_paymode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_ph_paymode.SelectedIndex != -1)
            {
                ph.Paymode_desc = cmbox_ph_paymode.Text;
                ph.Philhealth_paymode_id = ph.GetphilhealthPaymode_id();
                //ph
            }
        }

 
    }
}
