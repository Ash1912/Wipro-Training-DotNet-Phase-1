using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAgeApp
{
    public class Person
    {
        // Private Fields
        private string firstName;
        private string lastName;
        private DateTime dob;

        // Public Properties (Read-Write)
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        // Read-Only Property for Age Calculation
        public int Age
        {
            get { return GetAge(dob); }
        }

        // Read-Only Property to Determine Adult or Child
        public string Adult
        {
            get { return Age >= 18 ? "Adult" : "Child"; }
        }

        // Method to Calculate Age
        public int GetAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now < dob.AddYears(age))
            {
                age--;
            }
            return age;
        }

        // Method to Display Details
        public void DisplayDetails()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine(Adult);
        }
    }
}
