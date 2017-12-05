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
    public partial class UC_salary_setup : UserControl
    {
        Objdepartment department = new Objdepartment();
        Objposition position = new Objposition();
        Objmode mode = new Objmode();
        Objstatus status = new Objstatus();
        Objsetup setup = new Objsetup();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public UC_salary_setup()
        {
            InitializeComponent();

            cmbx_department = department.GetDepartmentName(cmbx_department);
            cmbx_position = position.GetPositionName(cmbx_position);
            cmbx_mode = mode.GetModeName(cmbx_mode);
            cmbx_status = status.GetStatusName(cmbx_status);

            dtgv_salary = setup.getviewsalary(dtgv_salary);
            SetGrid();
                
        }
        void SetGrid()
        {

            dtgv_salary.Columns["department_decs"].Width = 192;
            dtgv_salary.Columns["position_decs"].Width = 192;
            dtgv_salary.Columns["mode_desc"].Width = 192;
            dtgv_salary.Columns["status_desc"].Width = 192;
            dtgv_salary.Columns["basic_pay"].Width = 192;


            foreach (DataGridViewColumn col in dtgv_salary.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");

            }
        }

        //add new payment mode
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            new PaymentMode_form().ShowDialog();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            new Status_form().ShowDialog();
        }

        private void cmbx_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_department.SelectedIndex != -1)
            {
                department.Department_decs = cmbx_department.Text;

            }
        }

        private void cmbx_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_position.SelectedIndex != -1)
            {
                position.Position_decs = cmbx_position.Text;
            }

        }
            

        private void cmbx_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_mode.SelectedIndex != -1)
            {
                mode.Mode_desc = cmbx_mode.Text;
            }
           
        }

        private void cmbx_status_RightToLeftChanged(object sender, EventArgs e)
        {
            if (cmbx_status.SelectedIndex != -1)
            {
                status.Status_desc = cmbx_status.Text;
            }
            
        }
        private void cmbx_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_status.SelectedIndex != -1)
            {
                status.Status_desc = cmbx_status.Text;
            }
        }

        //save button ni
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (txtbox_rate.Text.Length > 0 & cmbx_department.SelectedIndex != -1 & cmbx_position.SelectedIndex != -1
  & cmbx_mode.SelectedIndex != -1 & cmbx_status.SelectedIndex != -1)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                 if (answer == DialogResult.Yes)
                 {
                     setup.Setup_salary_id = setup.generate_setup_salary_id();
                     setup.Status_id = status.GetStatusId();
                     setup.Position_id = position.GetPositionId();
                     setup.Mode_id = mode.GetModeId();
                     setup.Basic_pay = int.Parse(txtbox_rate.Text);
                     setup.Department_id = department.GetDepartmentId();

                     if (setup.Insert())
                     {
                         MessageBox.Show("New Salary Setup has Save.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         cmbx_department.Text = string.Empty;
                         cmbx_status.Text = string.Empty;
                         cmbx_position.Text = string.Empty;
                         cmbx_mode.Text = string.Empty;
                         txtbox_rate.Text = string.Empty;
                     }

                 }
            }
            else
            {
                //messagebox sa mali
                MessageBox.Show("Saving Fail. Please input a valid data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
        }

        //refresh
        private void button2_Click(object sender, EventArgs e)
        {
            dtgv_salary = setup.getviewsalary(dtgv_salary);
        }
    }
}
