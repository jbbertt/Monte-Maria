using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
   public class civil_status
    {
  //     civil_status_id integer NOT NULL,
  //civil_status_desc character varying(30),
  //CONSTRAINT civil_status_pkey PRIMARY KEY (civil_status_id)

        int civil_status_id;

        public int Civil_status_id
        {
            get { return civil_status_id; }
            set { civil_status_id = value; }
        }
        string civil_status_desc;

        public string Civil_status_desc
        {
            get { return civil_status_desc; }
            set { civil_status_desc = value; }
        }
    }
   public class Objcivil_status : civil_status
   {
       bggQueryPgSql myQuery = new bggQueryPgSql();
       string myString;

       public bool Insert()
       {
           myString = "Insert into civil_status(civil_status_id,civil_status_desc ) values(" + Civil_status_id + ", '" + Civil_status_desc + "')";
           return myQuery.InsertUpdateDelete(myString);
       }
       public int generate_civil_status_id()
       {
           myString = "Select coalesce(max(civil_status_id), 0) + 1 from civil_status;";
           return int.Parse(myQuery.ViaSingleData(myString));
       }
       public ComboBox Getcivil_status(ComboBox myCmb)
       {
           myString = "Select initcap(civil_status_desc) from civil_status;";
           return myQuery.ViaComboBox(myString, myCmb);
       }
       public int GetCivil_status_id()
       {
           myString = "select civil_status_id from civil_status where lower(civil_status_desc ) = '" + Civil_status_desc.ToLower() + "';";
           return int.Parse(myQuery.ViaSingleData(myString));
       }
   }
}
