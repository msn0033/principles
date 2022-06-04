namespace SOLID___Single_Responsibility_Principle_SRP;

public class Account
{
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal Balance { get; set; }
    public Account(string name, string email, decimal balance)
    {
        Name = name;
        Email = email;
        Balance = balance;

    }
    public void MakeTransaction(decimal amount)//amount +/-
    {

        var transactionMessage = "";
        //withdrawal
        if (amount < 0)
        {
            if (Balance < Math.Abs(amount))
            {
                transactionMessage =
                $"OVERDRAFT when trying to Withdraw " +
                $"{Math.Abs(amount).ToString("C2")}," +
                $"Curent Balance {Balance.ToString("C2")}";
            }
            else
            {
                this.Balance -= amount;
                transactionMessage =
                $"Ok Withdraw {amount.ToString("C2")}" +
                $", Current balance {Balance.ToString("C2")}";
            }
        }

        //deposit
        else
        {
            //deposit 
            if (amount > 0)
            {
                Balance += amount;
                transactionMessage =
                $"Ok Deposit {amount.ToString("C2")}" +
                $", Current balance {Balance.ToString("C2")}";
            }

        }

        //sending email
        System.Console.WriteLine(
            $"\n\n\t\t To:{Email}" +
            $"\n\t\t Subject:Fake Bank Account Activity" +
            $"\n\n\t\t Dear {Name}, " +
            $"\n\n\t\t\t A recent activity on your account occures at{DateTime.Now.ToString()}" +
            $"\n\t\t\t\t ====>{0}" +
            $"\n\n\t\t Tahnk you , \n\t\t Fake Bank" +
            $"\n\n\t\t -------------------------", transactionMessage

        );

    }
}


