namespace console1.Composition;

public class Car
{
    private readonly Chassis _chassis = new Chassis();
    private readonly Engine _engine = new Engine();
    private readonly Seats _seats = new Seats();
    private readonly Wheels _wheels = new Wheels();

    public void StartCar()
    {
        _chassis.Support(); // car is delegating work with nice action verbs
        _engine.Start();
        _seats.Sit();
        _wheels.Rotate();
        
        Console.WriteLine("Car started");
    }
}