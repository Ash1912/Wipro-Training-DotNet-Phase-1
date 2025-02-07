using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day10Assignment2.Factory;

namespace Day10Assignment2.Tests
{
    public class FactoryTests
    {
        [Fact]
        public void Factory_CreatesCorrectDocument()
        {
            var pdf = DocumentFactory.CreateDocument("pdf");
            Assert.IsType<PDFDocument>(pdf);

            var word = DocumentFactory.CreateDocument("word");
            Assert.IsType<WordDocument>(word);
        }
    }
}
