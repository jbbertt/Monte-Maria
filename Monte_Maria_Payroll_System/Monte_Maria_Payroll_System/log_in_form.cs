/*
 * Created by SharpDevelop.
 * User: jazzybert26
 * Date: 10/7/2017
 * Time: 3:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Monte_Marial_Lib;

namespace Monte_Maria_Payroll_System
{
	/// <summary>
	/// Description of log_in_form.
	/// </summary>
	public partial class log_in_form : Form
	{
		Objlog_in log_in = new Objlog_in();
		
		public log_in_form()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		//wala ni function
		void Label1Click(object sender, EventArgs e)
		{		
		}
		
		//exit btn ni
		void Button2Click(object sender, EventArgs e)
		{
			DialogResult answer = MessageBox.Show("Are your sure you want to Exit the program?", "Confirm ", MessageBoxButtons.YesNo);
			//this.Close();
			if(answer == DialogResult.Yes){
				this.Close();			}
		}
		
		void Login_btnClick(object sender, EventArgs e)
		{
			if (tb_username.Text.Length > 0 && tb_password.Text.Length > 0)
            {
				
				
				this.Hide();
				new MainForm().ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Log-in Details. Please enter a correct password or user-name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
			
		}
	}
}
