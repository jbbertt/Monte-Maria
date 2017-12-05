namespace MMPSv1._1
{
    partial class UC_loan_sss_view
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtbox_empname = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_sss = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_view_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sss)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_empname
            // 
            this.txtbox_empname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_empname.Location = new System.Drawing.Point(662, 48);
            this.txtbox_empname.Name = "txtbox_empname";
            this.txtbox_empname.Size = new System.Drawing.Size(222, 23);
            this.txtbox_empname.TabIndex = 70;
            this.txtbox_empname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_empname_KeyDown);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(900, 37);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(106, 40);
            this.btn_search.TabIndex = 69;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "View SSS Loan ";
            // 
            // dgv_sss
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sss.Location = new System.Drawing.Point(23, 88);
            this.dgv_sss.Name = "dgv_sss";
            this.dgv_sss.Size = new System.Drawing.Size(1079, 355);
            this.dgv_sss.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(705, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Enter Employee Name ";
            // 
            // btn_view_all
            // 
            this.btn_view_all.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_all.Location = new System.Drawing.Point(498, 31);
            this.btn_view_all.Name = "btn_view_all";
            this.btn_view_all.Size = new System.Drawing.Size(106, 40);
            this.btn_view_all.TabIndex = 68;
            this.btn_view_all.Text = "View All";
            this.btn_view_all.UseVisualStyleBackColor = true;
            this.btn_view_all.Click += new System.EventHandler(this.btn_view_all_Click);
            // 
            // UC_loan_sss_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_empname);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_view_all);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_sss);
            this.Name = "UC_loan_sss_view";
            this.Size = new System.Drawing.Size(1128, 468);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_empname;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_sss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_view_all;
    }
}
