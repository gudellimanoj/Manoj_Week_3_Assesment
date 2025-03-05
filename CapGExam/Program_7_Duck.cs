using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    // Interface for flying behavior
    interface IFlyable
    {
        void Fly();
    }

    // Interface for swimming behavior
    interface ISwimmable
    {
        void Swim();
    }
    class Program_7_Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying...");
        }
        public void Swim()
        {
            Console.WriteLine("Duck is swimming...");
        }
    }
   
}
