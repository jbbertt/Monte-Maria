using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monte_marai_library
{
   public class deductions
    {
  //     deduction_id integer NOT NULL,
  //profile_id integer,
  //sss_contribution double precision,
  //pagibig_contribution double precision,
  //philhealth_contribution double precision,
  //od_ca double precision,
  //od_eggs double precision,
  //od_hcard double precision,
  //od_hmo double precision,
  //od_phic double precision,
  //od_tin double precision,
  //od_uniform double precision,
  //od_vehicle double precision,
  //loan_sss double precision,
  //loan_pagibig double precision,

        int deduction_id;

        public int Deduction_id
        {
            get { return deduction_id; }
            set { deduction_id = value; }
        }
        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }
        double sss_contribution;

        public double Sss_contribution
        {
            get { return sss_contribution; }
            set { sss_contribution = value; }
        }
        double pagibig_contribution;

        public double Pagibig_contribution
        {
            get { return pagibig_contribution; }
            set { pagibig_contribution = value; }
        }
        double philhealth_contribution;

        public double Philhealth_contribution
        {
            get { return philhealth_contribution; }
            set { philhealth_contribution = value; }
        }
        double od_ca;

        public double Od_ca
        {
            get { return od_ca; }
            set { od_ca = value; }
        }
        double od_eggs;

        public double Od_eggs
        {
            get { return od_eggs; }
            set { od_eggs = value; }
        }
        double od_hcard;

        public double Od_hcard
        {
            get { return od_hcard; }
            set { od_hcard = value; }
        }
        double od_hmo;

        public double Od_hmo
        {
            get { return od_hmo; }
            set { od_hmo = value; }
        }
        double od_phic;

        public double Od_phic
        {
            get { return od_phic; }
            set { od_phic = value; }
        }
        double od_tin;

        public double Od_tin
        {
            get { return od_tin; }
            set { od_tin = value; }
        }
        double od_uniform;

        public double Od_uniform
        {
            get { return od_uniform; }
            set { od_uniform = value; }
        }
        double od_vehicle;

        public double Od_vehicle
        {
            get { return od_vehicle; }
            set { od_vehicle = value; }
        }
        double loan_sss;

        public double Loan_sss
        {
            get { return loan_sss; }
            set { loan_sss = value; }
        }
        double loan_pagibig;

        public double Loan_pagibig
        {
            get { return loan_pagibig; }
            set { loan_pagibig = value; }
        }
        int mode_id;

        public int Mode_id
        {
            get { return mode_id; }
            set { mode_id = value; }
        }


    }
}
