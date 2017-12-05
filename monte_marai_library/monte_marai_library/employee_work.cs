using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace monte_marai_library
{
    public class employee_work
    {
        //        employee_work_id integer NOT NULL,
        //department_id integer,
        //position_id integer,
        //employee_id integer,
        //hired_date timestamp without time zone,
        //status_id integer,

        int employee_work_id;

        public int Employee_work_id
        {
            get { return employee_work_id; }
            set { employee_work_id = value; }
        }
        int department_id;

        public int Department_id
        {
            get { return department_id; }
            set { department_id = value; }
        }
        int position_id;

        public int Position_id
        {
            get { return position_id; }
            set { position_id = value; }
        }
        string employee_id;

        public string Employee_id
        {
            get { return employee_id; }
            set { employee_id = value; }
        }
        DateTime hired_date;

        public DateTime Hired_date
        {
            get { return hired_date; }
            set { hired_date = value; }
        }
        int status_id;

        public int Status_id
        {
            get { return status_id; }
            set { status_id = value; }
        }
    }
    public class Objemployee_work : employee_work
    {
        bggQueryPgSql myQuery = new bggQueryPgSql();
        string myString;

        public bool Insert()
        {
            myString = "Insert into employee_work(employee_work_id,department_id,position_id ,employee_id ,hired_date,status_id  ) values(" + Employee_work_id +", " + Department_id + "," + Position_id + ",'" + Employee_id + "','" + Hired_date + "'," + Status_id + ")";
            return myQuery.InsertUpdateDelete(myString);
        }
        public int generate_employee_work_id()
        {
            myString = "Select coalesce(max(employee_work_id), 0) + 1 from employee_work;";
            return int.Parse(myQuery.ViaSingleData(myString));
        }
    }
}
