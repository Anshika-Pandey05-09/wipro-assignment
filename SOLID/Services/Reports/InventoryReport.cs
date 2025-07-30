using SOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Services.Reports
{
    public class InventoryReport : IReportContentProvider
    {
        public string GetContent()
        {
            return "Inventory Report: 500 items available";
        }
    }

}
