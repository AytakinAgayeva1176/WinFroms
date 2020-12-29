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
    public partial class CustomerList : Form
    {

        public CustomerList()
        {
            InitializeComponent();
        }
       
        private void Form5CustomerList_Load(object sender, EventArgs e)
        {  
            var customers = Data.GetUser().customers;
            dataGridViewCustomer.DataSource = null;
            dataGridViewCustomer.DataSource = customers;
        }


    }
}
