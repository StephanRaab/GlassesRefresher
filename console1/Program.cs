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
create two lists with integer data type
loop from 0 - 20
    if even, add to evenlist
    if odd, add to odd list
    
    print both lists*/

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
