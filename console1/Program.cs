Console.WriteLine("How many times do you want to play fizzbuzz?");
int max = Convert.ToInt32(Console.ReadLine());
int fizzbuzzCount = 0;
int fizzCount = 0;
int buzzCount = 0;
int failCount = 0;

for (int i = 1; i <= max; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
        fizzbuzzCount++;
    } else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
        fizzCount++;
    } else if (i % 5 == 0)
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



