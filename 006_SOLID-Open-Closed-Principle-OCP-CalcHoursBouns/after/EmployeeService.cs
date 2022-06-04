namespace Open_Closed_Principle__OCP_CalcHoursBouns.after
{
    public class EmployeeService
    {
        public decimal CalculateHourBouns(Employee employee,int hours){
            return employee.CalcHourBouns(hours);
        }
        
    }
}