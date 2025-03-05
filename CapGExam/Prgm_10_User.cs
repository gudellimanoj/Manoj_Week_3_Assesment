using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Prgm_10_User
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public virtual void AccessControl() 
        {
            Console.WriteLine($"{Username} has basic user access");
        }
    }
    class Admin : Prgm_10_User
    {
        public override void AccessControl()
        {
            Console.WriteLine($"{Username} has admin access");
        }
    }
    class Customer : Prgm_10_User
    {
        public override void AccessControl()
        {
            Console.WriteLine($"{Username} has cuso access");
        }
    }
}
