using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;

namespace monte_marai_library
{
    public class salaries
    {
  //       salary_id integer NOT NULL,
  //salary double precision

        int salary_id;

        public int Salary_id
        {
            get { return salary_id; }
            set { salary_id = value; }
        }
        double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }

        int attendance_id;

        public int Attendance_id
        {
            get { return attendance_id; }
            set { attendance_id = value; }
        }
    }

    public class Objsalaries : salaries
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into salaries(salary_id,salary,profile_id,attendance_id) values(" + Salary_id + ", " + Salary + ", " + Profile_id + ", " + Attendance_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_salary_id()
        {
            myString = "Select coalesce(max(salary_id), 0) + 1 from salaries;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public double getdaily_rate()
        {
            myString = "select distinct a.daily_rate from employee_gross_earnings a , master_employee b where b.emp_profile_id = '"+Profile_id+"' and b.emp_gross_earning_id = a.emp_gross_earning_id;";
            return double.Parse(myQuery.ViaSingleData(myString));
        }

        public double getspecial_rate()
        {
            myString = "select distinct a.special_holiday_rate from employee_gross_earnings a , master_employee b where b.emp_profile_id = '" + Profile_id + "' and b.emp_gross_earning_id = a.emp_gross_earning_id;";
            return double.Parse(myQuery.ViaSingleData(myString));
        }

        public double getleagal_rate()
        {
            myString = "select distinct a.legal_holiday_rate from employee_gross_earnings a , master_employee b where b.emp_profile_id = '" + Profile_id + "' and b.emp_gross_earning_id = a.emp_gross_earning_id;";
            return double.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
