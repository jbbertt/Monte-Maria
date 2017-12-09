using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;

namespace monte_marai_library
{
    public class net_salary
    {
  //      net_salary_id integer NOT NULL,
  //employee_net_salary double precision,
  //profile_id integer,
  //attendance_id integer,
        int net_salary_id;

        public int Net_salary_id
        {
            get { return net_salary_id; }
            set { net_salary_id = value; }
        }
        double employee_net_salary;

        public double Employee_net_salary
        {
            get { return employee_net_salary; }
            set { employee_net_salary = value; }
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
    public class Objnet_salary : net_salary
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into net_salary(net_salary_id,employee_net_salary,profile_id,attendance_id) values(" + Net_salary_id + ", " + Employee_net_salary + ", " + Attendance_id + "," + Profile_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_net_salary_id()
        {
            myString = "Select coalesce(max(net_salary_id), 0) + 1 from net_salary;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public double getsalary()
        {
            myString = "select  COALESCE(sum(a.salary),0) from salaries a, dtr_attendance b, dtr_payroll_date c, employee_profiles d where d.profile_id = '"+Profile_id+"' and a.attendance_id = '1' and d.profile_id = a.profile_id and a.attendance_id = b.attendance_id and b.payroll_date_id = c.payroll_date_id";
            return double.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
