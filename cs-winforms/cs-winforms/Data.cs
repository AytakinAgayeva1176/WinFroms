using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_winforms
{

    static class Data
    {
        static User _user;
        static List<Customer> Customers;
        public static void SaveCustomers(List<Customer> customers)
        {
            Customers = customers;
        }

        public static List<Customer> GetAllCustomers()
        {
            return Customers;
        }
        public static void SaveUser(User user)
        {
            _user = user;
        }

        public static User GetUser()
        {
            return _user;
        }


    }
}
