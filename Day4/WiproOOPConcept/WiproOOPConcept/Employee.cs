using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproOOPConcept
{
    internal class Employee //Base class/Parent class
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public Employee(int EmpId, string EmpName)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
        }

        public virtual void Display()
        {
            Console.WriteLine(EmpId+ " " +EmpName);
        }
    }
}
