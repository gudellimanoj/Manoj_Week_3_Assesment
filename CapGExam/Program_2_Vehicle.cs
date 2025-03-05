using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Program_2_Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        // Constructor to initialize vehicle properties
        public Program_2_Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        // Virtual method to display vehicle details
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    // Derived class: Car
    class Carr : Program_2_Vehicle
    {
        public int NumberOfDoors { get; set; }

        // Constructor to initialize Car properties
        public Carr(string brand, int speed, int doors) : base(brand, speed)
        {
            NumberOfDoors = doors;
        }

        // Overriding DisplayInfo method to include additional car details
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Calls the base class method
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    // Derived class: Bike
    class Bikee : Program_2_Vehicle
    {
        public string Type { get; set; }

        // Constructor to initialize Bike properties
        public Bikee(string brand, int speed, string type) : base(brand, speed)
        {
            Type = type;
        }

        // Overriding DisplayInfo method to include additional bike details
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Calls the base class method
            Console.WriteLine($"Bike Type: {Type}");
        }
    }
}
