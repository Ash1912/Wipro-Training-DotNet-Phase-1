using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodStaticDemo
{
    internal class EmployeeCRUDOp
    {
        private const int size = 5;
        //create an array of 5 employees
        int[] ar = new int[5];
        Employee[] emps = new Employee[size];
        //Employee emp = new Employee();
        private int Empcount = 0;

        //Methods to perform CRUD
        public void AddEmployee(int EmpId, string EmpName, string Dept, decimal Salary)
        {
            emps[Empcount] = new Employee(EmpId, EmpName, Dept, Salary);
            Empcount++;
            Console.WriteLine("Employee Added Successfully");
        }
        public void ListEmployee()
        {
            for (int i = 0; i < Empcount; i++)
            {
                emps[i].Display();
            }
        }
        public void UpdateEmployee()
        {

        }
        public void DeleteEmployee()
        {

        }
    }
}
