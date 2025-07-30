using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Factory
{
    public class WordDocument : IDocument
    {
        public void Generate()
        {
            Console.WriteLine("Generating Word Document...");
        }
    }
}
