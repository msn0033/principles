using SOLID___Interface_Segregation_Principle_ISP.After.Interface;

namespace SOLID___Interface_Segregation_Principle_ISP.After
{
    public class Consultant : Employee, IBonus, IHealthInsurance, ITransporttation
    {

        protected override decimal CalculatedSalary()
        {
            return BasicSalary + Bonus() + HealthInsurance() + Transporttation();
        }
        public override string PrintSalarySlip()
        {
            return $"\n\n\n-------------{nameof(Consultant)} --------- \n\n" +
                   $"Id             :{Id}\n" +
                   $"Name           :{Name}\n" +
                   $"Base Salary    :{BasicSalary.ToString("C")}\n" +
                   $"Bonus          :{Bonus().ToString("C")}\n" +
                   $"HealthInsurance:{HealthInsurance().ToString("C")}\n" +
                   $"Transporttation  :{Transporttation().ToString("C")}\n" +
                   $"....................................\n" +
                   $"Total          :{CalculatedSalary().ToString("C")}\n";
        }

        public decimal Bonus() => BasicSalary * 0.05m;

        public decimal HealthInsurance() => 300m;

        public decimal Transporttation() => 150m;
    }
}