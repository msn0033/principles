// See https://aka.ms/new-console-template for more information
using SOLID___Single_Responsibility_Principle_SRP.Container.After;

TestWithSRP();


void TestWithSRP(){
    var account=new Account("wood","wood@gm.com",10000);
    var accountservice =new AccountService();
    accountservice.Deposit(3000,account,"murad");
}