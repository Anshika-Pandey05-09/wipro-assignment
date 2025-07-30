using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Factory
{
    public static class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
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
