namespace MMPSv1._1
{
    partial class UC_employee
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
            this.changing_panel = new System.Windows.Forms.Panel();
            this.em_changing_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resignation_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.changing_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // changing_panel
            // 
            this.changing_panel.Controls.Add(this.em_changing_panel);
            this.changing_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changing_panel.Location = new System.Drawing.Point(222, 0);
            this.changing_panel.Name = "changing_panel";
            this.changing_panel.Size = new System.Drawing.Size(1128, 468);
            this.changing_panel.TabIndex = 1;
            // 
            // em_changing_panel
            // 
            this.em_changing_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.em_changing_panel.Location = new System.Drawing.Point(0, 0);
            this.em_changing_panel.Name = "em_changing_panel";
            this.em_changing_panel.Size = new System.Drawing.Size(1128, 468);
            this.em_changing_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changing_panel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 468);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.resignation_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 468);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Profiling";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "List of Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resignation_btn
            // 
            this.resignation_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resignation_btn.Location = new System.Drawing.Point(32, 236);
            this.resignation_btn.Name = "resignation_btn";
            this.resignation_btn.Size = new System.Drawing.Size(148, 52);
            this.resignation_btn.TabIndex = 0;
            this.resignation_btn.Text = "Employee Other Deductions";
            this.resignation_btn.UseVisualStyleBackColor = true;
            this.resignation_btn.Click += new System.EventHandler(this.resignation_btn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(32, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Dependents";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UC_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_employee";
            this.Size = new System.Drawing.Size(1350, 468);
            this.changing_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel changing_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resignation_btn;
        private System.Windows.Forms.Panel em_changing_panel;
        private System.Windows.Forms.Button button3;

    }
}
