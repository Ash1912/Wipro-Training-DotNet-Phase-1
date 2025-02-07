using Xunit;
using Day10Assignment1.AfterRefactoring.Models;

namespace Day1Assignment1.Tests
{
    public class ReportFormatterTests
    {
        [Fact]
        public void PdfFormatter_ShouldFormatCorrectly()
        {
            var formatter = new PdfReportFormatter();
            string formatted = formatter.Format("Test Report");
            Assert.Equal("PDF Format: Test Report", formatted);
        }

        [Fact]
        public void ExcelFormatter_ShouldFormatCorrectly()
        {
            var formatter = new ExcelReportFormatter();
            string formatted = formatter.Format("Test Report");
            Assert.Equal("Excel Format: Test Report", formatted);
        }
    }
}