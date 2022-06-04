namespace SOLID___Liskov_substitution_principle_LSP.After
{
    public abstract class Account
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public Account(string id,string name,decimal balance)
        {
            Id=id;
            Name=name;
            Balance=balance;
        }

        public abstract void Deposit(decimal amount);

        public override string ToString()
        {
            return $" Balance : {Balance.ToString("C")} ";
        }
    }
}