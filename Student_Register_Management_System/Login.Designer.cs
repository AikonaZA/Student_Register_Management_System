namespace Student_Register_Management_System
{
    partial class Login
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
            this.userTxt = new System.Windows.Forms.TextBox();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LecturerBTN = new System.Windows.Forms.Button();
            this.AdminBTN = new System.Windows.Forms.Button();
            this.HoDBTN = new System.Windows.Forms.Button();
            this.testxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(61, 30);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(100, 20);
            this.userTxt.TabIndex = 0;
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(61, 73);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(100, 20);
            this.loginTxt.TabIndex = 1;
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(72, 99);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 23);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // LecturerBTN
            // 
            this.LecturerBTN.Location = new System.Drawing.Point(7, 152);
            this.LecturerBTN.Name = "LecturerBTN";
            this.LecturerBTN.Size = new System.Drawing.Size(75, 23);
            this.LecturerBTN.TabIndex = 5;
            this.LecturerBTN.Text = "Lecturer";
            this.LecturerBTN.UseVisualStyleBackColor = true;
            this.LecturerBTN.Click += new System.EventHandler(this.LecturerBTN_Click);
            // 
            // AdminBTN
            // 
            this.AdminBTN.Location = new System.Drawing.Point(88, 152);
            this.AdminBTN.Name = "AdminBTN";
            this.AdminBTN.Size = new System.Drawing.Size(75, 23);
            this.AdminBTN.TabIndex = 6;
            this.AdminBTN.Text = "Adim";
            this.AdminBTN.UseVisualStyleBackColor = true;
            this.AdminBTN.Click += new System.EventHandler(this.AdminBTN_Click);
            // 
            // HoDBTN
            // 
            this.HoDBTN.Location = new System.Drawing.Point(169, 152);
            this.HoDBTN.Name = "HoDBTN";
            this.HoDBTN.Size = new System.Drawing.Size(75, 23);
            this.HoDBTN.TabIndex = 7;
            this.HoDBTN.Text = "HoD";
            this.HoDBTN.UseVisualStyleBackColor = true;
            this.HoDBTN.Click += new System.EventHandler(this.HoDBTN_Click);
            // 
            // testxt
            // 
            this.testxt.Location = new System.Drawing.Point(281, 30);
            this.testxt.Name = "testxt";
            this.testxt.Size = new System.Drawing.Size(100, 20);
            this.testxt.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 199);
            this.Controls.Add(this.testxt);
            this.Controls.Add(this.HoDBTN);
            this.Controls.Add(this.AdminBTN);
            this.Controls.Add(this.LecturerBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.userTxt);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LecturerBTN;
        private System.Windows.Forms.Button AdminBTN;
        private System.Windows.Forms.Button HoDBTN;
        private System.Windows.Forms.TextBox testxt;
    }
}