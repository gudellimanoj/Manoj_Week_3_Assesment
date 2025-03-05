using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
   sealed class Prgm_14_SecuritySystem
    {
        private string passord;
        public Prgm_14_SecuritySystem(string password)
        {
            this.passord = password;
        }
        public void Authenticate()
        {
            Console.WriteLine("Enter the password");
            string input = Console.ReadLine();
            if (input == passord)
            {
                Console.WriteLine("Authentication successful");
            }
            else
            {
                Console.WriteLine("Authentication failed");
            }
        }
    }
}
