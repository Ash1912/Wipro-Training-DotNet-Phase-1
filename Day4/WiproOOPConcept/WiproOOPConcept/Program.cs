namespace WiproOOPConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.EmpId = 1;
            //employee.EmpName = "Ashish";

            ////emp.Display()

            //Department department = new Department();
            //department.EmpId = 2;
            //department.EmpName = "Urvashi";
            //department.DeptName = "TL";
            //department.Salary = 750000;

            //department.Display();
            ////department.Show();

            //Manager manager = new Manager();
            //manager.EmpId = 3;
            //manager.EmpName = "Ayush";
            //manager.DeptName = "Civil Engineer";
            //manager.Salary = 50000;
            //manager.ManagerName = "Urvashish";

            //manager.Display();

            //Console.WriteLine("\nTaking Input from User....");

            //Console.WriteLine("Enter Employee ID: ");
            //employee.EmpId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Employee Name: ");
            //employee.EmpName = Console.ReadLine();

            //Console.WriteLine("\nEmployee Details:");
            //employee.Display();

            //Console.WriteLine("\nEnter Employee ID: ");
            //department.EmpId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Employee Name: ");
            //department.EmpName = Console.ReadLine();
            //Console.WriteLine("Enter Department Name: ");
            //department.DeptName = Console.ReadLine();
            //Console.WriteLine("Enter Salary: ");
            //department.Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("\nDepartment Details:");
            //department.Display();

            //Console.WriteLine("\nEnter Employee ID: ");
            //manager.EmpId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Employee Name: ");
            //manager.EmpName = Console.ReadLine();
            //Console.WriteLine("Enter Department: ");
            //manager.DeptName = Console.ReadLine();
            //Console.WriteLine("Enter Salary: ");
            //manager.Salary = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Enter Manager Name: ");
            //manager.ManagerName = Console.ReadLine();

            //Console.WriteLine("\nManager Details:");
            //manager.Display();


            //Getting details according to base class constructor
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            string dname = Console.ReadLine();
            decimal sal = Convert.ToDecimal(Console.ReadLine());
            string mname = Console.ReadLine();
            Manager mgrcon = new Manager(id,name,dname,sal,mname);
            mgrcon.Display();

        }
    }
}