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
    public partial class Form7AcceptOrder : Form
    {
        public Form7AcceptOrder()
        {
            InitializeComponent();
        }

        private void OrderAccept_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                Username = comboBox1.Text,
                Product = comboBox2.Text,
                Quantity = numericUpDown1.Value,
                OrderTime = DateTime.Now,
                ArriveTime = dateTimePicker1.Value
            };

            var user = Data.GetUser();
            user.orders.Add(order);

            this.Close();
        }



        private void Form7AcceptOrder_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox2.Items.Clear();
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
          
            var clients = Data.GetUser().customers;
            foreach (var item in clients)
            {
                comboBox1.Items.Add(item.Name);
            }
          
            var products = Data.GetUser().products;
            foreach (var item in products)
            {
                comboBox2.Items.Add(item.Name);
            }
  
        }


        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //var quantity = products.FindAll(x => x.Name == ProductBox.SelectedItem.ToString());

            //numericUpDown1.Maximum = quantity.Count();
        }
    }

  
}
