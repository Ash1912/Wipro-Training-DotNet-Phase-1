namespace WiproAccessModifierDay3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Taking Product details from user
            Console.Write("Enter Product ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            double productPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Product Category: ");
            string productCategory = Console.ReadLine();

            Console.Write("Enter Product Stock: ");
            int productStock = Convert.ToInt32(Console.ReadLine());

            // Creating Product object
            Product product = new Product(productId, productName, productPrice, productCategory, productStock);

            // Taking Customer details from user
            Console.Write("Enter Customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Customer Email: ");
            string customerEmail = Console.ReadLine();

            // Creating Customer object
            Customer customer = new Customer(customerId, customerName, customerEmail);

            // Displaying the details
            Console.WriteLine("\nProduct Details:");
            Console.WriteLine($"Product ID: {product.ProductID}");
            Console.WriteLine($"Product Category: {product.Category}");
            Console.WriteLine($"Product Stock: {product.StockQuantity}");

            Console.WriteLine("\nCustomer Details:");
            Console.WriteLine($"Customer ID: {customer.CustomerID}");
            Console.WriteLine($"Customer Email: {customer.Email}");
        }
    }
}