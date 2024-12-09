namespace console1.Polymorphism;

public class Plane : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Plane started");
    }

    public override void Stop()
    {
        Console.WriteLine("Plane has stopped");
    }
}