/*
 * Created by SharpDevelop.
 * User: jazzybert26
 * Date: 10/7/2017
 * Time: 3:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using bggPgSql;

namespace Monte_Maria_Payroll_System
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			bggQueryPgSql conn = new bggQueryPgSql();
            conn.StartConnectionIni("" + Application.StartupPath + "/connection.ini");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new MainForm());
			Application.Run(new log_in_form());
		}
		
	}
}
