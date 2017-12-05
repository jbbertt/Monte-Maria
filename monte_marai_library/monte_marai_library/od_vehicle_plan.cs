using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class od_vehicle_plan
    {
  //        vehicle_plan_id integer NOT NULL,
  //vehicle_payable double precision,
  //date_granted timestamp without time zone,
  //mode_id integer,
  //amount_deducted double precision,
  //deduction_start timestamp without time zone,
  //profile_id integer,

        int vehicle_plan_id;

        public int Vehicle_plan_id
        {
            get { return vehicle_plan_id; }
            set { vehicle_plan_id = value; }
        }
        double vehicle_payable;

        public double Vehicle_payable
        {
            get { return vehicle_payable; }
            set { vehicle_payable = value; }
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
    public class Objvehicle_plan : od_vehicle_plan
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into od_vehicle_plan(vehicle_plan_id , vehicle_payable , date_granted,mode_id,amount_deducted,deduction_start,profile_id) values(" + Vehicle_plan_id + ", " + Vehicle_payable + ", '" + Date_granted + "' , " + Mode_id + ", " + Amount_deducted + ", '" + Deduction_start + "' ," + Profile_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_vehicle_plan_id()
        {
            myString = "Select coalesce(max(vehicle_plan_id), 0) + 1 from od_vehicle_plan;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getviewOD_vehicle(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.vehicle_payable, b.date_granted ,b.amount_deducted ,b.deduction_start , c.mode_desc from employee_profiles a, od_vehicle_plan b,	mode c where  c.mode_id = b.mode_id and  b.profile_id = a.profile_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
