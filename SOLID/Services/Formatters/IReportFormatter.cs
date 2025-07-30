using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Services.Formatters
{
    public interface IReportFormatter
    {
        string Format(string reportData);
    }

}
