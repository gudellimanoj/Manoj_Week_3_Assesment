using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    interface IMovable
    {
        void Move(); // Method to be implemented by classes
    }

    // Base class: Machine
    class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine is starting...");
        }
    }

    // Derived class: Robot (inherits from Machine, implements IMovable)
    class Robot : Machine, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving forward...");
        }
    }
}
