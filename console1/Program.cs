using console1;
using console1.Abstraction;
using console1.Coupling;
using console1.Polymorphism;
using InheritCar = console1.Inheritance.Car;
using CompCar = console1.Composition.Car;
using PolyCar = console1.Polymorphism.Car;
Console.WriteLine("\n==========\n");

IEnemy dragon = new Dragon();
IEnemy vampire = new Vampire();

List<IEnemy> enemies = new List<IEnemy>();
enemies.Add(dragon);
enemies.Add(vampire);

foreach (IEnemy enemy in enemies)
{
    enemy.Attack();
}

Console.WriteLine("\n==========\n");
Book book = new Book
{
    Title = "Harry Potter",
    Author = "J.K. Rowling",
    Year = 1997
};

book.ShowInfo();

Console.WriteLine("\n==========");
/* Composition
 Involves creating complex objects by combining simpler objects or components.
 Often described to have a "has-a" relationship => car has an engine, wheels, seats, etc
 
 Composition vs Inheritance
 Composition:
 - need more flexibility in constructing objects by assembling smaller, reusable components 
 - where there is no clear "is-a" relationship between classes
 - when you want to avoid limitations of inheritance, such as tight coupling and fragile base-class problem
 
 Inheritance:
 - When there's a clear "is-a" class relationship
 - When you want to promote code reuse by inheriting properties and behaviors from existing classes
 - When you want to leverage polymorphism to allow objects of different subclasses to be treated uniformly through their
 common superclass interface
*/

CompCar compositionCar = new CompCar();
compositionCar.StartCar();

Console.WriteLine("\n==========");
/* Coupling
 The degree of dependency between classes
*/

Order order = new Order(new SmsSender());
order.PlaceOrder();

Console.WriteLine("\n==========");
/* Polymorphism (poly = many, morph = forms)
 It's the ability for an object to take many forms
*/

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new PolyCar{Brand = "Toyota", Model = "Yaris", Year = "2007", NumberOfDoors = 3, NumberOfWheels = 4});
vehicles.Add(new Motorcycle{Brand = "Indian", Model = "Sportster", Year = "2005"});

// vehicle inspection
foreach (var vehicle in vehicles)
{
   vehicle.Start();
}

Console.WriteLine("\n==========");
/* Inheritance
involves creating new classes (subclasses and derived) based on existing classes (superclasses, or base classes)
subclasses inherit properties and behaviors from their superclasses and can also add new features or override
existing ones. Inheritance is often described in terms of an "is-a" relationship => circle is a shape (inherits from shape superclass/base class) 
*/

var inheritCar = new InheritCar
{
    NumberOfDoors = 2, // unique
    Brand = "Ford", // shared
    Model = "F150",
    Year = "1990"
};
inheritCar.Start();
inheritCar.Stop();

Console.WriteLine("\n==========");
// Abstraction
// reduce complexity by hiding unnecessary details
// pressing 'channel 2' button will change the channel. You don't need to know how everything is working to get you there.

// base solution with problems
EmailService emailService = new EmailService();
emailService.SendEmail(); // all complexity has been encapsulated and abstracted away within the service class

Console.WriteLine("\n==========");
// Encapsulation

BankAccount account = new BankAccount(500);
Console.WriteLine($"Current Balance: {account.GetBalance()}");

account.Deposit(100);
Console.WriteLine($"Current Balance: {account.GetBalance()}");

account.Withdraw(200);
Console.WriteLine($"Current Balance: {account.GetBalance()}");

Console.WriteLine("\n==========");
// BAD Encapsulation
BadBankAccount badAccount = new BadBankAccount();
badAccount.balance = 100;

Console.WriteLine(badAccount.balance);

Console.WriteLine("\n==========");

Console.WriteLine("How many times do you want to play fizzbuzz?");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("==========");

int fizzbuzzCount = 0;
int fizzCount = 0;
int buzzCount = 0;
int failCount = 0;

for (int i = 1; i <= max; i++)
{
    bool threeDiv = i % 3 == 0;
    bool fiveDiv = i % 5 == 0;
    
    if (threeDiv && fiveDiv)
    {
        Console.WriteLine("FizzBuzz");
        fizzbuzzCount++;
    } else if (threeDiv)
    {
        Console.WriteLine("Fizz");
        fizzCount++;
    } else if (fiveDiv)
    {
        Console.WriteLine("Buzz");
        buzzCount++;
    }
    else
    {
        Console.WriteLine(i);
        failCount++;
    }
}

Console.WriteLine($"FizzBuzz Count: {fizzbuzzCount}");
Console.WriteLine($"Fizz Count: {fizzCount}");
Console.WriteLine($"Buzz Count: {buzzCount}");
Console.WriteLine($"Number Count: {failCount}");

Console.WriteLine("==========");

Console.WriteLine("Enter your message:");
string message = Console.ReadLine();

if (!string.IsNullOrEmpty(message))
{
    for (int i = message.Length-1; i >= 0; i--)
    {
        Console.Write(message[i]);
    }
}
Console.WriteLine("\n==========");

// ask user to enter password
// ask them to enter password again
// check that they both contain something
// if yes, check that they are the same
// if they are, print "they match"
// else, print "passwords don't match"
// if they are empty, print "please enter a password"

string? password = string.Empty;
string? confirmPassword = string.Empty;
bool match = false;

while (!match)
{
    Console.Write("Please enter your password: ");
    password = Console.ReadLine();
    
    Console.Write("Please confirm your password: ");
    confirmPassword = Console.ReadLine();

    if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
    {
        Console.WriteLine("Can't leave your password empty");
    }

    if (password != null && password.Equals(confirmPassword))
    {
        Console.WriteLine("Passwords match");
        match = true;
    }
    else
    {
        Console.WriteLine("Passwords don't match");
    }
}

Console.WriteLine("\n==========");

/*
 * create two lists with integer data type
loop from 0 to 20
    if even, add to evenlist
    if odd, add to odd list
    
    print both lists
 */

List<int> evenList= new List<int>();
List<int> oddList = new List<int>();

for (int i = 0; i < 20; i++)
{
    if (i % 2 == 0)
    {
        evenList.Add(i);
    }
    else
    {
        oddList.Add(i);
    }
}

Console.WriteLine($"Even numbers are {string.Join(", ", evenList)}");
Console.WriteLine($"Odd numbers are {string.Join(", ", oddList)}");

Console.WriteLine("\n==========");

/* create and print array that takes in (num, length) and spits out the multiplication table
(7, 5) => (7, 14, 21, 28, 35]*/

Console.WriteLine("What do you want the multiplication table for?");
int multiplication = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many do you want?");
int multiplier = Convert.ToInt32(Console.ReadLine());

static void Multiply(int num, int length)
{
    List<int> result = new List<int>();
    for (int i = 1; i <= length; i++)
    {
        result.Add(num * i);
    }

    Console.WriteLine($"Multiply numbers are {string.Join(", ", result)}");
}

Multiply(multiplication, multiplier);

Console.WriteLine("\n==========");

/*
 * create a method that takes in an array, and returns the total sum of the array
 */

static bool SumOfArray(int[] nums, out int sumTotal)
{
    sumTotal = 0;
    if (nums.Length > 0)
    {
        foreach (int num in nums)
        {
            sumTotal += num;
        }    
        return true;
    }
    return false;
}

int[] numbers =
[
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
];

if (SumOfArray(numbers, out int sum))
{
    Console.WriteLine("The total sum of the array is: " + sum);
};

Console.WriteLine("\n==========");
