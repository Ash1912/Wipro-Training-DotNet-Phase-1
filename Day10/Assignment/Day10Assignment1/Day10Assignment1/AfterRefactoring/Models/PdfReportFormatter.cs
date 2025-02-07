using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment1.AfterRefactoring.Models
{
    public class PdfReportFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return "PDF Format: " + content;
        }
    }

}
