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
    public partial class Form6AddProduct : Form
    {
        public Form6AddProduct()
        {
            InitializeComponent();
        }

        private void ProductSave_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = textBox1.Text,
                Price= Convert.ToInt32(textBox2.Text),
                Quantity=Convert.ToInt32(textBox3.Text),
                Description = richTextBox1.Text
            };

            var user = Data.GetUser();
            user.products.Add(product);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";
            this.Close();
        }



        private void textChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        private void priceTextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }
    }
}
