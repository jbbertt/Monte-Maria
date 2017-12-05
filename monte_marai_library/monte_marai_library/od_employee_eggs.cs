using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class od_employee_eggs
    {
  //      eggs_id integer NOT NULL,
  //invoice_no character varying(20),
  //date time without time zone,
  //amount double precision,
        int eggs_id;

        public int Eggs_id
        {
            get { return eggs_id; }
            set { eggs_id = value; }
        }
        string invoice_no;

        public string Invoice_no
        {
            get { return invoice_no; }
            set { invoice_no = value; }
        }
        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }
    }
    public class Objod_employee_eggs : od_employee_eggs
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into od_employee_eggs(eggs_id,invoice_no,date,amount,profile_id ) values(" + Eggs_id + ", '" + Invoice_no + "', '" + Date + "', " + Amount + ", " + Profile_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_eggs_id()
        {
            myString = "Select coalesce(max(eggs_id), 0) + 1 from od_employee_eggs;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
        public DataGridView getviewOD_Eggs(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.amount, b.invoice_no ,b.date from employee_profiles a, od_employee_eggs b where  b.profile_id = a.profile_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
