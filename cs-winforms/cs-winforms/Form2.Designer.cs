namespace cs_winforms
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SignUpUsername = new System.Windows.Forms.TextBox();
            this.SignUpRePsswrd = new System.Windows.Forms.TextBox();
            this.SignUpPsswrd = new System.Windows.Forms.TextBox();
            this.SignUpName = new System.Windows.Forms.TextBox();
            this.SignUpSurname = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surname";
            // 
            // SignUpUsername
            // 
            this.SignUpUsername.Location = new System.Drawing.Point(336, 131);
            this.SignUpUsername.Name = "SignUpUsername";
            this.SignUpUsername.Size = new System.Drawing.Size(198, 20);
            this.SignUpUsername.TabIndex = 5;
            // 
            // SignUpRePsswrd
            // 
            this.SignUpRePsswrd.Location = new System.Drawing.Point(336, 215);
            this.SignUpRePsswrd.Name = "SignUpRePsswrd";
            this.SignUpRePsswrd.Size = new System.Drawing.Size(198, 20);
            this.SignUpRePsswrd.TabIndex = 6;
            // 
            // SignUpPsswrd
            // 
            this.SignUpPsswrd.Location = new System.Drawing.Point(336, 172);
            this.SignUpPsswrd.Name = "SignUpPsswrd";
            this.SignUpPsswrd.Size = new System.Drawing.Size(198, 20);
            this.SignUpPsswrd.TabIndex = 7;
            // 
            // SignUpName
            // 
            this.SignUpName.Location = new System.Drawing.Point(336, 262);
            this.SignUpName.Name = "SignUpName";
            this.SignUpName.Size = new System.Drawing.Size(198, 20);
            this.SignUpName.TabIndex = 8;
            // 
            // SignUpSurname
            // 
            this.SignUpSurname.Location = new System.Drawing.Point(336, 305);
            this.SignUpSurname.Name = "SignUpSurname";
            this.SignUpSurname.Size = new System.Drawing.Size(198, 20);
            this.SignUpSurname.TabIndex = 9;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(459, 347);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 28);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.SignUpSurname);
            this.Controls.Add(this.SignUpName);
            this.Controls.Add(this.SignUpPsswrd);
            this.Controls.Add(this.SignUpRePsswrd);
            this.Controls.Add(this.SignUpUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SignUpUsername;
        private System.Windows.Forms.TextBox SignUpRePsswrd;
        private System.Windows.Forms.TextBox SignUpPsswrd;
        private System.Windows.Forms.TextBox SignUpName;
        private System.Windows.Forms.TextBox SignUpSurname;
        private System.Windows.Forms.Button Submit;
    }
}