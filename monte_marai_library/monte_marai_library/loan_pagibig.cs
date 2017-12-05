using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class loan_pagibig
    {
  //        pagibig_loan_id integer NOT NULL,
  //profile_id integer,
  //loan_amount double precision,
  //loan_granted timestamp without time zone,
  //loan_deduc_mode integer,
  //loan_deduction_amount double precision,
  //loan_deduction_starts timestamp with time zone,

        int pagibig_loan_id;

        public int Pagibig_loan_id
        {
            get { return pagibig_loan_id; }
            set { pagibig_loan_id = value; }
        }
        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }
        double loan_amount;

        public double Loan_amount
        {
            get { return loan_amount; }
            set { loan_amount = value; }
        }
        DateTime loan_granted;

        public DateTime Loan_granted
        {
            get { return loan_granted; }
            set { loan_granted = value; }
        }
        int loan_deduc_mode;

        public int Loan_deduc_mode
        {
            get { return loan_deduc_mode; }
            set { loan_deduc_mode = value; }
        }
        double loan_deduction_amount;

        public double Loan_deduction_amount
        {
            get { return loan_deduction_amount; }
            set { loan_deduction_amount = value; }
        }
        DateTime loan_deduction_starts;

        public DateTime Loan_deduction_starts
        {
            get { return loan_deduction_starts; }
            set { loan_deduction_starts = value; }
        }

        string employee_pagibig_id;

        public string Employee_pagibig_id
        {
            get { return employee_pagibig_id; }
            set { employee_pagibig_id = value; }
        }
    }
    public class Objloan_pagibig : loan_pagibig
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into loan_pagibig(pagibig_loan_id,profile_id,loan_amount,loan_granted,loan_deduc_mode,loan_deduction_amount,loan_deduction_starts,employee_pagibig_id ) values(" + Pagibig_loan_id + ", " + Profile_id + ", " + Loan_amount + ", '" + Loan_granted + "', " + Loan_deduc_mode + ", " + Loan_deduction_amount + ", '" + Loan_deduction_starts + "', '" +Employee_pagibig_id + "')";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_pagibig_loan_id()
        {
            myString = "Select coalesce(max(pagibig_loan_id), 0) + 1 from loan_pagibig;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getViewPagibigLoan(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.loan_amount , b.loan_granted from employee_profiles a, loan_pagibig b where b.profile_id = a.profile_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        public DataGridView getViewallPagibigLoan(DataGridView mtDgv)
        {
            myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.loan_amount, b.loan_granted ,b.loan_deduction_amount ,b.loan_deduction_starts , b.employee_pagibig_id , c.mode_desc as deduction_mode from employee_profiles a,loan_pagibig b, mode c where  c.mode_id = b.loan_deduc_mode and b.profile_id = a.profile_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        public DataGridView getViewSearchPagibigLoan(DataGridView mtDgv)
        {
            myString = "select distinct initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.loan_amount, b.loan_granted ,b.loan_deduction_amount ,b.loan_deduction_starts , b.employee_pagibig_id , c.mode_desc as deduction_mode from employee_profiles a,loan_pagibig b,mode c where  b.profile_id = '"+ Profile_id+"' and b.profile_id = a.profile_id and b.loan_deduc_mode = c.mode_id";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
    }
}
