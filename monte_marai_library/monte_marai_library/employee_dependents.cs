using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class employee_dependents
    {
  //      dependent_id integer NOT NULL,
  //profile_id integer,
        int dependent_id;

        public int Dependent_id
        {
            get { return dependent_id; }
            set { dependent_id = value; }
        }
        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }
    }
    public class Objemployee_dependent : employee_dependents
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into employee_dependents(dependent_id,profile_id ) values(" + Dependent_id + ", " + Profile_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

    }
}
