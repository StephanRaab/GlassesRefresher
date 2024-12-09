namespace console1.Composition;

public class Car
{
    private Chassis _chassis = new Chassis();
    private Engine _engine = new Engine();
    private Seats _seats = new Seats();
    private Wheels _wheels = new Wheels();

    public void StartCar()
    {
        _chassis.Support();
        _engine.Start();
        _seats.Sit();
        _wheels.Rotate();
        
        Console.WriteLine("Car started");
    }
}