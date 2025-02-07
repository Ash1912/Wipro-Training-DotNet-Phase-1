using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day10Assignment1.AfterRefactoring.Controllers;
using Day10Assignment1.AfterRefactoring.Models;
using Day10Assignment1.AfterRefactoring.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Day10Assignment1.AfterRefactoring
{
    public class DependencyInjection
    {
        public static ServiceProvider Configure()
        {
            return new ServiceCollection()
                .AddSingleton<IReportGenerator, ReportGenerator>()
                .AddSingleton<IReportFormatter, PdfReportFormatter>() // Change to ExcelReportFormatter if needed
                .AddSingleton<IReportSaver, FileReportSaver>()
                .AddSingleton<ReportController>()
                .BuildServiceProvider();
        }
    }
}
