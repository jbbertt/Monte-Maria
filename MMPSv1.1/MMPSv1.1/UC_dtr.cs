using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPSv1._1
{
    public partial class UC_dtr : UserControl
    {
        UC_DTR_addDate date = new UC_DTR_addDate();
        UC_DTR_attendance_show show = new UC_DTR_attendance_show();
        UC_dtr_shownewattendance attendance = new UC_dtr_shownewattendance();

        public UC_dtr()
        {
            InitializeComponent();

            date.Name = "Date";
            date.Dock = DockStyle.Fill;

            show.Name = "Show";
            show.Dock = DockStyle.Fill;

            attendance.Name = "New";
            attendance.Dock = DockStyle.Fill;

            changing_panel.Controls.Add(date);
            changing_panel.Controls.Add(show);
            changing_panel.Controls.Add(attendance);

            HandleControl("Date");
        }

        void HandleControl(string cntrlName)
        {
            changing_panel.Controls[cntrlName].BringToFront();
        }

        //save date
        private void button1_Click(object sender, EventArgs e)
        {
            HandleControl("Date");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleControl("New");
           // new Add_DTR().ShowDialog();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            HandleControl("Show");
        }
    }
}
