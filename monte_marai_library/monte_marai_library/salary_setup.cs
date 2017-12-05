using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class salary_setup
    {
  //setup_salary_id integer NOT NULL,
  //status_id integer,
  //position_id integer,
  //mode_id integer,
  //basic_pay integer,
  //department_d integer,

        int setup_salary_id;

        public int Setup_salary_id
        {
            get { return setup_salary_id; }
            set { setup_salary_id = value; }
        }
        int status_id;

        public int Status_id
        {
            get { return status_id; }
            set { status_id = value; }
        }
        int position_id;

        public int Position_id
        {
            get { return position_id; }
            set { position_id = value; }
        }
        int mode_id;

        public int Mode_id
        {
            get { return mode_id; }
            set { mode_id = value; }
        }
        int basic_pay;

        public int Basic_pay
        {
            get { return basic_pay; }
            set { basic_pay = value; }
        }
        int department_id;

        public int Department_id
        {
            get { return department_id; }
            set { department_id = value; }
        }
    }

    public class Objsetup : salary_setup
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {

            myString = "Insert into salary_setup(setup_salary_id,status_id,position_id,mode_id,basic_pay,department_id) values(" + Setup_salary_id + ", " + Status_id + ", " + Position_id + ", " + Mode_id + ", " + Basic_pay + ", " + Department_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_setup_salary_id()
        {
            myString = "Select coalesce(max(setup_salary_id), 0) + 1 from salary_setup;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getviewsalary(DataGridView mtDgv)
        {
            myString = "select a.department_decs , b.position_decs , c.mode_desc , d.status_desc , e.basic_pay from department a, position b, mode c, status d, salary_setup e where e.department_id = a.department_id and b.position_id = e.position_id and e.mode_id = c.mode_id and e.status_id = d.status_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
