
INotification serviceMode = NotificationModeFactory.CreateNotification(NotificationMode.email);
NotificationService notificationService=new NotificationService(serviceMode);
notificationService.Notify();


