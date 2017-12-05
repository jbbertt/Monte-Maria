using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class od_cash_advances
    {
  //        ca_id integer NOT NULL,
  //ca_amount double precision,
  //ca_granted time without time zone,
  //ca_deduction_per_payroll double precision,
  //profile_id integer,

        int ca_id;

        public int Ca_id
        {
            get { return ca_id; }
            set { ca_id = value; }
        }
        double ca_amount;

        public double Ca_amount
        {
            get { return ca_amount; }
            set { ca_amount = value; }
        }
        DateTime ca_granted;

        public DateTime Ca_granted
        {
            get { return ca_granted; }
            set { ca_granted = value; }
        }
        double ca_deduction_per_payroll;

        public double Ca_deduction_per_payroll
        {
            get { return ca_deduction_per_payroll; }
            set { ca_deduction_per_payroll = value; }
        }
        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }
    }
    public class Objod_cash_advances : od_cash_advances
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into od_cash_advances(ca_id , ca_amount , ca_granted,ca_deduction_per_payroll,profile_id) values(" + Ca_id + ", " + Ca_amount + ", '" + Ca_granted + "' , " + Ca_deduction_per_payroll + " ," + Profile_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_ca_id()
        {
            myString = "Select coalesce(max(ca_id), 0) + 1 from od_cash_advances;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getviewOD_CA(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.ca_amount, b.ca_granted ,b.ca_deduction_per_payroll from employee_profiles a, od_cash_advances b	 where  b.profile_id = a.profile_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
