using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class citezenship
    {
  //      citezenship_id integer NOT NULL,
  //citezenship_desc character varying(20),
  //CONSTRAINT citezenship_pkey PRIMARY KEY (citezenship_id)

        int citezenship_id;

        public int Citezenship_id
        {
            get { return citezenship_id; }
            set { citezenship_id = value; }
        }
        string citezenship_desc;

        public string Citezenship_desc
        {
            get { return citezenship_desc; }
            set { citezenship_desc = value; }
        }
      
    }
    public class Objcitezenship : citezenship
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into citezenship(citezenship_id,citezenship_desc ) values(" + Citezenship_id + ", '" + Citezenship_desc + "')";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_citezen_id()
        {
            myString = "Select coalesce(max(citezenship_id), 0) + 1 from citezenship;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
        public ComboBox GetCitezenship(ComboBox myCmb)
        {
            myString = "Select initcap(citezenship_desc) from citezenship;";
            return myQuery.ViaComboBox(myString, myCmb);
        }
        public int GetCitezenId()
        {
            myString = "select citezenship_id from citezenship where lower(citezenship_desc) = '" + Citezenship_desc.ToLower() + "';";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
