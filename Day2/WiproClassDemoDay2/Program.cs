namespace WiproClassDemoDay2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.emp_Id = 111;
            employee.emp_Name = "Test";

            Console.WriteLine($"Employee ID : {employee.emp_Id}");
            Console.WriteLine($"Employee Name : {employee.emp_Name}");

            Console.WriteLine("Enter the Employee Id: ");
            int id = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Enter the Employee Name: ");
            string name = Console.ReadLine();

            Employee employee2 = new Employee(id, name); //contructor will be called Instance creation

            Console.WriteLine($"Employee ID : {employee2.emp_Id}");
            Console.WriteLine($"Employee Name : {employee2.emp_Name}");
        }
    }
}