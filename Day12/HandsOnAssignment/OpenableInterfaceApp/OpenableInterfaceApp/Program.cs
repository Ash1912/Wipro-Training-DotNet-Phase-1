using OpenableInterfaceApp;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the letter found in the paper");
        string input = Console.ReadLine()?.Trim().ToUpper();

        IOpenable item;

        if (input == "T")
        {
            item = new TreasureBox();
        }
        else if (input == "P")
        {
            item = new Parachute();
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter 'T' or 'P'.");
            return;
        }

        Console.WriteLine(item.OpenSesame());
    }
}