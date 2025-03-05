using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Prgm_5_Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting");
        }
    }
    class Car : Prgm_5_Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting");
        }
    }
    class Bike : Prgm_5_Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is starting");
        }
    }
}
