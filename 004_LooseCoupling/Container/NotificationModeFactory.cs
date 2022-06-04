
public class NotificationModeFactory
{
    public static INotification CreateNotification(NotificationMode mode)
    {
        switch (mode)
        {
            case NotificationMode.sms:
                return new SmsService();
            case NotificationMode.email:
                return new EmailService();
            default:
                return new SmsService();//default
        }


    }
}

