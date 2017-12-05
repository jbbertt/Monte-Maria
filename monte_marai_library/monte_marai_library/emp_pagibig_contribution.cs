using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class emp_pagibig_contribution
    {
  //      pag_ibig_mandatory_deduction_id integer NOT NULL,
  //pag_ibig_contribution double precision,
  //employer_contribution double precision,
  //paymode_id integer,

        int pag_ibig_mandatory_deduction_id;

        public int Pag_ibig_mandatory_deduction_id
        {
            get { return pag_ibig_mandatory_deduction_id; }
            set { pag_ibig_mandatory_deduction_id = value; }
        }
        double pag_ibig_contribution;

        public double Pag_ibig_contribution
        {
            get { return pag_ibig_contribution; }
            set { pag_ibig_contribution = value; }
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
    public class Objpagibig_con : emp_pagibig_contribution
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into emp_mandatory_pag_ibig_deduction(pag_ibig_mandatory_deduction_id,pag_ibig_contribution ,employer_contribution ,paymode_id) values(" + Pag_ibig_mandatory_deduction_id + ", '" + Pag_ibig_contribution + "', '" + Employer_contribution + "', '" + Paymode_id + "')";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_pag_ibig_mandatory_deduction_idid()
        {
            myString = "Select coalesce(max(pag_ibig_mandatory_deduction_id), 0) + 1 from emp_mandatory_pag_ibig_deduction;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public int Getpag_ibigPaymode_id()
        {
            myString = "select mode_id from mode where lower(mode_desc) = '" + Paymode_desc.ToLower() + "';";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
