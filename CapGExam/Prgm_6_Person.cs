using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Prgm_6_Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Prgm_6_Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    class Students : Prgm_6_Person
    {
        public int StudentId { get; set; }
        public Students(string name, int age, int studentId) : base (name, age)
        {
            StudentId = studentId;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Student -Name:{Name}, Age: {Age}, ID: {StudentId}");
        }
    }
    class Teacher :Prgm_6_Person
    {
        public string Subject { get; set; }
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Teacher -Name:{Name}, Age: {Age}, Subject: {Subject}");
        }
    }

}
