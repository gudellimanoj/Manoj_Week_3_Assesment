using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Prgm_11_ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public Prgm_11_ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static Prgm_11_ComplexNumber operator +(Prgm_11_ComplexNumber c1, Prgm_11_ComplexNumber c2)
        {
            return new Prgm_11_ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        public override string ToString()
        {
            return Real.ToString() + " + " + Imaginary.ToString() + "i";
        }
    }
}
