using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Program_6_Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a general account...");
        }
    }
    class SavingsAccount : Program_6_Account
    {
        // Overriding CalculateInterest() and sealing it to prevent further overriding
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a savings account...");
        }
    }
}
