using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
   public class dependent
    {
  //     dependent_id integer NOT NULL,
  //dependent_name character varying(100),
  //birth_date timestamp without time zone,
        int dependent_id;

        public int Dependent_id
        {
            get { return dependent_id; }
            set { dependent_id = value; }
        }
        string dependent_name;

        public string Dependent_name
        {
            get { return dependent_name; }
            set { dependent_name = value; }
        }
        DateTime birth_date;

        public DateTime Birth_date
        {
            get { return birth_date; }
            set { birth_date = value; }
        }
    }
   public class Objdependent : dependent
   {
       bggQueryPgSql myQuery = new bggQueryPgSql();
       string myString;

       public bool Insert()
       {
           myString = "Insert into dependents(dependent_id,dependent_name,birth_date ) values(" + Dependent_id + ",' " + Dependent_name + "','" + Birth_date + "')";
           return myQuery.InsertUpdateDelete(myString);
       }
       public int generate_dependent_id()
       {
           myString = "Select coalesce(max(dependent_id), 0) + 1 from dependents;";
           return int.Parse(myQuery.ViaSingleData(myString));
       }
       public DataGridView getviewddependents(DataGridView mtDgv)
       {
           myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.dependent_name , birth_date from employee_profiles a, dependents b, employee_dependents c where c.dependent_id = b.dependent_id and a.profile_id = c.profile_id;";
           return myQuery.ViaDataGridView(myString, mtDgv);
       }
   }
}
