using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;


namespace monte_marai_library
{
    public class login
    {
  //login_id integer NOT NULL,
  //username character varying(100),
  //password character varying(100),
        int login_id;

        public int Login_id
        {
            get { return login_id; }
            set { login_id = value; }
        }
        String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }
    public class Objlogin : login
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;



        public string getusername()
        {
            myString = "select username from login where username = '" + Username + "';";

            return myQuery.ViaSingleData(myString);

        }

        public string getpassword()
        {
            myString = "select password from login where password = '" + Password + "';";

            return myQuery.ViaSingleData(myString);

        }

    }
}
