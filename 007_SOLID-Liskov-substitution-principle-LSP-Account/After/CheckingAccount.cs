namespace SOLID___Liskov_substitution_principle_LSP.After
{
    public class CheckingAccount : ReqularAccount
    {
        public CheckingAccount(string id, string name, decimal balance) : base(id, name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount > 1000)
            {
                System.Console.WriteLine("You Cant withdraw more than $1000");
                return;
            }
            Balance -= amount;
        }
    }
}