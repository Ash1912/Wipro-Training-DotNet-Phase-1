using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment2.Factory
{
    public class DocumentFactory
    {
        public static Document CreateDocument(string type)
        {
            return type.ToLower() switch
            {
                "pdf" => new PDFDocument(),
                "word" => new WordDocument(),
                _ => throw new ArgumentException("Invalid document type")
            };
        }
    }
}
