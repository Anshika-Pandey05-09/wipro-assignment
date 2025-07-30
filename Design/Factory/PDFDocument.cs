using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Factory
{
    public class PDFDocument : IDocument
    {
        public void Generate()
        {
            Console.WriteLine("Generating PDF Document...");
        }
    }
}
