using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class position
    {
  //position_id integer NOT NULL,
  //department_id integer,
  //position_decs character varying(150),

        int position_id;

        public int Position_id
        {
            get { return position_id; }
            set { position_id = value; }
        }
        int department_id;

        public int Department_id
        {
            get { return department_id; }
            set { department_id = value; }
        }
        String position_decs;

        public String Position_decs
        {
            get { return position_decs; }
            set { position_decs = value; }
        }

    }
    public class Objposition : position
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into position(position_id, department_id, position_decs ) values('" + Position_id + "', '" + Department_id + "','" + Position_decs + "')";
            return myQuery.InsertUpdateDelete(myString);
        }

        public int generate_position_id()
        {
            myString = "Select coalesce(max(position_id), 0) + 1 from position;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
        public DataGridView getviewposition(DataGridView mtDgv)
        {
            myString = "select distinct  a.position_id, a.position_decs, b.department_decs from position a, department b where b.department_id = a.department_id order by position_id asc";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }
        public ComboBox GetPositionName(ComboBox myCmb)
        {
            myString = "Select initcap(position_decs) from position;";
            return myQuery.ViaComboBox(myString, myCmb);
        }
        public int GetPositionId()
        {
            myString = "select position_id from position where lower(position_decs) = '" + Position_decs.ToLower() + "';";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
