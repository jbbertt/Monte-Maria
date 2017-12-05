using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using Npgsql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class department
    {
        //department_id integer NOT NULL,
        //department_decs character varying(150),

        int department_id;

        public int Department_id
        {
            get { return department_id; }
            set { department_id = value; }
        }
        string department_decs;

        public string Department_decs
        {
            get { return department_decs; }
            set { department_decs = value; }
        }
    }
    public class Objdepartment : department
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            //department_id integer NOT NULL,
            //department_decs character varying(150),
            myString = "Insert into department(department_id, department_decs ) values('" + Department_id + "', '" + Department_decs + "')";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_department_id()
        {
            myString = "Select coalesce(max(department_id), 0) + 1 from department;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
        public DataGridView getviewdepartments(DataGridView mtDgv)
        {   
            myString = "select * from department";
            return myQuery.ViaDataGridView(myString, mtDgv);
        }

        public ComboBox GetDepartmentName(ComboBox myCmb)
        {
            myString = "Select initcap(department_decs) from department;";
            return myQuery.ViaComboBox(myString, myCmb);
        }

        public int GetDepartmentId()
        {
            myString = "select department_id from department where lower(department_decs) = '" + Department_decs.ToLower() + "'";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
