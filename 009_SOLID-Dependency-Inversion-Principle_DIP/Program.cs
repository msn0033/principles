// See https://aka.ms/new-console-template for more information
using _SOLID_Dependency_Inversion_Principle_DIP.After;
using SOLID_Dependency_Inversion_Principle_DIP.After;

 
 EmailService  emailService=null;
 NotificationService notificationService=null;

 Calling call=null;


foreach (var cust in Repository.Customers)
{

    emailService=new EmailService();
    emailService.EmailAddress=cust.EmailAddress;
    notificationService=new NotificationService(emailService);
    notificationService.Notify();

    call=new Calling();
    call.Phone=cust.MobileNo;
    notificationService=new NotificationService(call);
    notificationService.Notify();
    

}