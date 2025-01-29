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
        public void AddEmployee()
        {
            //emps[Empcount] = new Employee(EmpId, EmpName, Dept, Salary);
        }
        public void ListEmployee()
        {

        }
        public void UpdateEmployee()
        {

        }
        public void DeleteEmployee()
        {

        }
    }
}
