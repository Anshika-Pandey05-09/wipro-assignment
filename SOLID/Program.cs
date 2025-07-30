// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using ReportManager.Services;
//using ReportManager.Services.Formatters;
//using ReportManager.Services.Interfaces;
//using ReportManager.Services.Reports;
using SOLID.Services;
using SOLID.Services.Formatters;
using SOLID.Services.Interfaces;
using SOLID.Services.Reports;


IReportContentProvider provider = new InventoryReport();
IReportFormatter formatter = new PdfReportFormatter();
IReportSaver saver = new ReportSaverService();

ReportService reportService = new ReportService(provider, formatter, saver);
reportService.GenerateAndSaveReport("dip-report.txt");