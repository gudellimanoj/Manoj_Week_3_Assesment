using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    interface IPrintable
    {
        void Print();
    }
    interface ISerializable
    {
        void SaveToFile();
    }
    class Prgm_9_Report : IPrintable, ISerializable
    {
        private string reportContent;
        public Prgm_9_Report(string reportContent)
        {
            this.reportContent = reportContent;
        }
        public void Print()
        {
            Console.WriteLine("Printing report: " + reportContent);
        }
        public void SaveToFile()
        {
            File.WriteAllText("report.txt", reportContent);

            Console.WriteLine("Saving report to file: " + reportContent);
        }
    }
}
