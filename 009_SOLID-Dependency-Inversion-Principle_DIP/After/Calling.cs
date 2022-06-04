namespace SOLID_Dependency_Inversion_Principle_DIP.After
{
    public class Calling :IMessageService
    {
        public string Phone { get; set; }
        public void Send(){
            System.Console.WriteLine($"Calling is sent to {Phone}");
        }
    }
}