using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class od_tin
    {
  //      tin_id integer NOT NULL,
  //withholding_taax_rate double precision,
  //tin_mode integer,

        int tin_id;

        public int Tin_id
        {
            get { return tin_id; }
            set { tin_id = value; }
        }
        double withholding_taax_rate;

        public double Withholding_taax_rate
        {
            get { return withholding_taax_rate; }
            set { withholding_taax_rate = value; }
        }
        int tin_mode;

        public int Tin_mode
        {
            get { return tin_mode; }
            set { tin_mode = value; }
        }
        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }
    }

    public class Objod_tin : od_tin
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into od_tin(tin_id , withholding_taax_rate , tin_mode, profile_id) values(" + Tin_id + ", " + Withholding_taax_rate + ", " + Tin_mode + ", " + Profile_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_tin_id()
        {
            myString = "Select coalesce(max(tin_id), 0) + 1 from od_tin;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getviewOD_tin(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.withholding_taax_rate , c.mode_desc from employee_profiles a, od_tin b,	 mode c where  c.mode_id = b.tin_mode and  b.profile_id = a.profile_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
