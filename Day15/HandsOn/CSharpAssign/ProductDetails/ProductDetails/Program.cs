using ProductDetails;

class Program
{
    static void Main()
    {
        List<Product> productList = new List<Product>();

        // Sample Input Data
        string[] inputs = {
            "HairTrimmer,HT123,10-02-2017,800",
            "Steel Box,SB231,11-04-2018,250",
            "Rope,RP240,13-05-2019,100"
        };

        foreach (string input in inputs)
        {
            string[] details = input.Split(',');

            string productName = details[0];
            string serialNumber = details[1];
            DateTime purchaseDate = DateTime.ParseExact(details[2], "dd-MM-yyyy", null);
            double cost = double.Parse(details[3]);

            Product product = new Product(productName, serialNumber, purchaseDate, cost);
            productList.Add(product);
        }

        // Print Header
        Console.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Product Name", "Serial Number", "Purchase Date", "Purchase Cost"));

        // Print Product List
        foreach (var product in productList)
        {
            Console.WriteLine(product);
        }
    }
}