namespace MMPSv1._1
{
    partial class UC_loan
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
            this.pan = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_view_pagibig = new System.Windows.Forms.Button();
            this.btn_view_sss = new System.Windows.Forms.Button();
            this.pagibig_loan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.changing_panel = new System.Windows.Forms.Panel();
            this.pan.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Controls.Add(this.changing_panel);
            this.pan.Controls.Add(this.panel2);
            this.pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan.Location = new System.Drawing.Point(0, 0);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(1350, 468);
            this.pan.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_view_pagibig);
            this.panel2.Controls.Add(this.btn_view_sss);
            this.panel2.Controls.Add(this.pagibig_loan);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 468);
            this.panel2.TabIndex = 3;
            // 
            // btn_view_pagibig
            // 
            this.btn_view_pagibig.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_pagibig.Location = new System.Drawing.Point(30, 302);
            this.btn_view_pagibig.Name = "btn_view_pagibig";
            this.btn_view_pagibig.Size = new System.Drawing.Size(151, 48);
            this.btn_view_pagibig.TabIndex = 4;
            this.btn_view_pagibig.Text = "View all Pag-ibig Loan";
            this.btn_view_pagibig.UseVisualStyleBackColor = true;
            this.btn_view_pagibig.Click += new System.EventHandler(this.btn_view_pagibig_Click);
            // 
            // btn_view_sss
            // 
            this.btn_view_sss.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_sss.Location = new System.Drawing.Point(30, 129);
            this.btn_view_sss.Name = "btn_view_sss";
            this.btn_view_sss.Size = new System.Drawing.Size(151, 48);
            this.btn_view_sss.TabIndex = 3;
            this.btn_view_sss.Text = "View all SSS Loan";
            this.btn_view_sss.UseVisualStyleBackColor = true;
            this.btn_view_sss.Click += new System.EventHandler(this.btn_view_sss_Click);
            // 
            // pagibig_loan
            // 
            this.pagibig_loan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagibig_loan.Location = new System.Drawing.Point(30, 213);
            this.pagibig_loan.Name = "pagibig_loan";
            this.pagibig_loan.Size = new System.Drawing.Size(151, 48);
            this.pagibig_loan.TabIndex = 2;
            this.pagibig_loan.Text = "Pag-ibig Loan";
            this.pagibig_loan.UseVisualStyleBackColor = true;
            this.pagibig_loan.Click += new System.EventHandler(this.pagibig_loan_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "SSS Loan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changing_panel
            // 
            this.changing_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changing_panel.Location = new System.Drawing.Point(222, 0);
            this.changing_panel.Name = "changing_panel";
            this.changing_panel.Size = new System.Drawing.Size(1128, 468);
            this.changing_panel.TabIndex = 4;
            // 
            // UC_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pan);
            this.Name = "UC_loan";
            this.Size = new System.Drawing.Size(1350, 468);
            this.pan.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_view_pagibig;
        private System.Windows.Forms.Button btn_view_sss;
        private System.Windows.Forms.Button pagibig_loan;
        private System.Windows.Forms.Panel changing_panel;
    }
}
