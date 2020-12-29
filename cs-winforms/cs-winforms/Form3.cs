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
    public partial class Form3 : Form
    {
        Form4 form4;
        Form6AddProduct form6;
        Form7AcceptOrder form7;
        User enteredSeller = null;
        public Form3()
        {
            InitializeComponent();

            form4 = new Form4();
            form6 = new Form6AddProduct();
            form7 = new Form7AcceptOrder();
        }

       

        // Add Customer
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form4.ShowDialog();
        }

       

        // Add Product
        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form6.ShowDialog();

        }

        private void AcceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form7.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ListToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            
            CustomerList customerList = new CustomerList();
            customerList.ShowDialog();
        }

        private void ListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderList orderListForm = new OrderList();
            orderListForm.ShowDialog();
        }

        private void ListToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form8ProductList form8 = new form8ProductList();
            form8.ShowDialog();
        }
    }
}
