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
    public partial class form8ProductList : Form
    {
        public form8ProductList()
        {
            InitializeComponent();
        }

        private void Form8ProductList_Load(object sender, EventArgs e)
        {
            var product = Data.GetUser().products;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = product;
        }
    }
}
