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
    public partial class UC__Payslip_generate : UserControl
    {
        Objdtr_payroll_date dates = new Objdtr_payroll_date();
        Objall_queries query = new Objall_queries();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public UC__Payslip_generate()
        {
            InitializeComponent();

            comboBox1 = dates.GetDates(comboBox1);
        }

        private void UC__Payslip_generate_Load(object sender, EventArgs e)
        {

        }

        //print
        private void button1_Click(object sender, EventArgs e)
        {
            query.Payroll_date_id = dates.Payroll_date_id;

            dataGridView1 = query.GetReport(dataGridView1);
            SetGrid();
           
        }
        void SetGrid()
        {

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }

        //date 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {

                dates.Payroll_date = DateTime.Parse(comboBox1.Text);
                dates.Payroll_date_id = dates.GetDateId();
            }

        }
    }
}
