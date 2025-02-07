using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day10Assignment1.AfterRefactoring.Services;

namespace Day1Assignment1.Tests
{
    public class ReportSaverTests
    {
        [Fact]
        public void SaveReport_ShouldCreateFile()
        {
            var reportSaver = new FileReportSaver();
            string content = "Test Report";

            reportSaver.SaveReport(content);

            Assert.True(File.Exists("report.txt"));
            Assert.Equal(content, File.ReadAllText("report.txt"));
        }
    }
}
