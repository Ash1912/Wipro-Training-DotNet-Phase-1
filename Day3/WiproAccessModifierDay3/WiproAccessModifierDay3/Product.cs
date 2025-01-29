using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproAccessModifierDay3
{
    class Product
    {
        // Public: Accessible from anywhere
        public int ProductID;

        // Private: Accessible only within this class
        private string ProductName;

        // Protected: Accessible within this class and derived classes
        protected double Price;

        // Internal: Accessible within the same assembly (project)
        internal string Category;

        // Protected Internal: Accessible within the same assembly and derived classes in different assemblies
        protected internal int StockQuantity;

        public Product(int id, string name, double price, string category, int stock)
        {
            ProductID = id;
            ProductName = name;
            Price = price;
            Category = category;
            StockQuantity = stock;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product ID: {ProductID}, Category: {Category}, Stock: {StockQuantity}");
            // Can't directly print ProductName because it's private.
        }
    }
}
