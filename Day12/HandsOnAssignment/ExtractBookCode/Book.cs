using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBookCode
{
    public class Book
    {
        public string DepartmentCode { get; set; }
        public int YearOfPublication { get; set; }
        public int NumberOfPages { get; set; }
        public string BookID { get; set; }

        public void Display()
        {
            Console.WriteLine($"Department Code      : {DepartmentCode}");
            Console.WriteLine($"Year of Publication  : {YearOfPublication}");
            Console.WriteLine($"Number of Pages      : {NumberOfPages}");
            Console.WriteLine($"Book ID              : {BookID}");
        }
    }
}
