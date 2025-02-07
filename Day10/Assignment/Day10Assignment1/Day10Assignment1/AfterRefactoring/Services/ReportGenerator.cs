using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment1.AfterRefactoring.Services
{
    public class ReportGenerator : IReportGenerator
    {
        public string GenerateReport()
        {
            return "This is a generated report.";
        }
    }

}
