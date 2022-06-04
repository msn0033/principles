// See https://aka.ms/new-console-template for more information


using SOLID___Interface_Segregation_Principle_ISP.After;

var empList=Repository.GenerationEmployee();

foreach (var emp in empList)
{
    System.Console.WriteLine(emp.PrintSalarySlip());
}

