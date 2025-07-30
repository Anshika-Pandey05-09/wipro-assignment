using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Services.Formatters
{

    public class PdfReportFormatter : IReportFormatter
    {
        public string Format(string reportData)
        {
            return $"[PDF Format]\n{reportData}";
        }
    }

}
