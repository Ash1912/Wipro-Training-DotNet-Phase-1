using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Employee()
        {
            Console.WriteLine("Default constructor");
        }
        public Employee(int ID, string Name, string Address)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name cannot be null or empty", nameof(Name));
            }

            this.Id = ID;
            this.Name = Name;  // Ensure Name is never null or empty
            this.Address = Address;
        }


        public void PrintID()
        {
            Console.WriteLine("Display" + Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name" + Name);
        }

    }
}
