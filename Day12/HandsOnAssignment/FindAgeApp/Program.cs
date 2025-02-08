using FindAgeApp;

class Program
{
    static void Main()
    {
        // Take User Input
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter date of birth (yyyy/MM/dd): ");
        DateTime dob;

        // Validate Date Input
        while (!DateTime.TryParse(Console.ReadLine(), out dob))
        {
            Console.Write("Invalid date format. Please enter again (yyyy/MM/dd): ");
        }

        // Create Person Object
        Person person = new Person
        {
            FirstName = firstName,
            LastName = lastName,
            DOB = dob
        };

        // Display Person Details
        Console.WriteLine("\nSample Output:");
        person.DisplayDetails();
    }
}