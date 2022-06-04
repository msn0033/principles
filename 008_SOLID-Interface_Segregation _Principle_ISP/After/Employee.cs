namespace SOLID___Interface_Segregation_Principle_ISP.After
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal  BasicSalary { get; set; }
        protected abstract decimal CalculatedSalary();
        public abstract string PrintSalarySlip();
    }
}