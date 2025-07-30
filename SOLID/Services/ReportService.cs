using SOLID.Services.Formatters;
using SOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Services
{
    public class ReportService
    {
        private readonly IReportContentProvider _provider;
        private readonly IReportFormatter _formatter;
        private readonly IReportSaver _saver;

        public ReportService(
            IReportContentProvider provider,
            IReportFormatter formatter,
            IReportSaver saver)
        {
            _provider = provider;
            _formatter = formatter;
            _saver = saver;
        }

        public void GenerateAndSaveReport(string path)
        {
            string content = _provider.GetContent();
            string formatted = _formatter.Format(content);
            _saver.SaveToFile(formatted, path);
        }
    }
}
