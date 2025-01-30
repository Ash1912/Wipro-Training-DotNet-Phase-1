namespace InterfaceDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string ch;
            do
            {
                Console.WriteLine("Enter the Shape : \n1.Circle\n2.Rectangle");
                string? type = Console.ReadLine();

                switch (type.ToLower())
                {
                    case "circle":
                        IShape ish = new Circle() { radius = 10 };
                        ish.CalculateArea();
                        break;
                    case "rectangle":
                        IShape rec = new Rect() { l = 10, b = 5 };
                        rec.CalculateArea();
                        break;
                    default:
                        IShape sq = new Circle();
                        sq.DefaultSquare(5);
                        break;
                }
                Console.WriteLine("Do you want to continue (yes/no):");
                ch = Console.ReadLine();
            } while (ch.Equals("yes"));
        }
    }
}