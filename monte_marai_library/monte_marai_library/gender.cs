using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class gender
    {
  //      gender_id integer NOT NULL,
  //gender_desc character varying(20),
  //CONSTRAINT gender_pkey PRIMARY KEY (gender_id)

        int gender_id;

        public int Gender_id
        {
            get { return gender_id; }
            set { gender_id = value; }
        }
        string gender_desc;

        public string Gender_desc
        {
            get { return gender_desc; }
            set { gender_desc = value; }
        }
    }
    public class Objgender : gender
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into gender(gender_id,gender_desc ) values(" + Gender_id + ", '" + Gender_desc + "')";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_gender_id()
        {
            myString = "Select coalesce(max(gender_id), 0) + 1 from gender;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
        public ComboBox GetGender(ComboBox myCmb)
        {
            myString = "Select initcap(gender_desc) from gender;";
            return myQuery.ViaComboBox(myString, myCmb);
        }
        public int GetGenderId()
        {
            myString = "select gender_id from gender where lower(gender_desc) = '" + Gender_desc.ToLower() + "';";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
