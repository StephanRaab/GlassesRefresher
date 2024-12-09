namespace console1.Coupling;

public class Order
{
    public void PlaceOrder()
    {
        // place order logic
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail("Order has been placed successfully");
    }
}