namespace SOLID_Dependency_Inversion_Principle_DIP.After
{
    public class EmailService:IMessageService
    {
        public string EmailAddress { get; set; }
        public void Send(){
         System.Console.WriteLine($"Email is Sent to {EmailAddress}");   
        }
    }
}