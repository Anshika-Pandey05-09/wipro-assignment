using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Services
{
    internal class ReportSaver
    {
        public void SaveReport(string reportContent, string filePath)
        {
            try
            {
                File.WriteAllText(filePath, reportContent);
                Console.WriteLine("Report saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving report: {ex.Message}");
            }
        }

    }
}
