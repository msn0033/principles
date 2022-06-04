using SOLID___Interface_Segregation_Principle_ISP.After.Interface;

namespace SOLID___Interface_Segregation_Principle_ISP.After
{
    static class Repository
    {
       public static IEnumerable<Employee> GenerationEmployee() {
           return new List<Employee>(){
              new Staff()
              {
                  Id="001",
                  Name="saleh",
                  BasicSalary=1000
              },
                new Consultant()
              {
                  Id="002",
                  Name="Ali",
                  BasicSalary=1000
              },
                new DayLabourer()
              {
                  Id="003",
                  Name="murad",
                  BasicSalary=1000
              },
              new Staff()
              {
                  Id="00345",
                  Name="hossen",
                  BasicSalary=3489
              },
           };
       }

    }
}