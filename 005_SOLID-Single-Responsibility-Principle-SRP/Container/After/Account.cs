namespace SOLID___Single_Responsibility_Principle_SRP.Container.After
{
    public class Account
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }
        public Account(string name, string email, decimal balance)
        {
            this.Name = name;
            this.Email = email;
            this.Balance = balance;

        }
    }
}