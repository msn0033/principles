using SOLID_Dependency_Inversion_Principle_DIP.After;

namespace _SOLID_Dependency_Inversion_Principle_DIP.After
{
    public class Customer :IMessageService
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }

        public void Send()
        {
            System.Console.WriteLine("Customer");
           // throw new NotImplementedException();
        }
    }
}