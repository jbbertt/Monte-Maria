namespace MMPSv1._1
{
    partial class OT_uniform
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
            this.dtp_dategranted = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.txtbox_employee_name = new System.Windows.Forms.TextBox();
            this.dgv_uniform = new System.Windows.Forms.DataGridView();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbox_mode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_deduction_start = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_amount_deduction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uniform)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_dategranted
            // 
            this.dtp_dategranted.Location = new System.Drawing.Point(632, 130);
            this.dtp_dategranted.Name = "dtp_dategranted";
            this.dtp_dategranted.Size = new System.Drawing.Size(264, 20);
            this.dtp_dategranted.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(715, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = "Date Granted :";
            // 
            // txtbox_amount
            // 
            this.txtbox_amount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_amount.Location = new System.Drawing.Point(283, 77);
            this.txtbox_amount.Name = "txtbox_amount";
            this.txtbox_amount.Size = new System.Drawing.Size(301, 23);
            this.txtbox_amount.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 87;
            this.label2.Text = "Uniform";
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(614, 173);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(106, 40);
            this.refresh_btn.TabIndex = 86;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // txtbox_employee_name
            // 
            this.txtbox_employee_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_employee_name.Location = new System.Drawing.Point(283, 42);
            this.txtbox_employee_name.Name = "txtbox_employee_name";
            this.txtbox_employee_name.Size = new System.Drawing.Size(301, 23);
            this.txtbox_employee_name.TabIndex = 85;
            this.txtbox_employee_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_employee_name_KeyDown);
            // 
            // dgv_uniform
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_uniform.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_uniform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_uniform.Location = new System.Drawing.Point(206, 219);
            this.dgv_uniform.Name = "dgv_uniform";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_uniform.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_uniform.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_uniform.Size = new System.Drawing.Size(670, 213);
            this.dgv_uniform.TabIndex = 84;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(442, 173);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(106, 40);
            this.save_btn.TabIndex = 83;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "Employee Name :";
            // 
            // cmbox_mode
            // 
            this.cmbox_mode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_mode.FormattingEnabled = true;
            this.cmbox_mode.Location = new System.Drawing.Point(283, 111);
            this.cmbox_mode.Name = "cmbox_mode";
            this.cmbox_mode.Size = new System.Drawing.Size(301, 24);
            this.cmbox_mode.TabIndex = 97;
            this.cmbox_mode.SelectedIndexChanged += new System.EventHandler(this.cmbox_mode_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "Deduction Mode :";
            // 
            // dtp_deduction_start
            // 
            this.dtp_deduction_start.Location = new System.Drawing.Point(632, 67);
            this.dtp_deduction_start.Name = "dtp_deduction_start";
            this.dtp_deduction_start.Size = new System.Drawing.Size(264, 20);
            this.dtp_deduction_start.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "Deduction Start :";
            // 
            // txtbox_amount_deduction
            // 
            this.txtbox_amount_deduction.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_amount_deduction.Location = new System.Drawing.Point(283, 140);
            this.txtbox_amount_deduction.Name = "txtbox_amount_deduction";
            this.txtbox_amount_deduction.Size = new System.Drawing.Size(301, 23);
            this.txtbox_amount_deduction.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 100;
            this.label6.Text = "Amount Deducted :";
            // 
            // OT_uniform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbox_amount_deduction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_deduction_start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbox_mode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_dategranted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.txtbox_employee_name);
            this.Controls.Add(this.dgv_uniform);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label1);
            this.Name = "OT_uniform";
            this.Size = new System.Drawing.Size(1128, 444);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uniform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_dategranted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.TextBox txtbox_employee_name;
        private System.Windows.Forms.DataGridView dgv_uniform;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbox_mode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_deduction_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_amount_deduction;
        private System.Windows.Forms.Label label6;
    }
}
