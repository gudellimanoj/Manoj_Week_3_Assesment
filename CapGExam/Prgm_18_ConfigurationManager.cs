using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    public sealed class prgm_18_ConfigurationManager
    {
        private static prgm_18_ConfigurationManager instance;
        private static readonly object lockObject = new object(); // Corrected lockObject

        private prgm_18_ConfigurationManager()
        {
            Console.WriteLine("Configuration Manager Initialized.");
        }

        public static prgm_18_ConfigurationManager Instance
        {
            get
            {
                if (instance == null) // First Check
                {
                    lock (lockObject) // Thread-Safe Locking
                    {
                        if (instance == null) // Second Check
                        {
                            instance = new prgm_18_ConfigurationManager();
                        }
                    }
                }
                return instance;
            }

        }
        public void ShowMessage()
        {
            Console.WriteLine("Singleton Instance: Configuration Loaded");
        }
    }
}
