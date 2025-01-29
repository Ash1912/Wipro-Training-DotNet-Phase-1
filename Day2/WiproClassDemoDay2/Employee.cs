using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproClassDemoDay2
{
    internal class Employee
    {
        //Members(Attributes) & Methods(Behaviour/Functions)
        public int emp_Id { get; set; }
        public string emp_Name { get; set; }

        //Constructor - Parameterized Constructor
        public Employee(int eid, string ename)
        {
            emp_Id = eid;
            emp_Name = ename;
        }
        public Employee() 
        {
            Console.WriteLine("Default Contructor Called");
        }
    }
}
