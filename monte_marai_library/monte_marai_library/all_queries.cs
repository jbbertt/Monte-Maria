using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class all_queries
    {
        int status_id;

        public int Status_id
        {
            get { return status_id; }
            set { status_id = value; }
        }

        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }

        int payroll_date_id;

        public int Payroll_date_id
        {
            get { return payroll_date_id; }
            set { payroll_date_id = value; }
        }

      
      
    }
    public class Objall_queries : all_queries
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;


        public DataGridView getviewAll_employee(DataGridView mtDgv)
        {
            myString = "select * from employee_details";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        public DataGridView getSearch_all_profiles(DataGridView mtDgv)
        {
            myString = " SELECT DISTINCT h.employee_id, (((a.last_name::text || ', '::text) || initcap(a.first_name::text)) || ' '::text) || ' '::text AS employee_name, b.gender_desc, c.civil_status_desc, a.address, a.spouse_name, d.status_desc, e.position_decs, f.department_decs, g.basic_pay FROM employee_profiles a, gender b, civil_status c, status d, position e, department f, employee_gross_earnings g, employee_work h, master_employee i WHERE '"+Profile_id+"' = i.emp_profile_id and  i.emp_profile_id = a.profile_id AND b.gender_id = a.gender_id AND  c.civil_status_id = a.civil_status_id AND  d.status_id = h.status_id AND  e.position_id = h.position_id AND  f.department_id = h.department_id AND  i.emp_gross_earning_id = g.emp_gross_earning_id AND i.emp_work_id = h.employee_work_id;";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        public DataGridView getSearch_by_status(DataGridView mtDgv)
        {
            myString = " SELECT DISTINCT h.employee_id, (((a.last_name::text || ', '::text) || initcap(a.first_name::text)) || ' '::text) || ' '::text AS employee_name, b.gender_desc, c.civil_status_desc, a.address, a.spouse_name, d.status_desc, e.position_decs, f.department_decs, g.basic_pay FROM employee_profiles a, gender b, civil_status c, status d, position e, department f, employee_gross_earnings g, employee_work h, master_employee i WHERE  '"+Status_id+"' = d.status_id and i.emp_profile_id = a.profile_id AND b.gender_id = a.gender_id AND  c.civil_status_id = a.civil_status_id AND  d.status_id = h.status_id AND  e.position_id = h.position_id AND  f.department_id = h.department_id AND  i.emp_gross_earning_id = g.emp_gross_earning_id AND i.emp_work_id = h.employee_work_id;";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        public DataGridView getSearch_by_both(DataGridView mtDgv)
        {
            myString = " SELECT DISTINCT h.employee_id, (((a.last_name::text || ', '::text) || initcap(a.first_name::text)) || ' '::text) || ' '::text AS employee_name, b.gender_desc, c.civil_status_desc, a.address, a.spouse_name, d.status_desc, e.position_decs, f.department_decs, g.basic_pay FROM employee_profiles a, gender b, civil_status c, status d, position e, department f, employee_gross_earnings g, employee_work h, master_employee i WHERE  '" + Status_id + "' = d.status_id and '" + Profile_id + "' = i.emp_profile_id and i.emp_profile_id = a.profile_id AND b.gender_id = a.gender_id AND  c.civil_status_id = a.civil_status_id AND  d.status_id = h.status_id AND  e.position_id = h.position_id AND  f.department_id = h.department_id AND  i.emp_gross_earning_id = g.emp_gross_earning_id AND i.emp_work_id = h.employee_work_id;";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
        public string getuserlogin()
        {
            myString = "select username from login";
            return myQuery.ViaSingleData(myString);
        }

        public string getuserRole()
        {
            myString = "select role from login";
            return myQuery.ViaSingleData(myString);
        }

        public DataGridView getall_attendance_by_date(DataGridView mtDgv)
        {
            //change ang naay '2'
            myString = " SELECT DISTINCT (((a.last_name::text || ', '::text) || initcap(a.first_name::text)) || ' '::text) || ' '::text AS employee_name, b.days_present, b.days_legal_holiday as legal_holiday_present, b.special_non_workingday as special_non_working_holiday_present, c.payroll_date as payroll_compute_date FROM  employee_profiles a, dtr_attendance b, dtr_payroll_date c WHERE b.payroll_date_id = '" + Payroll_date_id + "' and c.payroll_date_id = b.payroll_date_id and b.profilie_id = a.profile_id;";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        public DataGridView GetEmployees_by_Payrolldate(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name from employee_profiles a, salaries b, dtr_payroll_date c where c.payroll_date_id = '" + Payroll_date_id + "' and b.profile_id = a.profile_id ";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        public DataGridView GetEmployee_Salary_Detailed(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.payroll_date , c.regular_pay, c.special_pay , c.legal_pay , c.salary as total from employee_profiles a, dtr_payroll_date b, salaries c, dtr_attendance d where  d.payroll_date_id = '" + Payroll_date_id + "' and c.profile_id = '"+Profile_id+"' and d.attendance_id = c.attendance_id and d.payroll_date_id = b.payroll_date_id and c.profile_id = a.profile_id;";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        //deductions

    }
}
