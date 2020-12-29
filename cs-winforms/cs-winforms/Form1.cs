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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        User selecteduser;
        Form3 form3;
        CustomerList form5;

        static List<User> users = new List<User>()
        {
            new User()
            {
                Username="a",
                Password = "a",
                customers = new List<Customer>{
                    new Customer()
                    {
                        Name="a",
                        Surname="a",
                        Email="a",
                        Phone="a",
                        Adress="a"
                    }
                }

            },
                new User()
            {
                Username="b",
                Password = "b"
            }
        };


        private void SingIn_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form5 = new CustomerList();

            selecteduser = users.Find(x => x.Username == SignInUserName.Text && x.Password == SignInPassword.Text);

            if (selecteduser != null)
            {
                Data.SaveUser(selecteduser);
                form3.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Please try again");
            }

            SignInUserName.Text = null;
            SignInPassword.Text = null;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        public void sendData(string username, string password, string name, string surname)
        {
            User user = new User()
            {
                Username = username,
                Password = password,
                Name = name,
                Surname = surname
            };

            users.Add(user);
            Data.SaveUser(user);
        }

    }


    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Customer> customers = new List<Customer>();
        public List<Order> orders = new List<Order>();
        public List<Product> products = new List<Product>();
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }

    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }

    public class Order
    {
        public string Username { get; set; }
        public string Product { get; set; }
        public decimal Quantity { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime ArriveTime { get; set; }
       
    }
}
