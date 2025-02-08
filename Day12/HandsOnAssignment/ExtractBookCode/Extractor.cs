using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBookCode
{
    public class Extractor
    {
        public static Book ExtractDetails(string bookCode)
        {
            if (bookCode.Length != 18)
            {
                Console.WriteLine("Invalid Book Code");
                return null;
            }

            string departmentCode = bookCode.Substring(0, 3);
            string yearStr = bookCode.Substring(3, 4);
            string pagesStr = bookCode.Substring(7, 5);
            string bookID = bookCode.Substring(12, 6);

            if (!ValidateDepartment(departmentCode))
            {
                Console.WriteLine("Invalid Department Code");
                return null;
            }

            if (!int.TryParse(yearStr, out int year) || year < 1900 || year > 2020)
            {
                Console.WriteLine("Invalid Year");
                return null;
            }

            if (!int.TryParse(pagesStr, out int pages) || pages < 1 || pages > 99999)
            {
                Console.WriteLine("Invalid Page Numbers");
                return null;
            }

            if (!ValidateBookID(bookID))
            {
                Console.WriteLine("Invalid Book ID");
                return null;
            }

            return new Book
            {
                DepartmentCode = departmentCode,
                YearOfPublication = year,
                NumberOfPages = pages,
                BookID = bookID
            };
        }

        private static bool ValidateDepartment(string code)
        {
            return code == "101" || code == "102" || code == "103";
        }

        private static bool ValidateBookID(string bookID)
        {
            return char.IsLetter(bookID[0]) && int.TryParse(bookID.Substring(1), out _);
        }
    }
}
