using SOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Services
{
    public class ReportSaverService : IReportSaver
    {
        public void SaveToFile(string content, string path)
        {
            File.WriteAllText(path, content);
            Console.WriteLine("Report saved successfully.");
        }
    }
}
