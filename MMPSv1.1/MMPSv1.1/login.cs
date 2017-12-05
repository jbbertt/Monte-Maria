using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using monte_marai_library;


namespace MMPSv1._1
{
    public partial class login : Form
    {
        Objlogin log = new Objlogin();
        
        public login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {            
            log.Username = tb_username.Text;
            log.Password = tb_password.Text;

            if (tb_username.Text.Length > 0 && tb_password.Text.Length > 0)
            {
                if (tb_username.Text == log.getusername() & tb_password.Text == log.getpassword())
                {
                    this.Hide();
                    new main_form().ShowDialog();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Username and Password Dosn't Match.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please Fill The Fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
             
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are your sure you want to Exit the program?", "Confirm ", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
