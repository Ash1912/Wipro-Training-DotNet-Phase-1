namespace WiproDemoTryParseDay1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //string input = "123";
            string input = null;

            int res;
            bool isParse = int.TryParse(input, out res);
            if (isParse)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Parse Failed");
            }
            int resConvert = Convert.ToInt32(input);
            if (resConvert != 0)
            {
                Console.WriteLine(resConvert);
            }
            else
            {
                Console.WriteLine("Convert.ToInt32 Failed");
            }
            int age = GetValidInteger("Enter your current age : ");
            int birthYear = GetValidInteger("Enter your birth year : ");
            Console.WriteLine($"You entered:\nAge: {age}\nBirth Year: {birthYear}");
        }
        static int GetValidInteger(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.WriteLine("Invalid Input");
                return 0;
            }
        }
    }
}