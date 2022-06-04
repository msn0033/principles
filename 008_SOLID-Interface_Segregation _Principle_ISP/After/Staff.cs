namespace SOLID___Interface_Segregation_Principle_ISP.After.Interface
{
    public class Staff : Employee, IBonus, IHealthInsurance, IRentalSubsidy, IPension
    {
        protected override decimal CalculatedSalary()
        {
            return BasicSalary + Bonus() + HealthInsurance() + RentalSubsidy() + Pension();
        }
         public override string PrintSalarySlip()
        {
            return $"\n\n\n-------------{nameof(Staff)} --------- \n\n"+
                   $"Id             :{Id}\n"+
                   $"Name           :{Name}\n"+
                   $"Base Salary    :{BasicSalary.ToString("C")}\n" +
                   $"Bonus          :{Bonus().ToString("C")}\n" +
                   $"HealthInsurance:{HealthInsurance().ToString("C")}\n" +
                   $"RentalSubsidy  :{RentalSubsidy().ToString("C")}\n" +
                   $"Pension        :{Pension().ToString("C")}\n" +
                   $"....................................\n" +
                   $"Total          :{CalculatedSalary().ToString("C")}\n" ;
        }
        public decimal Bonus()
        {
            return BasicSalary * 0.05m;
        }

        public decimal HealthInsurance()
        {
            return 300m;
        }
        public decimal RentalSubsidy()
        {
            return 150m;
        }
        public decimal Pension()
        {
            return BasicSalary * 0.025m;
        }
    }
}
