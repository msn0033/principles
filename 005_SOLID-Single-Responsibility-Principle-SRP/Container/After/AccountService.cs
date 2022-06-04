namespace SOLID___Single_Responsibility_Principle_SRP.Container.After
{
    public class AccountService
    {

        public void withDraw(decimal amount, Account account, string transactionMessage)
        {
            
                if (account.Balance < Math.Abs(amount))
                {
                    transactionMessage =
                    $"OVERDRAFT when trying to Withdraw " +
                    $"{Math.Abs(amount).ToString("C2")}," +
                    $"Curent Balance {account.Balance.ToString("C2")}";
                }
                else
                {
                    account.Balance -= amount;
                    transactionMessage =
                    $"Ok Withdraw {amount.ToString("C2")}" +
                    $", Current balance {account.Balance.ToString("C2")}";
                }

                EmailClient.sendEmail(account,transactionMessage,DateTime.Now);

        }
        public void Deposit(decimal amount, Account account, string transactionMessage)
        {
            //deposit 
            
            if (amount > 0)
            {
                account.Balance += amount;
                transactionMessage =
                $"Ok Deposit {amount.ToString("C2")}" +
                $", Current balance {account.Balance.ToString("C2")}";
            }

            EmailClient.sendEmail(account,transactionMessage,DateTime.Now);
        }

    }
}