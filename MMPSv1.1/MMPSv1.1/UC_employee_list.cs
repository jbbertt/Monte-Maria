using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using monte_marai_library;
using System.Globalization;

namespace MMPSv1._1
{
    public partial class UC_employee_list : UserControl
    {
        Objall_queries query = new Objall_queries();
        Objstatus status = new Objstatus();
        Objemployee_profiles profile = new Objemployee_profiles();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public UC_employee_list()
        {
            InitializeComponent();
            dgv_employees = query.getviewAll_employee(dgv_employees);
            SetGrid();

            comboBox3 = status.GetStatusName(comboBox3);
            textBox1 = profile.GetProfiles(textBox1);
        }

        private void btn_allemployee_Click(object sender, EventArgs e)
        {
            dgv_employees = query.getviewAll_employee(dgv_employees);
            SetGrid();
        }
        void SetGrid()
        {

            dgv_employees.Columns["employee_id"].Width = 100;
            dgv_employees.Columns["employee_name"].Width = 120;
            dgv_employees.Columns["gender_desc"].Width = 100;
            dgv_employees.Columns["civil_status_desc"].Width = 100;
            dgv_employees.Columns["address"].Width = 140;
            dgv_employees.Columns["spouse_name"].Width = 120;
            dgv_employees.Columns["status_desc"].Width = 100;
            dgv_employees.Columns["position_decs"].Width = 100;
            dgv_employees.Columns["department_decs"].Width = 90;
            dgv_employees.Columns["basic_pay"].Width = 90;

            foreach (DataGridViewColumn col in dgv_employees.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }

        //status
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                status.Status_desc = comboBox3.Text;
                status.Status_id = status.GetStatusId();
            }

        }

        //employee name
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.AutoCompleteCustomSource.Contains(textBox1.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(textBox1.Text));

                }
            }

        }

        //search button ni
        private void salary_setup_Click(object sender, EventArgs e)
        {


            if(comboBox3.SelectedIndex != -1 && textBox1.Text.Length == 0)
            {
                query.Status_id = status.Status_id;
                dgv_employees = query.getSearch_by_status(dgv_employees);
                
               
            }

            else if(textBox1.Text.Length > 0 && comboBox3.SelectedIndex < 0)
            {
                query.Profile_id = profile.Profile_id;
                dgv_employees = query.getSearch_all_profiles(dgv_employees);
               
            }
            else if(textBox1.Text.Length > 0 && comboBox3.SelectedIndex != -1){
                query.Profile_id = profile.Profile_id;
                query.Status_id = status.Status_id;
                dgv_employees = query.getSearch_by_both(dgv_employees);
               
            }
            else
            {
                MessageBox.Show("Please Specify what to search.");
            }

/*

            if (comboBox3.Text.Length != 0)
            {
                MessageBox.Show("Search via status");
            }
            else if (textBox1.Text.Length != 0)
            {
                MessageBox.Show("Search via name");
            }
            else if (textBox1.Text.Length != 0 & comboBox3.Text.Length != 0)
            {
                MessageBox.Show("Search via name and status");
            }
            else if (textBox1.Text.Length > 0 & comboBox3.SelectedIndex != -1)
            {
                MessageBox.Show("Choose what to search");
            } 
 */
        }


    }
}
