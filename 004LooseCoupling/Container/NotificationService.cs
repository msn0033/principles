
public class NotificationService
{
    private readonly INotification _notification;
    public NotificationService(INotification notification)
    {
        this._notification = notification;

    }
    public void Notify()
    {
        _notification.send();
    }


}

