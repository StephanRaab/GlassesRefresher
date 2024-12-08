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

