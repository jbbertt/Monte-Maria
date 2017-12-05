using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monte_marai_library;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class mode
    {
  //mode_id integer NOT NULL,
  //mode_desc character varying(150),

        int mode_id;

        public int Mode_id
        {
            get { return mode_id; }
            set { mode_id = value; }
        }
        string mode_desc;

        public string Mode_desc
        {
            get { return mode_desc; }
            set { mode_desc = value; }
        }
    }
    public class Objmode : mode
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into mode(mode_id,mode_desc ) values(" + Mode_id + ", '" + Mode_desc + "')";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_mode_id()
        {
            myString = "Select coalesce(max(mode_id), 0) + 1 from mode;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getviewmode(DataGridView mtDgv)
        {
            myString = "select * from mode";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        public ComboBox GetModeName(ComboBox myCmb)
        {
            myString = "Select initcap(mode_desc) from mode;";
            return myQuery.ViaComboBox(myString, myCmb);
        }
        public int GetModeId()
        {
            myString = "select mode_id from mode where lower(mode_desc) = '" + Mode_desc.ToLower() + "';";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }

}
