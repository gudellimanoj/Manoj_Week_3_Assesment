using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Program_9_Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Program_9_Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual double GetDiscountedPrice()
        {
            return Price; // No discount by default
        }
    }

    class ElectronicProduct : Program_9_Product
    {
        public ElectronicProduct(string name, double price) : base(name, price) { }

        public override double GetDiscountedPrice()
        {
            return Price * 0.90; // 10% discount
        }
    }

    class ClothingProduct : Program_9_Product
    {
        public ClothingProduct(string name, double price) : base(name, price) { }

        public override double GetDiscountedPrice()
        {
            return Price * 0.85; // 15% discount
        }
    }
}
