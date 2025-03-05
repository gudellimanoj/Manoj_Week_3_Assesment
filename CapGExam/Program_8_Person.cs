using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Program_8_Person
    {
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Person: {Name}");
        }
    }
    class Student : Program_8_Person
    {
        public int RollNo { get; set; }
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Student: {Name}, Roll No: {RollNo}");
        }
    }
}
