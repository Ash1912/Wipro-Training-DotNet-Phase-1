using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day10Assignment1.AfterRefactoring.Services;

namespace Day1Assignment1.Tests
{
    public class ReportGeneratorTests
    {
        [Fact]
        public void GenerateReport_ShouldReturnReport()
        {
            var reportGenerator = new ReportGenerator();
            string report = reportGenerator.GenerateReport();
            Assert.Equal("This is a generated report.", report);
        }
    }
}
