namespace console1.Polymorphism;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public int NumberOfWheels { get; set; }

    public override void Start()
    {
        Console.WriteLine("Car started");
    }

    public override void Stop()
    {
        Console.WriteLine("Car stopped");
    }
}