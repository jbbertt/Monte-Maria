using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using bggPgSql;

namespace MMPSv1._1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bggQueryPgSql conn = new bggQueryPgSql();
            conn.StartConnectionIni("" + Application.StartupPath + "/connection.ini");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new main_form());
           Application.Run(new login());
           // Application.Run(new PaymentMode_form());
           // Application.Run(new Add_employee_form());
        }
    }
}
