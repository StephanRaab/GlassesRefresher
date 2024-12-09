namespace console1.Coupling;

public class EmailSender : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}