using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monte_marai_library;
using System.IO;
using FastReport;

namespace MMPSv1._1
{
    public class Print_Payslip
    {
        
        
        FastReport.Report rpt = new Report();
       
    
        public Print_Payslip() 
        {

        }

        public void Design()
        {
            rpt.Design();
        }
    }
}
