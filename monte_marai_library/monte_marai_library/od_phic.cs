using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class od_phic
    {
  //       phic_id integer NOT NULL,
  //phic_employee_contribution double precision,
  //phic_employer_contribution double precision,
  //phic_no integer,
  //phic_mode integer,

        int phic_id;

        public int Phic_id
        {
            get { return phic_id; }
            set { phic_id = value; }
        }
        double phic_employee_contribution;

        public double Phic_employee_contribution
        {
            get { return phic_employee_contribution; }
            set { phic_employee_contribution = value; }
        }
        double phic_employer_contribution;

        public double Phic_employer_contribution
        {
            get { return phic_employer_contribution; }
            set { phic_employer_contribution = value; }
        }
        int phic_mode;

        public int Phic_mode
        {
            get { return phic_mode; }
            set { phic_mode = value; }
        }
        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }
    }
    public class Objod_phic : od_phic
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into od_phic(phic_id,phic_employee_contribution,phic_employer_contribution,phic_mode,profile_id ) values(" + Phic_id + ", " + Phic_employee_contribution + ", " + Phic_employer_contribution + ", " + Phic_mode + ", " + Profile_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_phic_id()
        {
            myString = "Select coalesce(max(phic_id), 0) + 1 from od_phic;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getviewOD_phic(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.phic_employee_contribution , c.mode_desc from employee_profiles a, od_phic b, mode c where  c.mode_id = b.phic_mode and  b.profile_id = a.profile_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
