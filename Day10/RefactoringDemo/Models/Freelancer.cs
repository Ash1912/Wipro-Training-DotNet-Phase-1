using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactoringDemo.Interfaces;

namespace RefactoringDemo.Models
{
    public class Freelancer : Employee, IPayable
    {
        public Freelancer(string name) : base(name) { }

        public override double CalculateSalary(int hoursWorked) => hoursWorked * 20;

        public void ProcessPayment(double salary)
        {
            Console.WriteLine($"Processing Payment for {Name}, Total Payment: {salary}");
        }
    }
}
