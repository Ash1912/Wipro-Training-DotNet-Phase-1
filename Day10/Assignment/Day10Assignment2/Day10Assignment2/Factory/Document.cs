using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment2.Factory
{
    public abstract class Document
    {
        public abstract void Open();
    }

    public class PDFDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening PDF Document.");
        }
    }

    public class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Word Document.");
        }
    }
}
