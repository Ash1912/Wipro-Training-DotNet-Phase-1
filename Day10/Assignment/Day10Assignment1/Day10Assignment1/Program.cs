using Day10Assignment1.AfterRefactoring.Controllers;
using Day10Assignment1.AfterRefactoring;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main()
    {
        var serviceProvider = DependencyInjection.Configure();

        var reportController = serviceProvider.GetService<ReportController>();
        reportController?.ProcessReport();
    }
}