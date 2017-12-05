using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class employee_mandatory_deductions
    {
  //      emp_mandatory_deduction_id integer NOT NULL,
  //sss_madatory_deduction_id integer,
  //pag_ibig_mandatory_deduction_id integer,
  //philhealth_deduction_id integer,
        int emp_mandatory_deduction_id;

        public int Emp_mandatory_deduction_id
        {
            get { return emp_mandatory_deduction_id; }
            set { emp_mandatory_deduction_id = value; }
        }
        int sss_madatory_deduction_id;

        public int Sss_madatory_deduction_id
        {
            get { return sss_madatory_deduction_id; }
            set { sss_madatory_deduction_id = value; }
        }
        int pag_ibig_mandatory_deduction_id;

        public int Pag_ibig_mandatory_deduction_id
        {
            get { return pag_ibig_mandatory_deduction_id; }
            set { pag_ibig_mandatory_deduction_id = value; }
        }
        int philhealth_deduction_id;

        public int Philhealth_deduction_id
        {
            get { return philhealth_deduction_id; }
            set { philhealth_deduction_id = value; }
        }
    }
    public class Objmandatory_deduction : employee_mandatory_deductions
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into emp_madatory_deduction(emp_mandatory_deduction_id , sss_madatory_deduction_id ,pag_ibig_mandatory_deduction_id , philhealth_deduction_id ) values ( " + Emp_mandatory_deduction_id + ", " + Sss_madatory_deduction_id + "," + Pag_ibig_mandatory_deduction_id + "," + Philhealth_deduction_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_emp_mandatory_deduction_id()
        {
            myString = "Select coalesce(max(emp_mandatory_deduction_id), 0) + 1 from emp_madatory_deduction;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
