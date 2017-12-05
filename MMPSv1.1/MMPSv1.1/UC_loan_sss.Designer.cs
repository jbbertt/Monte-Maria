namespace MMPSv1._1
{
    partial class UC_loan_sss
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.txtbox_employee = new System.Windows.Forms.TextBox();
            this.dgv_sss = new System.Windows.Forms.DataGridView();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_sssloan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_loan_granted = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbox_mode = new System.Windows.Forms.ComboBox();
            this.txtbox_amount_deducted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_deduction_starts = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_sssid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sss)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(734, 407);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(106, 40);
            this.refresh_btn.TabIndex = 44;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // txtbox_employee
            // 
            this.txtbox_employee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_employee.Location = new System.Drawing.Point(175, 59);
            this.txtbox_employee.Name = "txtbox_employee";
            this.txtbox_employee.Size = new System.Drawing.Size(301, 22);
            this.txtbox_employee.TabIndex = 43;
            this.txtbox_employee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_employee_KeyDown);
            // 
            // dgv_sss
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sss.Location = new System.Drawing.Point(532, 22);
            this.dgv_sss.Name = "dgv_sss";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sss.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_sss.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sss.Size = new System.Drawing.Size(560, 370);
            this.dgv_sss.TabIndex = 42;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(164, 386);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(106, 40);
            this.save_btn.TabIndex = 40;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Employee Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Add SSS Loan ";
            // 
            // txtbox_sssloan
            // 
            this.txtbox_sssloan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_sssloan.Location = new System.Drawing.Point(175, 135);
            this.txtbox_sssloan.Name = "txtbox_sssloan";
            this.txtbox_sssloan.Size = new System.Drawing.Size(301, 22);
            this.txtbox_sssloan.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "SSS Loan Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "SSS Loan Date Granted :";
            // 
            // dtp_loan_granted
            // 
            this.dtp_loan_granted.Location = new System.Drawing.Point(214, 181);
            this.dtp_loan_granted.Name = "dtp_loan_granted";
            this.dtp_loan_granted.Size = new System.Drawing.Size(262, 20);
            this.dtp_loan_granted.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "SSS Loan Dedduction Mode :";
            // 
            // cmbox_mode
            // 
            this.cmbox_mode.FormattingEnabled = true;
            this.cmbox_mode.Location = new System.Drawing.Point(241, 237);
            this.cmbox_mode.Name = "cmbox_mode";
            this.cmbox_mode.Size = new System.Drawing.Size(235, 21);
            this.cmbox_mode.TabIndex = 51;
            this.cmbox_mode.SelectedIndexChanged += new System.EventHandler(this.cmbox_mode_SelectedIndexChanged);
            // 
            // txtbox_amount_deducted
            // 
            this.txtbox_amount_deducted.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_amount_deducted.Location = new System.Drawing.Point(241, 296);
            this.txtbox_amount_deducted.Name = "txtbox_amount_deducted";
            this.txtbox_amount_deducted.Size = new System.Drawing.Size(235, 22);
            this.txtbox_amount_deducted.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Amount to be Deducted :";
            // 
            // dtp_deduction_starts
            // 
            this.dtp_deduction_starts.Location = new System.Drawing.Point(217, 348);
            this.dtp_deduction_starts.Name = "dtp_deduction_starts";
            this.dtp_deduction_starts.Size = new System.Drawing.Size(262, 20);
            this.dtp_deduction_starts.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Deduction Starts :";
            // 
            // txtbox_sssid
            // 
            this.txtbox_sssid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_sssid.Location = new System.Drawing.Point(178, 94);
            this.txtbox_sssid.Name = "txtbox_sssid";
            this.txtbox_sssid.Size = new System.Drawing.Size(301, 22);
            this.txtbox_sssid.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Employee SSS ID :";
            // 
            // UC_loan_sss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbox_sssid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_deduction_starts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_amount_deducted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbox_mode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_loan_granted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_sssloan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.txtbox_employee);
            this.Controls.Add(this.dgv_sss);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label1);
            this.Name = "UC_loan_sss";
            this.Size = new System.Drawing.Size(1128, 468);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.TextBox txtbox_employee;
        private System.Windows.Forms.DataGridView dgv_sss;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_sssloan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_loan_granted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbox_mode;
        private System.Windows.Forms.TextBox txtbox_amount_deducted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_deduction_starts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_sssid;
        private System.Windows.Forms.Label label8;
    }
}
