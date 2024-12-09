namespace console1.Polymorphism;

public class Motorcycle : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Motorcycle started");
    }

    public override void Stop()
    {
        Console.WriteLine("Motorcycle stopped");
    }
}