namespace MMPSv1._1
{
    partial class OT_vehicle_plan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbox_mode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_vehicle_payable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.txtbox_empname = new System.Windows.Forms.TextBox();
            this.dgv_vehicle = new System.Windows.Forms.DataGridView();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_date_granted = new System.Windows.Forms.DateTimePicker();
            this.txtbox_deducted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deduction_start = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbox_mode
            // 
            this.cmbox_mode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_mode.FormattingEnabled = true;
            this.cmbox_mode.Location = new System.Drawing.Point(324, 121);
            this.cmbox_mode.Name = "cmbox_mode";
            this.cmbox_mode.Size = new System.Drawing.Size(264, 24);
            this.cmbox_mode.TabIndex = 63;
            this.cmbox_mode.SelectedIndexChanged += new System.EventHandler(this.cmbox_mode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Schedule of Deduction :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(734, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Date Granted :";
            // 
            // txtbox_vehicle_payable
            // 
            this.txtbox_vehicle_payable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_vehicle_payable.Location = new System.Drawing.Point(287, 81);
            this.txtbox_vehicle_payable.Name = "txtbox_vehicle_payable";
            this.txtbox_vehicle_payable.Size = new System.Drawing.Size(301, 23);
            this.txtbox_vehicle_payable.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Vehicle Payable :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "Vehicle Plan";
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(633, 192);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(106, 40);
            this.refresh_btn.TabIndex = 56;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // txtbox_empname
            // 
            this.txtbox_empname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_empname.Location = new System.Drawing.Point(287, 46);
            this.txtbox_empname.Name = "txtbox_empname";
            this.txtbox_empname.Size = new System.Drawing.Size(301, 23);
            this.txtbox_empname.TabIndex = 55;
            this.txtbox_empname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_empname_KeyDown);
            // 
            // dgv_vehicle
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vehicle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_vehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehicle.Location = new System.Drawing.Point(90, 238);
            this.dgv_vehicle.Name = "dgv_vehicle";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vehicle.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_vehicle.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_vehicle.Size = new System.Drawing.Size(952, 194);
            this.dgv_vehicle.TabIndex = 54;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(511, 192);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(106, 40);
            this.save_btn.TabIndex = 53;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Employee Name :";
            // 
            // dtp_date_granted
            // 
            this.dtp_date_granted.Location = new System.Drawing.Point(648, 77);
            this.dtp_date_granted.Name = "dtp_date_granted";
            this.dtp_date_granted.Size = new System.Drawing.Size(301, 20);
            this.dtp_date_granted.TabIndex = 64;
            // 
            // txtbox_deducted
            // 
            this.txtbox_deducted.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_deducted.Location = new System.Drawing.Point(324, 163);
            this.txtbox_deducted.Name = "txtbox_deducted";
            this.txtbox_deducted.Size = new System.Drawing.Size(264, 23);
            this.txtbox_deducted.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "Amount to be deducted :";
            // 
            // deduction_start
            // 
            this.deduction_start.Location = new System.Drawing.Point(648, 149);
            this.deduction_start.Name = "deduction_start";
            this.deduction_start.Size = new System.Drawing.Size(301, 20);
            this.deduction_start.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(734, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "Deduction Start :";
            // 
            // OT_vehicle_plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deduction_start);
            this.Controls.Add(this.txtbox_deducted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_date_granted);
            this.Controls.Add(this.cmbox_mode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_vehicle_payable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.txtbox_empname);
            this.Controls.Add(this.dgv_vehicle);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label1);
            this.Name = "OT_vehicle_plan";
            this.Size = new System.Drawing.Size(1128, 444);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbox_mode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_vehicle_payable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.TextBox txtbox_empname;
        private System.Windows.Forms.DataGridView dgv_vehicle;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_date_granted;
        private System.Windows.Forms.TextBox txtbox_deducted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker deduction_start;
        private System.Windows.Forms.Label label7;

    }
}
