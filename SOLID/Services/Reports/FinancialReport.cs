using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Services.Reports
{
    public class FinancialReport : Report
    {
        public override string GetContent()
        {
            return "Financial Report Content: Profits up 25%";
        }
    }

}
