using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Utilities
{
    public sealed class Logger
    {
        private static Logger _instance = null;
        private static readonly object _lock = new object();

        // Private constructor prevents instantiation from outside
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Logger();
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG - {DateTime.Now}] {message}");
        }
    }
}
