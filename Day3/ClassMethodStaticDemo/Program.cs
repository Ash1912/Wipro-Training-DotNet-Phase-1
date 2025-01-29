namespace ClassMethodStaticDemo
{
    internal class Program
    {
        static void Display(ref int n)//Method Definition
        {
            n *= 20; // 400
            Console.WriteLine("Value inside the method:" +n);
        }

        static void Outsample(out int n)//Method Definition
        {
            //n *= 20; 
            int a = 20;
            n = a * 20;
            Console.WriteLine("Value inside the outsample method:" + n);
        }

        static int Division(int a, int b, out int r)
        {
            r=a%b;//remainder will be returned as out parameter
            return a / b; //quotient
        }

        void Show() //Instance Method
        {
            Console.WriteLine("Instance Method");
        }
        //Method with return type
        int add(int a, int b)
        {
            return a + b;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.Show();
            int a = 20;
            Console.WriteLine("The value of a: " + a);
            Display(ref a);//method calling
            Console.WriteLine("The value of a after calling display method: " + a);
            int res = program.add(60, 50);
            Console.WriteLine("Sum is :" + res);
            Console.WriteLine(program.add(10, 20));

            //Out parameter
            Outsample(out a);
            Console.WriteLine("The value of a after calling outsample method: " + a);
            int result;
            Console.WriteLine(Division(100,5,out result));
            Console.WriteLine(result);


            Employee[] emp = new Employee[2];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Enter EmployeeId : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter EmployeeName : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Dept : ");
                string dept = Console.ReadLine();
                Console.WriteLine("Enter Salary : ");
                decimal sal = Convert.ToDecimal(Console.ReadLine());
                emp[i] = new Employee(id, name, dept, sal);
            }
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i].EmpId + " " + emp[i].EmpName);
            }
        }
    }
}