using SOLID___Interface_Segregation_Principle_ISP.After.Interface;

namespace SOLID___Interface_Segregation_Principle_ISP.After
{
    public class DayLabourer : Employee, IHealthInsurance, ITransporttation
    {

        protected override decimal CalculatedSalary()
        {
            return BasicSalary + HealthInsurance() + Transporttation();
        }
        public override string PrintSalarySlip()
        {
            return $"\n\n\n-------------{nameof(DayLabourer)} --------- \n\n" +
                   $"Id             :{Id}\n" +
                   $"Name           :{Name}\n" +
                   $"Base Salary    :{BasicSalary.ToString("C")}\n" +
                   $"HealthInsurance:{HealthInsurance().ToString("C")}\n" +
                   $"Transporttation  :{Transporttation().ToString("C")}\n" +
                   $"....................................\n" +
                   $"Total          :{CalculatedSalary().ToString("C")}\n";
        }
        public decimal HealthInsurance() => 300m;

        public decimal Transporttation() => 150m;
    }
}