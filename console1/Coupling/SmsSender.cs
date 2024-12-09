namespace console1.Coupling;

public class SmsSender : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Text message: {message}");
    }
}