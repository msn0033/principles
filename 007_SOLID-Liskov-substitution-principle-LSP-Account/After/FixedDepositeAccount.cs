namespace SOLID___Liskov_substitution_principle_LSP.After
{
    public class FixedDepositeAccount : Account
    {
        public FixedDepositeAccount(string id, string name, decimal balance)
        : base(id, name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}