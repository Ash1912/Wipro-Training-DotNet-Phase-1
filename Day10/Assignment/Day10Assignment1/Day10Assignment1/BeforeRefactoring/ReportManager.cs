using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment1.BeforeRefactoring
{
    public class ReportManager
    {
        public void GenerateReport()
        {
            string report = "Report Content";
            SaveReportToFile(report);
        }

        private void SaveReportToFile(string content)
        {
            File.WriteAllText("report.txt", content);
            Console.WriteLine("Report saved.");
        }
    }
}
