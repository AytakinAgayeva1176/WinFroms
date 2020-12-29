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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }



        public void addNewCustomer(string name, string surname, string email, string phone, string adress)
        {
            Customer customer = new Customer()
            {
                Email = email,
                Phone = phone,
                Name = name,
                Surname = surname,
                Adress = adress
            };

            User selecteduser = Data.GetUser();
            selecteduser.customers.Add(customer);
            Data.SaveCustomers(selecteduser.customers);
        }
        private void CustomerSave_Click(object sender, EventArgs e)
        {
            addNewCustomer(CustomerName.Text, CustomerSurname.Text, CustomerEmail.Text, CustomerPhone.Text, CustomAdress.Text);
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CustomerName.Text = null;
            CustomerSurname.Text = null;
            CustomerEmail.Text = null;
            CustomerPhone.Text = null;
            CustomAdress.Text="";
        }
    }
}
