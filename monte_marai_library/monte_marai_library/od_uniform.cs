using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class od_uniform
    {
  //      uniform_id integer NOT NULL,
  //amount double precision,
  //date_granted time without time zone,
  //mode_id integer,
  //amount_deducted double precision,
  //deduction_start time without time zone,

        int uniform_id;

        public int Uniform_id
        {
            get { return uniform_id; }
            set { uniform_id = value; }
        }
        double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        DateTime date_granted;

        public DateTime Date_granted
        {
            get { return date_granted; }
            set { date_granted = value; }
        }
        int mode_id;

        public int Mode_id
        {
            get { return mode_id; }
            set { mode_id = value; }
        }
        double amount_deducted;

        public double Amount_deducted
        {
            get { return amount_deducted; }
            set { amount_deducted = value; }
        }
        DateTime deduction_start;

        public DateTime Deduction_start
        {
            get { return deduction_start; }
            set { deduction_start = value; }
        }
        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }
    }


    public class Objod_uniform : od_uniform
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into od_uniform(uniform_id , amount , date_granted,mode_id,amount_deducted,deduction_start,profile_id) values(" + Uniform_id + ", " + Amount + ", '" + Date_granted + "' , " + Mode_id + " ," + Amount_deducted + ",'" + Deduction_start + "', " + Profile_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_uniform_id()
        {
            myString = "Select coalesce(max(uniform_id), 0) + 1 from od_uniform;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getviewOD_Uniform(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.ca_amount, b.ca_granted ,b.ca_deduction_per_payroll from employee_profiles a, od_cash_advances b	 where  b.profile_id = a.profile_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
