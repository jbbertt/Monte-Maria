using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
   public class loan_sss
    {
  //     loan_id integer NOT NULL,
  //sss_loan_amount double precision,
  //loan_dategranted timestamp without time zone,
  //loan_deduction_mode integer,
  //loan_amount_deducted double precision,
  //loan_deduction_start timestamp without time zone,
  //profile_id integer

        int loan_id;

        public int Loan_id
        {
            get { return loan_id; }
            set { loan_id = value; }
        }
        double sss_loan_amount;

        public double Sss_loan_amount
        {
            get { return sss_loan_amount; }
            set { sss_loan_amount = value; }
        }
        DateTime loan_dategranted;

        public DateTime Loan_dategranted
        {
            get { return loan_dategranted; }
            set { loan_dategranted = value; }
        }
        int loan_deduction_mode;

        public int Loan_deduction_mode
        {
            get { return loan_deduction_mode; }
            set { loan_deduction_mode = value; }
        }
        double loan_amount_deducted;

        public double Loan_amount_deducted
        {
            get { return loan_amount_deducted; }
            set { loan_amount_deducted = value; }
        }
        DateTime loan_deduction_start;

        public DateTime Loan_deduction_start
        {
            get { return loan_deduction_start; }
            set { loan_deduction_start = value; }
        }
        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }
        string employee_sss_id;

        public string Employee_sss_id
        {
            get { return employee_sss_id; }
            set { employee_sss_id = value; }
        }
    }
   public class Objloan_sss : loan_sss
   {
       bggQueryPgSql myQuery = new bggQueryPgSql();
       string myString;

       public bool Insert()
       {
           myString = "Insert into loan_sss(loan_id,sss_loan_amount,loan_dategranted,loan_deduction_mode,loan_amount_deducted,loan_deduction_start,profile_id,employee_sss_id ) values(" + Loan_id + ", " + Sss_loan_amount + ", '" + Loan_dategranted + "', " + Loan_deduction_mode + ", " + Loan_amount_deducted + ", '" + Loan_deduction_start + "', " + Profile_id + ",'" + Employee_sss_id + "')";
           return myQuery.InsertUpdateDelete(myString);
       }

       public int generate_loan_id()
       {
           myString = "Select coalesce(max(loan_id), 0) + 1 from loan_sss;";
           return int.Parse(myQuery.ViaSingleData(myString));
       }
       public DataGridView getViewSSSLoan(DataGridView mtDgv)
       {
           myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.sss_loan_amount , b.loan_dategranted from employee_profiles a, loan_sss b where b.profile_id = a.profile_id";
           return myQuery.ViaDataGridView(myString, mtDgv);
       }

       public DataGridView getViewAllsssLoan(DataGridView mtDgv)
       {
           myString = "select initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.sss_loan_amount, b.loan_dategranted ,b.loan_amount_deducted ,b.loan_deduction_start , b.employee_sss_id , c.mode_desc as deduction_mode from employee_profiles a, loan_sss b,	 mode c where c.mode_id = b.loan_deduction_mode and  b.profile_id = a.profile_id ";
           return myQuery.ViaDataGridView(myString, mtDgv);
       }

       public DataGridView getViewSearchsssLoan(DataGridView mtDgv)
       {
           myString = "select distinct initcap(a.last_name)||', '||initcap(a.first_name)||' '||' ' as employee_name, b.sss_loan_amount, b.loan_dategranted ,b.loan_amount_deducted ,b.loan_deduction_start , b.employee_sss_id , c.mode_desc as deduction_mode from employee_profiles a, loan_sss b, mode c where b.profile_id = '"+ Profile_id+"' and b.profile_id = a.profile_id and b.loan_deduction_mode = c.mode_id ";
           return myQuery.ViaDataGridView(myString, mtDgv);
       }
   }
}
