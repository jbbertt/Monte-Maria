using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class employee_gross_earnings
    {
  //        emp_gross_earning_id integer NOT NULL,
  //basic_pay double precision,
  //daily_rate double precision,
  //legal_holiday_rate double precision,
  //special_holiday_rate double precision,

        int emp_gross_earning_id;

        public int Emp_gross_earning_id
        {
            get { return emp_gross_earning_id; }
            set { emp_gross_earning_id = value; }
        }
        double basic_pay;

        public double Basic_pay
        {
            get { return basic_pay; }
            set { basic_pay = value; }
        }
        double daily_rate;

        public double Daily_rate
        {
            get { return daily_rate; }
            set { daily_rate = value; }
        }
        double legal_holiday_rate;

        public double Legal_holiday_rate
        {
            get { return legal_holiday_rate; }
            set { legal_holiday_rate = value; }
        }
        double special_holiday_rate;

        public double Special_holiday_rate
        {
            get { return special_holiday_rate; }
            set { special_holiday_rate = value; }
        }

    }

    public class Objgross_earning : employee_gross_earnings
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into employee_gross_earnings(emp_gross_earning_id , basic_pay ,daily_rate , legal_holiday_rate , special_holiday_rate ) values ( " + Emp_gross_earning_id + ", " + Basic_pay + "," + Daily_rate + "," + Legal_holiday_rate + "," + Special_holiday_rate + ")";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_emp_gross_earning_id()
        {
            myString = "Select coalesce(max(emp_gross_earning_id), 0) + 1 from employee_gross_earnings;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
