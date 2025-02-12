using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
{
    class Product
    {
        private string _productName;
        private string _serialNumber;
        private DateTime _purchaseDate;
        private double _cost;

        // Constructor
        public Product(string productName, string serialNumber, DateTime purchaseDate, double cost)
        {
            _productName = productName;
            _serialNumber = serialNumber;
            _purchaseDate = purchaseDate;
            _cost = cost;
        }

        // Override ToString() for formatted output
        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", _productName, _serialNumber, _purchaseDate.ToString("dd-MM-yyyy"), _cost);
        }
    }
}
