// See https://aka.ms/new-console-template for more information
using System;//namespace

namespace WiproDemoDay1
{
    internal class Program
    {
        static void Main(string[] args) //Entry point of ur code
        {
            Console.WriteLine("Enter the training name : ");
            string name = Console.ReadLine(); //Read Input from the user 
            //Console.WriteLine("Training name :" +name);

            Console.WriteLine("Enter the organization name :");
            string OrgName = Console.ReadLine();

            Console.WriteLine("No. of days of training : ");
            int num_days = Convert.ToInt32(Console.ReadLine()); // will not throwexception for null value, it simply returns 0
            //int num_of_days =int.Parse(Console.ReadLine()); // will throw null

            //Output Formatting
            Console.WriteLine("Training name : " + name + " by " + OrgName);

            //String Interpolation
            Console.WriteLine($"Training name : {name}\n Organization name : {OrgName}\n Number of Days : {num_days}");

            //Index Positions
            Console.WriteLine("Training name : {0} and Organization name : {1}", name, OrgName);

            int? a = null; //Variable a is of nullable type
            int b = a ?? 10; //Null coleascing operator
            Console.WriteLine("Value is : " + a + " "+b);

            int d = 100;//value type
            object ob = d;//reference type boxing - assigning value type to reference type
            int unbox = (int)ob; // value type unboxing - reference type to value type
            Console.WriteLine(d + " " +ob);
        }
    }
}