// See https://aka.ms/new-console-template for more information
using RefactoringDemo.Models;
using RefactoringDemo.Services;

Console.WriteLine("Hello, World!");

Employee per = new PermanentEmployee("Ashish");
Employee temp = new TemporaryEmployee("Urvashi");
Employee freelancer = new Freelancer("Ash");
Employee intern = new Intern("Ayush");

PayrollProcessor payroll = new PayrollProcessor();

payroll.ProcessPayroll(per, 40);
payroll.ProcessPayroll(freelancer, 12);
payroll.ProcessPayroll(intern, 0);
