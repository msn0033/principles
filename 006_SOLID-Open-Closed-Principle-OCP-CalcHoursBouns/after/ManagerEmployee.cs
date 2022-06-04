namespace Open_Closed_Principle__OCP_CalcHoursBouns.after
{
    public class ManagerEmployee : Employee
    {
        public override decimal CalcHourBouns(int hours)
        {
             return ((BaseSalary / 30) / hours) * 4;
        }
    }
}