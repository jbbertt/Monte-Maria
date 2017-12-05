using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class od_health_card
    {
        
 
  //health_card_id integer NOT NULL,
  //amount double precision,
  //date_granted time without time zone,
  //mode_id integer,
  //amount_deducted double precision,
  //deduction_start time without time zone,
  //profile_id integer,

        int health_card_id;

        public int Health_card_id
        {
            get { return health_card_id; }
            set { health_card_id = value; }
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
    public class Objod_health_card : od_health_card
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into od_health_card(health_card_id,amount,date_granted,mode_id,amount_deducted,deduction_start,profile_id ) values(" + Health_card_id + ", " + Amount + ", '" + Date_granted + "', " + Mode_id + ", " + Amount_deducted + ", '" + Deduction_start + "', " + Profile_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_health_card_id()
        {
            myString = "Select coalesce(max(health_card_id), 0) + 1 from od_health_card;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getviewOD_Hcard(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.amount, b.date_granted ,b.amount_deducted ,b.deduction_start , c.mode_desc as deduction_mode from employee_profiles a, od_health_card b,	 mode c where c.mode_id = b.mode_id and b.profile_id = a.profile_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
