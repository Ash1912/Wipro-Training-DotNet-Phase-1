using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment1.AfterRefactoring.Services
{
    public class FileReportSaver : IReportSaver
    {
        public void SaveReport(string content)
        {
            File.WriteAllText("report.txt", content);
            Console.WriteLine("Report saved successfully.");
        }
    }
}
