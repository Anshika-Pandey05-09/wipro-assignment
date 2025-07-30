using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Services.Interfaces
{
    public interface IReportEmailSender
    {
        void SendEmail(string content, string recipient);
    }

}
