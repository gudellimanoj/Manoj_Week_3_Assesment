using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Prgm_2_Student
    {
        private string name;
        private int rollno;

        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                name = value;
            }
        }
        public int Rollno
        {
            get { return rollno; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Roll number must be greater than zero");
                }
                rollno = value;
            }
        }
        public Prgm_2_Student(string name, int rollno)
        {
            Name = name;
            Rollno = rollno;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Roll Number: {Rollno}");
        }

    }
}
