namespace MMPSv1._1
{
    partial class UC_dtr_shownewattendance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.payroll_date_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtbox_special_hol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_legal_hol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_present = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.profile_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profile_ids = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employee_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.days_present = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.days_legal_holiday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.special_non_workingday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_attendance = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payroll_date_id
            // 
            this.payroll_date_id.FormattingEnabled = true;
            this.payroll_date_id.Location = new System.Drawing.Point(553, 16);
            this.payroll_date_id.Name = "payroll_date_id";
            this.payroll_date_id.Size = new System.Drawing.Size(121, 21);
            this.payroll_date_id.TabIndex = 49;
            this.payroll_date_id.SelectedIndexChanged += new System.EventHandler(this.payroll_date_id_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "Pick Payroll Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Add DTR";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txtbox_special_hol);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtbox_legal_hol);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtbox_present);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtbox_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(16, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 378);
            this.panel1.TabIndex = 52;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(111, 306);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 30);
            this.btn_add.TabIndex = 57;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtbox_special_hol
            // 
            this.txtbox_special_hol.Location = new System.Drawing.Point(97, 252);
            this.txtbox_special_hol.Name = "txtbox_special_hol";
            this.txtbox_special_hol.Size = new System.Drawing.Size(106, 20);
            this.txtbox_special_hol.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Special Non working holiday worked:";
            // 
            // txtbox_legal_hol
            // 
            this.txtbox_legal_hol.Location = new System.Drawing.Point(97, 179);
            this.txtbox_legal_hol.Name = "txtbox_legal_hol";
            this.txtbox_legal_hol.Size = new System.Drawing.Size(106, 20);
            this.txtbox_legal_hol.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Number of Days in Legal Holiday :";
            // 
            // txtbox_present
            // 
            this.txtbox_present.Location = new System.Drawing.Point(97, 106);
            this.txtbox_present.Name = "txtbox_present";
            this.txtbox_present.Size = new System.Drawing.Size(106, 20);
            this.txtbox_present.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Number of Days Present :";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(35, 31);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(221, 20);
            this.txtbox_name.TabIndex = 50;
            this.txtbox_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_name_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Name :";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(745, 10);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 30);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // profile_id
            // 
            this.profile_id.Text = "Profile Id";
            this.profile_id.Width = 0;
            // 
            // profile_ids
            // 
            this.profile_ids.DisplayIndex = 5;
            this.profile_ids.Text = "Profile Ids";
            // 
            // employee_name
            // 
            this.employee_name.DisplayIndex = 1;
            this.employee_name.Text = "Employee Name";
            this.employee_name.Width = 170;
            // 
            // days_present
            // 
            this.days_present.DisplayIndex = 2;
            this.days_present.Text = "Number of days Present";
            this.days_present.Width = 181;
            // 
            // days_legal_holiday
            // 
            this.days_legal_holiday.DisplayIndex = 3;
            this.days_legal_holiday.Tag = "";
            this.days_legal_holiday.Text = "Legal Holidays Present";
            this.days_legal_holiday.Width = 142;
            // 
            // special_non_workingday
            // 
            this.special_non_workingday.DisplayIndex = 4;
            this.special_non_workingday.Text = "Special Non working Holiday";
            this.special_non_workingday.Width = 188;
            // 
            // listview_attendance
            // 
            this.listview_attendance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.profile_id,
            this.profile_ids,
            this.employee_name,
            this.days_present,
            this.days_legal_holiday,
            this.special_non_workingday});
            this.listview_attendance.GridLines = true;
            this.listview_attendance.Location = new System.Drawing.Point(345, 50);
            this.listview_attendance.Name = "listview_attendance";
            this.listview_attendance.Size = new System.Drawing.Size(748, 378);
            this.listview_attendance.TabIndex = 51;
            this.listview_attendance.UseCompatibleStateImageBehavior = false;
            this.listview_attendance.View = System.Windows.Forms.View.Details;
            // 
            // UC_dtr_shownewattendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listview_attendance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.payroll_date_id);
            this.Controls.Add(this.label1);
            this.Name = "UC_dtr_shownewattendance";
            this.Size = new System.Drawing.Size(1128, 468);
            this.Load += new System.EventHandler(this.UC_dtr_shownewattendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox payroll_date_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtbox_special_hol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_legal_hol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_present;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ColumnHeader profile_id;
        private System.Windows.Forms.ColumnHeader profile_ids;
        private System.Windows.Forms.ColumnHeader employee_name;
        private System.Windows.Forms.ColumnHeader days_present;
        private System.Windows.Forms.ColumnHeader days_legal_holiday;
        private System.Windows.Forms.ColumnHeader special_non_workingday;
        private System.Windows.Forms.ListView listview_attendance;
    }
}
