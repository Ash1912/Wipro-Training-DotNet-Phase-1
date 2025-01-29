namespace WiproArrayDemoDay2
{
    internal class Program
    {
        void FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum element " + max);
        }
        private static void Main(string[] args)
        {
            int[] arr = new int[4]; //declaring array
            arr[1] = 50;
            arr[3] = 55;
            //display array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int[] ar = { 25, 10, 20, 30, 40, 35 };
            Program.Show(ar); //static method - using class name, we call the method
            Program pgm = new Program();
            pgm.FindMax(ar); // Instace method - using instance , we call the method
            
            Console.WriteLine("Enter the size of an array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] aruser = new int[size];
            for (int i = 0; i<aruser.Length; i++)
            {
                Console.WriteLine($"Enter the value for {i + 1}th/st element:");
                aruser[i] = Convert.ToInt32(Console.ReadLine());
            }
            Show(aruser);
            Array.Sort(aruser);
            Console.WriteLine();
            Show(aruser);
            Array.Reverse(aruser);
            Console.WriteLine();
            Show(aruser);
        }
        public static void Show(int[] ar)
        {
            //traverse array using foreach
            foreach (int val in ar)
            {
                Console.WriteLine(val);
            }
        }
    }
}