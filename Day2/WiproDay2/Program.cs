using System.Text;

namespace WiproDay2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Immutable - every modification creates a new string in memory
            string str = "Hello"; //memory will be allocated
            for (int i = 0; i < 5; i++)
            {
                str += "World"; //new string in memory will be created
            }
            Console.WriteLine(str);

            //StringBuilder - Mutable - changes are made to the same object
            StringBuilder sb = new StringBuilder("Hello"); //memory will be allocated for stringbuilder
            sb.Append("World"); //gets appended to the same object in memory
            Console.WriteLine(sb);

            string userinput = Console.ReadLine();
            Console.WriteLine(userinput);
            Console.WriteLine("Enter the string to append");
            string appendedstr = Console.ReadLine();
            userinput += appendedstr; 
            Console.WriteLine(userinput);

            StringBuilder sb1 = new StringBuilder(userinput);
            sb1.Append(appendedstr);
            Console.WriteLine(sb1);

        }
    }
}