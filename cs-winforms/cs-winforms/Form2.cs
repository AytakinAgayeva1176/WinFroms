using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_winforms
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2()
        {
            InitializeComponent();

            form1 = new Form1();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (SignUpPsswrd.Text == SignUpRePsswrd.Text)
            {
                form1.sendData(SignUpUsername.Text, SignUpPsswrd.Text, SignUpName.Text , SignUpSurname.Text);
            
                this.Close();
            }

            else
            {
                MessageBox.Show("Password doesn't match");
            }
        
        }
    }
}
