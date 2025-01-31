namespace MultipleInheritanceDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of employee:\n1.Permanent\n2.Temporary");
            string? type = Console.ReadLine();

            if (type.ToLower().Contains("per"))
            {
                //  IEmployee employee = new PermanentEmployee() { empid = 11, empname = "Ashish", salary = 70000 };
                PermanentEmployee permanentEmployee = new PermanentEmployee() { empid = 11, empname = "Ashish", salary = 70000 };
                permanentEmployee.BasicDetails();
                permanentEmployee.SalaryDetails();
                permanentEmployee.AttendMeetings();
                IEmployee emp = new PermanentEmployee() { empid = 12, empname = "Urvashi", salary = 80000 };
                emp.BasicDetails();
                emp.SalaryDetails();

            }
            else if (type.ToLower().Contains("temp"))
            {
                IEmployee tmp = new TemporaryEmployee()
                {
                    empid = 112,
                    empname = "Reigns",
                    salaryperday = 7000
                };
                tmp.BasicDetails();
                tmp.SalaryDetails();
            }

        }
    }
}