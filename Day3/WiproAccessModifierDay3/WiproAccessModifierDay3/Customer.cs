using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproAccessModifierDay3
{
    class Customer
    {
        // Public: Can be accessed anywhere
        public int CustomerID;

        // Private: Can only be accessed within this class
        private string CustomerName;

        // Internal: Accessible within the same assembly (project)
        internal string Email;

        public Customer(int id, string name, string email)
        {
            CustomerID = id;
            CustomerName = name;
            Email = email;
        }

        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer ID: {CustomerID}, Email: {Email}");
            // Can't directly print CustomerName because it's private.
        }
    }
}
