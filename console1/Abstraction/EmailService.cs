namespace console1.Abstraction;

public class EmailService
{
    public void SendEmail()
    {
        Console.WriteLine($"Sending email...");
    }

    public void Connect()
    {
        Console.WriteLine("Connecting to the email server...");
    }

    public void Authenticate()
    {
        Console.WriteLine("Authenticating...");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from the email server...");
    }
}