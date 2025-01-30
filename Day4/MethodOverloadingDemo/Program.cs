namespace MethodOverloadingDemo
{
    class AddOperat
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b);
        }
        public string Add(string a, string b)
        {
            return a + b;
        }
        public void Add(double c, float d)
        {
            Console.WriteLine(c + d);
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            AddOperat addOperat = new AddOperat();
            Console.WriteLine(addOperat.Add("Csharp", "training"));
            AddOperat.Add(10,20,30);
        }
    }
}
