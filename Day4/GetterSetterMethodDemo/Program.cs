namespace GetterSetterMethodDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student();
            student.Stuid = 19;
            student.Name = "Ashish";
            student.Age = 25;
            Console.WriteLine(student.Stuid);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            //student.SId = 111;//set accessor will invoke
            //Console.WriteLine(student.SId);//get access will invoke
        }
    }
}