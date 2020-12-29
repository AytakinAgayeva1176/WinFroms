namespace cs_winforms
{
    partial class Form4
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
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerSurname = new System.Windows.Forms.TextBox();
            this.CustomerEmail = new System.Windows.Forms.TextBox();
            this.CustomerPhone = new System.Windows.Forms.TextBox();
            this.CustomAdress = new System.Windows.Forms.RichTextBox();
            this.CustomerSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adress";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(296, 56);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(216, 20);
            this.CustomerName.TabIndex = 5;
            // 
            // CustomerSurname
            // 
            this.CustomerSurname.Location = new System.Drawing.Point(296, 99);
            this.CustomerSurname.Name = "CustomerSurname";
            this.CustomerSurname.Size = new System.Drawing.Size(216, 20);
            this.CustomerSurname.TabIndex = 6;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Location = new System.Drawing.Point(296, 139);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(216, 20);
            this.CustomerEmail.TabIndex = 7;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.Location = new System.Drawing.Point(296, 182);
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.Size = new System.Drawing.Size(216, 20);
            this.CustomerPhone.TabIndex = 8;
            // 
            // CustomAdress
            // 
            this.CustomAdress.Location = new System.Drawing.Point(296, 230);
            this.CustomAdress.Name = "CustomAdress";
            this.CustomAdress.Size = new System.Drawing.Size(216, 92);
            this.CustomAdress.TabIndex = 9;
            this.CustomAdress.Text = "";
            // 
            // CustomerSave
            // 
            this.CustomerSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSave.Location = new System.Drawing.Point(437, 343);
            this.CustomerSave.Name = "CustomerSave";
            this.CustomerSave.Size = new System.Drawing.Size(75, 31);
            this.CustomerSave.TabIndex = 10;
            this.CustomerSave.Text = "Save";
            this.CustomerSave.UseVisualStyleBackColor = true;
            this.CustomerSave.Click += new System.EventHandler(this.CustomerSave_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerSave);
            this.Controls.Add(this.CustomAdress);
            this.Controls.Add(this.CustomerPhone);
            this.Controls.Add(this.CustomerEmail);
            this.Controls.Add(this.CustomerSurname);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerSurname;
        private System.Windows.Forms.TextBox CustomerEmail;
        private System.Windows.Forms.TextBox CustomerPhone;
        private System.Windows.Forms.RichTextBox CustomAdress;
        private System.Windows.Forms.Button CustomerSave;
    }
}