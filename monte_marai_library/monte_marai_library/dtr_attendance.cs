using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class dtr_attendance
    {
  //      attendance_id integer NOT NULL,
  //payroll_date_id integer,
  //profilie_id integer,
  //days_present double precision,
  //days_legal_holiday double precision,
  //special_non_workingday double precision,
  //employee_name character varying(70),

        int attendance_id;

        public int Attendance_id
        {
            get { return attendance_id; }
            set { attendance_id = value; }
        }
        int payroll_date_id;

        public int Payroll_date_id
        {
            get { return payroll_date_id; }
            set { payroll_date_id = value; }
        }
        int profilie_id;

        public int Profilie_id
        {
            get { return profilie_id; }
            set { profilie_id = value; }
        }
        double days_present;

        public double Days_present
        {
            get { return days_present; }
            set { days_present = value; }
        }
        double days_legal_holiday;

        public double Days_legal_holiday
        {
            get { return days_legal_holiday; }
            set { days_legal_holiday = value; }
        }
        double special_non_workingday;

        public double Special_non_workingday
        {
            get { return special_non_workingday; }
            set { special_non_workingday = value; }
        }
        double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
    public class Objdtr_attendance : dtr_attendance
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into dtr_attendance(attendance_id,payroll_date_id,profilie_id,days_present,days_legal_holiday,special_non_workingday,salary ) values(" + Attendance_id + ", " + Payroll_date_id + ", " + Profilie_id + ", " + Days_present + ", " + Days_legal_holiday + ", " + Special_non_workingday + ", " + Salary + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_attendance_id()
        {
            myString = "Select coalesce(max(attendance_id), 0) + 1 from dtr_attendance;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getAttendance(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name , b.days_present , b.days_legal_holiday , b.special_non_workingday from employee_profiles a, dtr_attendance b where b.payroll_date_id = '"+Payroll_date_id+"' and b.profilie_id = a.profile_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
