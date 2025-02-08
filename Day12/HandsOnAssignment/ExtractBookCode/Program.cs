using ExtractBookCode;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the book code of length 18:");
        string bookCode = Console.ReadLine();

        Book book = Extractor.ExtractDetails(bookCode);

        if (book != null)
        {
            book.Display();
        }
    }
}