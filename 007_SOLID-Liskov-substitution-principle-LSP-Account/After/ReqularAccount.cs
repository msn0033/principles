namespace SOLID___Liskov_substitution_principle_LSP.After
{
    public abstract class ReqularAccount : Account
    {
        public ReqularAccount(string id, string name, decimal balance) : base(id, name, balance)
        {
        }
        public abstract void Withdraw(decimal amount);
    }
}