using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class emp_philheath_contribution
    {
  //      philhealth_contribution_id integer NOT NULL,
  //philhealth_contribution double precision,
  //employer_contribution double precision,
  //philhealth_paymode_id integer

        int philhealth_contribution_id;

        public int Philhealth_contribution_id
        {
            get { return philhealth_contribution_id; }
            set { philhealth_contribution_id = value; }
        }
        double philhealth_contribution;

        public double Philhealth_contribution
        {
            get { return philhealth_contribution; }
            set { philhealth_contribution = value; }
        }
        double employer_contribution;

        public double Employer_contribution
        {
            get { return employer_contribution; }
            set { employer_contribution = value; }
        }
        int philhealth_paymode_id;

        public int Philhealth_paymode_id
        {
            get { return philhealth_paymode_id; }
            set { philhealth_paymode_id = value; }
        }
        string paymode_desc;

        public string Paymode_desc
        {
            get { return paymode_desc; }
            set { paymode_desc = value; }
        }
    }
    public class Objphilhealth : emp_philheath_contribution
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into emp_mandatory_philhealth_deduction(philhealth_contribution_id, philhealth_contribution ,employer_contribution , philhealth_paymode_id) values(" + Philhealth_contribution_id + ", '" + Philhealth_contribution + "', '" + Employer_contribution + "', '" + Philhealth_paymode_id + "')";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_philhealth_contribution_deduction_id()
        {
            myString = "Select coalesce(max(philhealth_contribution_id), 0) + 1 from emp_mandatory_philhealth_deduction;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public int GetphilhealthPaymode_id()
        {
            myString = "select mode_id from mode where lower(mode_desc) = '" + Paymode_desc.ToLower() + "';";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
