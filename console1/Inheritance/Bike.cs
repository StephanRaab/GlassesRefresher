namespace console1.Inheritance;

public class Bike
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle is starting...");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle is stopping...");
    }
}