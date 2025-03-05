using System;

namespace CapGExam
{
    // Base class: Vehicle
    class Vehicle
    {
        // Property to store brand name
        public string Brand { get; set; }

        // Property to store vehicle speed
        public int Speed { get; set; }

        // Constructor to initialize vehicle properties
        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        // Method to display vehicle details
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    // Derived class: Car, inherits from Vehicle
    class Cars : Vehicle
    {
        // Additional property for Car
        public int NumberOfDoors { get; set; }

        // Constructor to initialize Car properties
        public Cars(string brand, int speed, int doors) : base(brand, speed)
        {
            NumberOfDoors = doors;
        }

        // Method to display Car details
        public void ShowCarDetails()
        {
            DisplayInfo(); // Calls base class method
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    // Derived class: Bike, inherits from Vehicle
    class Bikes : Vehicle
    {
        // Additional property for Bike
        public string Type { get; set; }

        // Constructor to initialize Bike properties
        public Bikes(string brand, int speed, string type) : base(brand, speed)
        {
            Type = type;
        }

        // Method to display Bike details
        public void ShowBikeDetails()
        {
            DisplayInfo(); // Calls base class method
            Console.WriteLine($"Bike Type: {Type}");
        }
    }

    
}
