using CapGExam;
using System;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CapGExam

{
    internal class Program
    {
        static void Main(string[] args)

        //**Encapsulation Challenge**Create a `BankAccount`

        //{
        //    Prgm_1_BankAccount account = new Prgm_1_BankAccount(500);
        //    account.Deposit(200);
        //    account.Withdraw(100);
        //    account.Withdraw(700);
        //    Console.WriteLine($"Final Balance: {account.GetBalance():C}");
        //}

        //   Prgm_2_Student   **Data Hiding with Properties**Create a `Student` class where `Name` and `RollNo` are private fields.
        //{
        //    try
        //    {
        //        Prgm_2_Student student = new Prgm_2_Student("John Doe", 101);
        //        student.DisplayDetails();

        //        // Uncomment the following lines to test validation:
        //        // student.Name = ""; // Should throw an exception
        //        // student.RollNo = -5; // Should throw an exception
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }
        //}

        //-----------------

        //**Inheritance Challenge**Create a `Book` class with `Title`, `Author`, and `ISBN` properties.

        //{
        //    Prgm_3_Book book1 = new Prgm_3_Book();
        //    Prgm_3_Book book2 = new Prgm_3_Book("The Alchemist", "Paulo Coelho");
        //    Prgm_3_Book book3 = new Prgm_3_Book("1984", "George Orwell", "123-456-789");

        //    book1.DisplayBookInfo();
        //    book2.DisplayBookInfo();
        //    book3.DisplayBookInfo();
        //}

        //-----------------

        //**Polymorphism Challenge**Create a `Shape` class with an `Area` method. Create `Circle` and `Rectangle` classes that inherit from `Shape`.


        //{
        //    Prgm_4_Shape circle = new Circle(5);
        //    Prgm_4_Shape rectangle = new Rectangle(4, 6);

        //    Console.WriteLine($"Circle Area: {circle.Area():F2}");
        //    Console.WriteLine($"Rectangle Area: {rectangle.Area():F2}");
        //}

        //-----------------

        //{
        //    Vehicle myCar = new Car();
        //    Vehicle myBike = new Bike();

        //    myCar.Start();
        //    myBike.Start();
        //}

        //-----------------

        //**Using Virtual Methods in Inheritance**Create a `Person` base class with a `GetDetails()` method


        //{
        //    Person person1 = new Students("Alice", 20, 101);
        //    Person person2 = new Teacher("Mr. Smith", 40, "Mathematics");

        //    person1.GetDetails();
        //    person2.GetDetails();
        //}
        //-----------------


        //{
        //    Console.Write("Enter player type (Music/Video): ");
        //    string type = Console.ReadLine().ToLower();

        //    IPlayable player = type == "music" ? new Prgm_8_MusicPlayer() : new VideoPlayer();
        //    player.Play();  // Demonstrates interface-based polymorphism
        //}
        //-----------------

        //{
        //    Console.Write("Enter report content: ");
        //    string content = Console.ReadLine();

        //    Report report = new Report(content);

        //    Console.Write("Choose action (Print/Save): ");
        //    string action = Console.ReadLine().ToLower();

        //    if (action == "print")
        //        report.Print();
        //    else if (action == "save")
        //        report.SaveToFile();
        //    else
        //        Console.WriteLine("Invalid action.");
        //}
        //-----------------

        // **Method Overloading in a Calculator Class**Implement a `Calculator` class with overloaded methods `Add()`. 
        //{
        //    Calculator calc = new Calculator();

        //    Console.WriteLine("Addition of two integers: " + calc.Add(5, 10));
        //    Console.WriteLine("Addition of three integers: " + calc.Add(3, 7, 2));
        //    Console.WriteLine("Addition of two doubles: " + calc.Add(4.5, 2.3));
        //}

        //-----------------

        //{
        //    ComplexNumber num1 = new ComplexNumber(3, 4);
        //    ComplexNumber num2 = new ComplexNumber(1, 2);
        //    ComplexNumber sum = num1 + num2;

        //    Console.WriteLine("Sum of complex numbers: " + sum);
        //}

        //-----------------
        //{
        //    Bank acc1 = new Bank("Alice", 1000);
        //    Bank acc2 = new Bank("Bob", 2000);

        //    Console.WriteLine("Initial Interest Rate:");
        //    acc1.DisplayAccountInfo();
        //    acc2.DisplayAccountInfo();

        //    // Changing the interest rate
        //    Bank.SetInterestRate(6.5);

        //    Console.WriteLine("\nUpdated Interest Rate:");
        //    acc1.DisplayAccountInfo();
        //    acc2.DisplayAccountInfo();
        //}
        //-----------------

        //{
        //    Button btn = new Button();

        //    // Subscribe an event handler
        //    btn.OnClick += () => Console.WriteLine("Button Clicked!");

        //    Console.Write("Press Enter to Click the Button...");
        //    Console.ReadLine();

        //    btn.Click(); // Simulating button click
        //}
        //-----------------

        //{
        //    Console.Write("Enter vehicle type (Car/Bike): ");
        //    string vehicleType = Console.ReadLine();

        //    IVehicle vehicle = Progm_16_VehicleFactory.GetVehicle(vehicleType);
        //    vehicle.Drive(); // Calls the appropriate Drive method
        //}

        //-----------------
        //{
        //    Console.WriteLine("Logging an error:");
        //    string message = Console.ReadLine();
        //    ILogger logger = new Prgm_17_FileLogger();
        //    ILogger timestampLogger = new Prgm_17_TimestampLogger(logger);
        //    ILogger errorLogger = new Prgm_17_ErrorLogger(timestampLogger);
        //    errorLogger.Log(message);
        //}

        //-----------------
        //{
        //    Console.WriteLine("Press Enter to get Configuration Manager instance...");
        //    Console.ReadLine();

        //    prgm_18_ConfigurationManager config1 = prgm_18_ConfigurationManager.Instance;
        //    config1.ShowMessage();

        //    prgm_18_ConfigurationManager config2 = prgm_18_ConfigurationManager.Instance;
        //    Console.WriteLine(config1 == config2 ? "Same Instance" : "Different Instances");
        //}

        //-----------------progm_19_EmailNotifier-----------------
        //{
        //    NotificationService service = new NotificationService();

        //    service.Subscribe(new progm_19_EmailNotifier());
        //    service.Subscribe(new SMSNotifier());

        //    Console.Write("Enter notification message: ");
        //    string message = Console.ReadLine();

        //    service.NotifyAll(message); // Notifies all observers
        //}

        //-------------Prgm_20_ShoppingCart-----------------
        //{
        //    Prgm_20_ShoppingCart cart = new Prgm_20_ShoppingCart();

        //    Console.Write("Enter total price: ");
        //    double total = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Choose Discount Strategy:\n1. No Discount\n2. Percentage Discount\n3. Fixed Amount Discount");
        //    int choice = Convert.ToInt32(Console.ReadLine());

        //    switch (choice)
        //    {
        //        case 2:
        //            Console.Write("Enter discount percentage: ");
        //            double percentage = Convert.ToDouble(Console.ReadLine());
        //            cart.SetDiscountStrategy(new PercentageDiscount(percentage));
        //            break;
        //        case 3:
        //            Console.Write("Enter fixed discount amount: ");
        //            double amount = Convert.ToDouble(Console.ReadLine());
        //            cart.SetDiscountStrategy(new FixedAmountDiscount(amount));
        //            break;
        //        default:
        //            cart.SetDiscountStrategy(new NoDiscount());
        //            break;
        //    }

        //    Console.WriteLine($"Final Price: {cart.CalculateTotal(total)}");
        //}

        //---------------------------------------------------

        //C# Inheritance - Practical Questions

        //progrm_1
        //{
        //    Cars car = new Cars("Toyota", 180, 4);
        //    Bikes bike = new Bikes("Yamaha", 120, "Sports");

        //    Console.WriteLine("Car Details:");
        //    car.ShowCarDetails();

        //    Console.WriteLine("\nBike Details:");
        //    bike.ShowBikeDetails();
        //}

        //progrm_2
        //{
        //    Carr car = new Carr("Toyota", 180, 4);
        //    Bikee bike = new Bikee("Yamaha", 120, "Sports");

        //    Console.WriteLine("Car Details:");
        //    car.DisplayInfo(); // Calls the overridden method in Car

        //    Console.WriteLine("\nBike Details:");
        //    bike.DisplayInfo(); // Calls the overridden method in Bike
        //}

        //program_3
        //{
        //    // Creating Manager object
        //    Manager manager = new Manager("John Doe", 80000, 10000);

        //    Console.WriteLine("\nManager Details:");
        //    manager.DisplayInfo();
        //}

        //program_4

        //{
        //    // Creating objects of Dog and Cat
        //    Program_4_Animal dog = new Dog("Buddy");
        //    Program_4_Animal cat = new Cat("Whiskers");

        //    // Display and call MakeSound() method
        //    dog.Display();
        //    dog.MakeSound();

        //    Console.WriteLine();

        //    cat.Display();
        //    cat.MakeSound();
        //}

        //program_5
        //{
        //    // Creating an object of Robot
        //    Robot robot = new Robot();

        //    // Calling methods from both base class and interface
        //    robot.Start(); // Inherited from Machine
        //    robot.Move();  // Implemented from IMovable
        //}

        //program_6
        //{
        //    Program_6_Account acc = new Program_6_Account();
        //    acc.CalculateInterest();  // Calls base class method

        //    SavingsAccount savings = new SavingsAccount();
        //    savings.CalculateInterest();  // Calls overridden method in SavingsAccount
        //}


        //program_7

        //{
        //    // Creating an instance of Duck
        //    Program_7_Duck duck = new Program_7_Duck();

        //    // Calling methods from both interfaces
        //    duck.Fly();
        //    duck.Swim();
        //}

        //program_8
        //{ 
        //    Student student = new Student { Name = "Manu", RollNo = 101 };
        //    // 2️⃣ Upcasting: Student → Person (Implicit)
        //    Program_8_Person person = student;
        //     person.ShowDetails();  // ✅ Works (base class method)

        //    // 3️⃣ Downcasting: Person → Student (Explicit)
        //    if (person is Student)
        //    {
        //        Student downcastedStudent = (Student)person;
        //     downcastedStudent.DisplayStudentDetails();  // ✅ Works (derived class method)
        //    }
        //    Student safeStudent = person as Student;
        //    if (safeStudent != null)
        //    {
        //        safeStudent.DisplayStudentDetails();
        //    }
        //}

    //    {
    //    Console.Write("Enter product type (Electronic/Clothing): ");
    //    string type = Console.ReadLine().ToLower();

    //    Console.Write("Enter product name: ");
    //    string name = Console.ReadLine();

    //    Console.Write("Enter product price: ");
    //    double price = Convert.ToDouble(Console.ReadLine());

    //    Program_9_Product product;

    //    if (type == "electronic")
    //        product = new ElectronicProduct(name, price);
    //    else if (type == "clothing")
    //        product = new ClothingProduct(name, price);
    //    else
    //    {
    //        Console.WriteLine("Invalid product type! Using default price.");
    //        product = new Program_9_Product(name, price);
    //    }

    //    Console.WriteLine($"Final Price after discount: {product.GetDiscountedPrice()}");
    //}





    }
}
