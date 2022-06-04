namespace Open_Closed_Principle__OCP_CalcHoursBouns.after
{
    public class ReqularEmployee : Employee
    {
        public ReqularEmployee(string id, string name, decimal d)
        {
            ID = id;
            Name = name;
            BaseSalary = d;
        }
        public override decimal CalcHourBouns(int hours)
        {
            return ((BaseSalary / 30) / 10) * hours *2;
        }
    }
}