using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Program_3_Emp
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        // Constructor to initialize Employee properties
        public Program_3_Emp(string name, double salary)
        {
            Name = name;
            Salary = salary;
            Console.WriteLine("Employee Constructor Called");
        }

        // Method to display Employee details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary:C}");
        }
    }

    // Derived class: Manager (inherits from Employee)
    class Manager : Program_3_Emp
    {
        public double Bonus { get; set; }

        // Constructor chaining: Calls base class constructor
        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
            Console.WriteLine("Manager Constructor Called");
        }

        // Method to display Manager details (including bonus)
        public new void DisplayInfo()
        {
            base.DisplayInfo(); // Calls base class method
            Console.WriteLine($"Bonus: {Bonus:C}");
        }
    }
}
