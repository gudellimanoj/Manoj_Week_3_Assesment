namespace CapGExam
{
    abstract class Program_4_Animal
    {
        public string Name { get; set; }

        // Constructor to initialize Name
        public Program_4_Animal(string name)
        {
            Name = name;
        }

        // Abstract method (must be implemented by derived classes)
        public abstract void MakeSound();

        // Common method for all animals
        public void Display()
        {
            Console.WriteLine($"This is {Name}.");
        }
    }

    // Derived class: Dog
    class Dog : Program_4_Animal
    {
        public Dog(string name) : base(name) { }

        // Overriding abstract method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof! Woof!");
        }
    }

    // Derived class: Cat
    class Cat : Program_4_Animal
    {
        public Cat(string name) : base(name) { }

        // Overriding abstract method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow! Meow!");
        }
    }
}
