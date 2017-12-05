using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class employee_profiles
    {
 

        int profile_id;

        public int Profile_id
        {
            get { return profile_id; }
            set { profile_id = value; }
        }
        string first_name;

        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }
        string last_name;

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }
        string midle_initial;

        public string Midle_initial
        {
            get { return midle_initial; }
            set { midle_initial = value; }
        }
        string suffix;

        public string Suffix
        {
            get { return suffix; }
            set { suffix = value; }
        }
        DateTime birthdate;

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        int gender_id;

        public int Gender_id
        {
            get { return gender_id; }
            set { gender_id = value; }
        }
        int citezenship_id;

        public int Citezenship_id
        {
            get { return citezenship_id; }
            set { citezenship_id = value; }
        }
        int civil_status_id;

        public int Civil_status_id
        {
            get { return civil_status_id; }
            set { civil_status_id = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string mother_name;

        public string Mother_name
        {
            get { return mother_name; }
            set { mother_name = value; }
        }
        string fathers_name;

        public string Fathers_name
        {
            get { return fathers_name; }
            set { fathers_name = value; }
        }
        string spouse_name;

        public string Spouse_name
        {
            get { return spouse_name; }
            set { spouse_name = value; }
        }
    }
    public class Objemployee_profiles : employee_profiles
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        //      profile_id integer NOT NULL,
        //first_name character varying(50),
        //last_name character varying(50),
        //midle_initial character varying(20),
        //suffix character varying(10),
        //birthdate timestamp without time zone,
        //gender_id integer,
        //citezenship_id integer,
        //civil_status_id integer,
        //address character varying(100),
        //mother_name character varying(100),
        //fathers_name character varying(100),
        public bool Insert()
        {
            myString = "Insert into employee_profiles(profile_id,first_name,last_name,midle_initial,suffix,birthdate,gender_id,citezenship_id,civil_status_id,address,mother_name,fathers_name,spouse_name ) values(" + Profile_id + ", '" + First_name + "', '" + Last_name + "' , '" + Midle_initial + "', '" + Suffix + "', '" + Birthdate + "', " + Gender_id + ", " + Citezenship_id + ", " + Civil_status_id + ", '" + Address + "', '" + Mother_name + "', '" + Fathers_name + "', '" + Spouse_name + "')";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_profile_id()
        {
            myString = "Select coalesce(max(profile_id), 0) + 1 from employee_profiles;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public TextBox GetProfiles(TextBox myTb)
        {
            myString = "Select initcap(last_name)||', '||initcap(first_name)||' '||' ' from employee_profiles order by last_name";
            return myQuery.ViaTextbox_AutoCompleteCustomSource(myString, myTb);
        }
        public string GetProfileIDusingname(string name)
        {//Sebial, Roosevelt E
            //name = name.ToLower();
            string lname = null;
            string fname = null;
            bool a = true;
            foreach (char i in name)
            {
                if (a)
                {

                    if (i == ',')
                    {
                        a = false;
                    }
                    else
                    {
                        lname += i.ToString();
                    }
                }
                else
                {
                    fname += i.ToString();
                }
            }

            fname = fname.Remove(0, 1);
            fname = fname.Remove(fname.Length - 2, 2);
            string mi = name[name.Length - 1].ToString();



            Last_name = lname;
            First_name = fname;
            //Emp_mi = mi;
            myString = "Select profile_id from employee_profiles where last_name ='" + Last_name + "' and first_name = '" + First_name + "' ";
            return myQuery.ViaSingleData(myString);
        }
    }
}
