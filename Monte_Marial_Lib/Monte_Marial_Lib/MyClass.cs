/*
 * Created by SharpDevelop.
 * User: jazzybert26
 * Date: 10/7/2017
 * Time: 4:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using bggPgSql;
using Npgsql;

namespace Monte_Marial_Lib
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class log_in
	{
		string username;
		
		public string Username {
			get { return username; }
			set { username = value; }
		}
		string password;
		
		public string Password {
			get { return password; }
			set { password = value; }
		}
		string role;
		
		public string Role {
			get { return role; }
			set { role = value; }
		}
		
	}
	    public class Objlog_in : log_in
	    {
	    bggQueryPgSql query = new bggQueryPgSql();
        string myString;
        
        public bool Log_in(string username, password)
        {
        	myString = "Select role from log_in where username = '"+username+"' and password = '"+password+"'";
        	return query.ViaSingleData(myString);
        	
        }
        
        
        
	    }
}