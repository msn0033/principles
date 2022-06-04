namespace Open_Closed_Principle__OCP_CalcHoursBouns.after
{
    public abstract class Employee
    {
        public string ID { get; set; }
        public string  Name { get; set; }
        public decimal BaseSalary { get; set; }
        public abstract decimal CalcHourBouns(int hours);
    }
}