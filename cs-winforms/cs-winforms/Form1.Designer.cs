﻿namespace cs_winforms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SignInUserName = new System.Windows.Forms.TextBox();
            this.SignInPassword = new System.Windows.Forms.TextBox();
            this.SingIn = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // SignInUserName
            // 
            this.SignInUserName.Location = new System.Drawing.Point(330, 194);
            this.SignInUserName.Name = "SignInUserName";
            this.SignInUserName.Size = new System.Drawing.Size(190, 20);
            this.SignInUserName.TabIndex = 3;
            // 
            // SignInPassword
            // 
            this.SignInPassword.Location = new System.Drawing.Point(330, 241);
            this.SignInPassword.Name = "SignInPassword";
            this.SignInPassword.Size = new System.Drawing.Size(190, 20);
            this.SignInPassword.TabIndex = 4;
            // 
            // SingIn
            // 
            this.SingIn.Location = new System.Drawing.Point(444, 288);
            this.SingIn.Name = "SingIn";
            this.SingIn.Size = new System.Drawing.Size(75, 23);
            this.SingIn.TabIndex = 5;
            this.SingIn.Text = "Sign In";
            this.SingIn.UseVisualStyleBackColor = true;
            this.SingIn.Click += new System.EventHandler(this.SingIn_Click);
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(330, 288);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(75, 23);
            this.SignUp.TabIndex = 6;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SingIn);
            this.Controls.Add(this.SignInPassword);
            this.Controls.Add(this.SignInUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SignInUserName;
        private System.Windows.Forms.TextBox SignInPassword;
        private System.Windows.Forms.Button SingIn;
        private System.Windows.Forms.Button SignUp;
    }
}