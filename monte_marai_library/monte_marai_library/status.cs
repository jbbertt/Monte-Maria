using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;
using Npgsql;

namespace monte_marai_library
{
    public class status
    {
  //status_id integer NOT NULL,
  //status_desc character varying,

        int status_id;

        public int Status_id
        {
            get { return status_id; }
            set { status_id = value; }
        }
        String status_desc;

        public String Status_desc
        {
            get { return status_desc; }
            set { status_desc = value; }
        }
    }
    public class Objstatus : status
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into status(status_id,status_desc ) values(" + Status_id + ", '" + Status_desc + "')";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_status_id()
        {
            myString = "Select coalesce(max(status_id), 0) + 1 from status;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        public DataGridView getviewstatus(DataGridView mtDgv)
        {
            myString = "select * from status";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        public ComboBox GetStatusName(ComboBox myCmb)
        {
            myString = "Select initcap(status_desc) from status;";
            return myQuery.ViaComboBox(myString, myCmb);
        }
        public int GetStatusId()
        {
            myString = "select status_id from status where lower(status_desc) = '" + Status_desc.ToLower() + "';";
            return int.Parse(myQuery.ViaSingleData(myString));
        }

        

    }
}
