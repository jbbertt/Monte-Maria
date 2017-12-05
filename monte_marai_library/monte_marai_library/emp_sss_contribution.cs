using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
   public class emp_sss_contribution
    {
 

        int sss_mandatory_deduction_id;

        public int Sss_mandatory_deduction_id
        {
            get { return sss_mandatory_deduction_id; }
            set { sss_mandatory_deduction_id = value; }
        }
        double sss_contribution;

        public double Sss_contribution
        {
            get { return sss_contribution; }
            set { sss_contribution = value; }
        }
        double employer_contribution;

        public double Employer_contribution
        {
            get { return employer_contribution; }
            set { employer_contribution = value; }
        }
        int paymode_id;

        public int Paymode_id
        {
            get { return paymode_id; }
            set { paymode_id = value; }
        }
        string paymode_desc;

        public string Paymode_desc
        {
            get { return paymode_desc; }
            set { paymode_desc = value; }
        }
   
    }
   public class Objsss_con : emp_sss_contribution
   {
       bggQueryPgSql myQuery = new bggQueryPgSql();
       string myString;

       public bool Insert()
       {
           myString = "Insert into emp_mandatory_sss_deduction(sss_mandatory_deduction_id,sss_contribution ,employer_contribution ,paymode_id) values(" + Sss_mandatory_deduction_id + ", '" + Sss_contribution + "', '" + Employer_contribution + "', '" + Paymode_id + "')";
           return myQuery.InsertUpdateDelete(myString);
       }
       public int generate_sss_mandatory_deduction_id_id()
       {
           myString = "Select coalesce(max(sss_mandatory_deduction_id), 0) + 1 from emp_mandatory_sss_deduction;";
           return int.Parse(myQuery.ViaSingleData(myString));
       }

       public int GetsssPaymode_id()
       {
           myString = "select mode_id from mode where lower(mode_desc) = '" + Paymode_desc.ToLower() + "';";
           return int.Parse(myQuery.ViaSingleData(myString));
       }
   }
}
