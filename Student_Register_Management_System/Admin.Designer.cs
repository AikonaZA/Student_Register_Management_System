namespace Student_Register_Management_System
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.modBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studBtn
            // 
            this.studBtn.Location = new System.Drawing.Point(87, 46);
            this.studBtn.Name = "studBtn";
            this.studBtn.Size = new System.Drawing.Size(118, 23);
            this.studBtn.TabIndex = 0;
            this.studBtn.Text = "View Students";
            this.studBtn.UseVisualStyleBackColor = true;
            this.studBtn.Click += new System.EventHandler(this.studBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // staffBtn
            // 
            this.staffBtn.Location = new System.Drawing.Point(87, 75);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(118, 23);
            this.staffBtn.TabIndex = 2;
            this.staffBtn.Text = "View Staff";
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // modBtn
            // 
            this.modBtn.Location = new System.Drawing.Point(87, 105);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(118, 23);
            this.modBtn.TabIndex = 3;
            this.modBtn.Text = "View Modules";
            this.modBtn.UseVisualStyleBackColor = true;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.studBtn);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button modBtn;
    }
}