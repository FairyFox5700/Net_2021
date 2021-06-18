using FootballProject.Entities;

namespace FootballersTeam.ConsoleClient
{
    public class FootballerSalary
    {
        public delegate float SalaryCalculation(float salary);
 
        public static float HighSalary(float salary)
        {
            return 10 * salary / 100;
        }
        public static float LowSalary(float salary)
        {
            return 5 * salary / 100;
        }
        public static float MidSalary(float salary)
        {
            return 7 * salary / 100;
        }
        public static SalaryCalculation GetSalaryFormula(Footballer footballer)
        {
            return footballer.Role?.RoleName switch
            {
                "player" => FootballerSalary.MidSalary,
                "goalkeeper" => FootballerSalary.HighSalary,
                "defender" => FootballerSalary.LowSalary,
                _ => FootballerSalary.LowSalary
            };
        }
    }
}