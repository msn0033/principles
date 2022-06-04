namespace SOLID_Dependency_Inversion_Principle_DIP.After
{
    public class SmsService: IMessageService
    {
        
        public string Mobile { get; set; }
        public void Send(){
            System.Console.WriteLine($"Sms is sent to {Mobile}");
        }
    }
}