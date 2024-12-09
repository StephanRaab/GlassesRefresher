namespace console1.Polymorphism;

public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }

    public virtual void Start() // virtual means that they can be overwritten
    {
        Console.WriteLine("Vehicle is starting...");
    }

    public virtual void Stop()
    {
        Console.WriteLine("Vehicle is stopping...");
    }
}