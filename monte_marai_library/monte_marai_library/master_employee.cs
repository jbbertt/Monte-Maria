using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class master_employee
    {
  //      master_employee_id integer NOT NULL,
  //emp_profile_id integer,
  //emp_work_id integer,
  //emp_gross_earning_id integer,
  //emp_mandatory_deduction_id integer,

        int master_employee_id;

        public int Master_employee_id
        {
            get { return master_employee_id; }
            set { master_employee_id = value; }
        }
        int emp_profile_id;

        public int Emp_profile_id
        {
            get { return emp_profile_id; }
            set { emp_profile_id = value; }
        }
        int emp_work_id;

        public int Emp_work_id
        {
            get { return emp_work_id; }
            set { emp_work_id = value; }
        }
        int emp_gross_earning_id;

        public int Emp_gross_earning_id
        {
            get { return emp_gross_earning_id; }
            set { emp_gross_earning_id = value; }
        }
        int emp_mandatory_deduction_id;

        public int Emp_mandatory_deduction_id
        {
            get { return emp_mandatory_deduction_id; }
            set { emp_mandatory_deduction_id = value; }
        }
    }
    public class Objmaster_employee : master_employee
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into master_employee(master_employee_id , emp_profile_id ,emp_work_id , emp_gross_earning_id,emp_mandatory_deduction_id ) values ( " + Master_employee_id + ", " + Emp_profile_id + "," + Emp_work_id + "," + Emp_gross_earning_id + "," + Emp_mandatory_deduction_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_master_employee_id()
        {
            myString = "Select coalesce(max(master_employee_id), 0) + 1 from master_employee;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
