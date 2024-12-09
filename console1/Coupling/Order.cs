namespace console1.Coupling;

public class Order
{
    private readonly INotificationService _notificationService;

    public Order(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    
    public void PlaceOrder()
    {
        // place order logic
        _notificationService.SendNotification("Order placed");
    }
}