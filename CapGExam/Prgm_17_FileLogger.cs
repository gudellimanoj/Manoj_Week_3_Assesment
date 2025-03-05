using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    interface ILogger
    {
        void Log(string message);
    }
    class Prgm_17_FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to a file: " + message);
        }
    }
    class Prgm_17_TimestampLogger : ILogger
    {
        private ILogger logger;
        public Prgm_17_TimestampLogger(ILogger logger)
        {
            this.logger = logger;
        }
        public void Log(string message)
        {
            logger.Log($"{DateTime.Now} - {message}");
        }
    }
    class Prgm_17_ErrorLogger : ILogger
    {
        private ILogger logger;
        public Prgm_17_ErrorLogger(ILogger logger)
        {
            this.logger = logger;
        }
        public void Log(string message)
        {
            logger.Log($"ERROR: {message}");
        }
    }
}
