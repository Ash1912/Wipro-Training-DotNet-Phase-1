using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day10Assignment1.AfterRefactoring.Models;
using Day10Assignment1.AfterRefactoring.Services;

namespace Day10Assignment1.AfterRefactoring.Controllers
{
    public class ReportController
    {
        private readonly IReportGenerator _reportGenerator;
        private readonly IReportFormatter _reportFormatter;
        private readonly IReportSaver _reportSaver;

        public ReportController(IReportGenerator reportGenerator, IReportFormatter reportFormatter, IReportSaver reportSaver)
        {
            _reportGenerator = reportGenerator;
            _reportFormatter = reportFormatter;
            _reportSaver = reportSaver;
        }

        public void ProcessReport()
        {
            string report = _reportGenerator.GenerateReport();
            string formattedReport = _reportFormatter.Format(report);
            _reportSaver.SaveReport(formattedReport);
        }
    }

}
