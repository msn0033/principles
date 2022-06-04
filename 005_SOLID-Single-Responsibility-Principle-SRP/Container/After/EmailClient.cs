namespace SOLID___Single_Responsibility_Principle_SRP.Container.After
{
    public class EmailClient
    {
        public static void sendEmail(Account account, string transactionMessage, DateTime transactionDate)
        {

            //sending email
            System.Console.WriteLine(
                $"\n\n\t\t To:{account.Email}" +
                $"\n\t\t Subject:Fake Bank Account Activity" +
                $"\n\n\t\t Dear {account.Name}, " +
                $"\n\n\t\t\t A recent activity on your account occures at{transactionDate.ToString("yyyy-MM-dd hh:mm")}" +
                "\n\t\t\t\t ====>{0}" +
                $"\n\n\t\t Tahnk you , \n\t\t Fake Bank" +
                $"\n\n\t\t -------------------------", transactionMessage

            );
        }
    }
}