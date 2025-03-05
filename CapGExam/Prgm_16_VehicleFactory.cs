using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    interface IVehicle
    {
        void Drive();
    }
    class Car1 : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }
    class Bike1 : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is driving");
        }
    }
    class Prgm_16_VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {
            return type.ToLower() == "car" ? new Car1() : new Bike1();
        }
    }
}
