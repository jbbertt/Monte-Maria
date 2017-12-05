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
    public partial class UC_home : UserControl
    {
        Objall_queries query = new Objall_queries();

        public UC_home()
        {
            InitializeComponent();
        }

        private void UC_home_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();

            date.Text = DateTime.Now.ToLongDateString();

            user.Text = query.getuserlogin();
            role.Text = query.getuserRole();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();


        }
    }
}
