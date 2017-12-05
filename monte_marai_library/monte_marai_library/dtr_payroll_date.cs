using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class dtr_payroll_date
    {
  //       payroll_date_id integer,
  //payroll_date time without time zone

        int payroll_date_id;

        public int Payroll_date_id
        {
            get { return payroll_date_id; }
            set { payroll_date_id = value; }
        }
        DateTime payroll_date;

        public DateTime Payroll_date
        {
            get { return payroll_date; }
            set { payroll_date = value; }
        }
    }
    public class Objdtr_payroll_date : dtr_payroll_date
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into dtr_payroll_date(payroll_date_id,payroll_date ) values(" + Payroll_date_id + ", '" + Payroll_date + "')";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_payroll_date_id()
        {
            myString = "Select coalesce(max(payroll_date_id), 0) + 1 from dtr_payroll_date;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public ComboBox GetDates(ComboBox myTb)
        {
            myString = "Select payroll_date from dtr_payroll_date order by payroll_date";
            return myQuery.ViaComboBox(myString, myTb);
        }

        public int GetDateId()
        {
            myString = " select payroll_date_id  from dtr_payroll_date where payroll_date = '" + Payroll_date + "';";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getViewPayrollDate(DataGridView mtDgv)
        {
            myString = "select * from dtr_payroll_date";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
