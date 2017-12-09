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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.payroll_date_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtbox_special_hol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_legal_hol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_present = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_attendance = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).BeginInit();
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
            this.panel1.Controls.Add(this.btn_save);
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
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(111, 313);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 30);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            // dgv_attendance
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_attendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_attendance.Location = new System.Drawing.Point(344, 50);
            this.dgv_attendance.Name = "dgv_attendance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_attendance.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_attendance.Size = new System.Drawing.Size(761, 344);
            this.dgv_attendance.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(681, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 54;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_dtr_shownewattendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_attendance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.payroll_date_id);
            this.Controls.Add(this.label1);
            this.Name = "UC_dtr_shownewattendance";
            this.Size = new System.Drawing.Size(1128, 468);
            this.Load += new System.EventHandler(this.UC_dtr_shownewattendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox payroll_date_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbox_special_hol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_legal_hol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_present;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_attendance;
        private System.Windows.Forms.Button button1;
    }
}
