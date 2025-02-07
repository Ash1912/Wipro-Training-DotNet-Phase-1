using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment1.AfterRefactoring.Models
{
    public class ExcelReportFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return "Excel Format: " + content;
        }
    }

}
