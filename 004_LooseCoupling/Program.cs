
INotification serviceMode = NotificationModeFactory.CreateNotification(NotificationMode.sms);
NotificationService notificationService=new NotificationService(serviceMode);
notificationService.Notify();


