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

namespace MMPSv1._1
{
    public partial class UC_dtr_shownewattendance : UserControl
    {
        Objemployee_profiles profile = new Objemployee_profiles();
        Objdtr_payroll_date dates = new Objdtr_payroll_date();
        Objdtr_attendance attendance = new Objdtr_attendance();
        Objsalaries sal = new Objsalaries();

        public UC_dtr_shownewattendance()
        {
            InitializeComponent();
            txtbox_name = profile.GetProfiles(txtbox_name);

            payroll_date_id = dates.GetDates(payroll_date_id);
        }

        //wala ni labot
        private void UC_dtr_shownewattendance_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txtbox_legal_hol.Text.Length > 0 & txtbox_name.Text.Length > 0 & txtbox_present.Text.Length > 0 & txtbox_special_hol.Text.Length > 0){

                ListViewItem item = new ListViewItem();

                item.SubItems.Add(profile.Profile_id.ToString());
                item.SubItems.Add(txtbox_name.Text);
                item.SubItems.Add(txtbox_present.Text);
                item.SubItems.Add(txtbox_legal_hol.Text);
                item.SubItems.Add(txtbox_special_hol.Text);
               

                listview_attendance.Items.Add(item);
               
                
                txtbox_legal_hol.Clear();
                txtbox_name.Clear();
                txtbox_present.Clear();
                txtbox_special_hol.Clear();
            }
            else
            {
                MessageBox.Show("Please Fill The Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtbox_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbox_name.AutoCompleteCustomSource.Contains(txtbox_name.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    profile.Profile_id = int.Parse(profile.GetProfileIDusingname(txtbox_name.Text));

                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (listview_attendance.Items.Count > 0 & payroll_date_id.SelectedIndex != -1)
            {
                DialogResult answer = MessageBox.Show("Are your sure you want to save this?", "Confirm Save", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {

                    foreach (ListViewItem item in listview_attendance.Items)
                    {

                        attendance.Attendance_id = attendance.generate_attendance_id();
                        attendance.Payroll_date_id = dates.Payroll_date_id;

                        attendance.Profilie_id = int.Parse(item.SubItems[1].Text);
                        attendance.Days_present = double.Parse(item.SubItems[3].Text);
                        attendance.Days_legal_holiday = double.Parse(item.SubItems[4].Text);
                        attendance.Special_non_workingday = double.Parse(item.SubItems[5].Text);
                     

                        if (attendance.Insert())
                        {
                            sal.Profile_id = profile.Profile_id;

                            double dl_rate = sal.getdaily_rate();
                            double legalhol = sal.getleagal_rate();
                            double special = sal.getspecial_rate();

                            //compute the regular employee salary 
                            double dl_rate_fee = dl_rate * attendance.Days_present;

                            // legal holiday 
                            double legal_fee = legalhol * attendance.Days_legal_holiday;

                            //special holiday
                            double special_fee = special * attendance.Special_non_workingday;

                            sal.Salary = dl_rate_fee + legal_fee + special_fee;

                            sal.Salary_id = sal.generate_salary_id();
                            sal.Attendance_id = attendance.Attendance_id;
                            

                            if (sal.Insert())
                            {
                                MessageBox.Show("Attendance has save!");
                            }
                            
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Saving Fail. Please input a valid data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void payroll_date_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payroll_date_id.SelectedIndex != -1)
            {

                dates.Payroll_date = DateTime.Parse(payroll_date_id.Text);
                dates.Payroll_date_id = dates.GetDateId();
            }
        }
    }
}
