using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDaysInMonth = int.Parse(Console.ReadLine());
            var daylyEarnings = double.Parse(Console.ReadLine());
            var dollarCurrency = double.Parse(Console.ReadLine());

            var monthlySalary = workDaysInMonth * daylyEarnings;
            var yearEarnings = (monthlySalary * 12 + monthlySalary * 2.5) - ((monthlySalary * 12 + monthlySalary * 2.5) * 0.25);
            var salaryInLevs = yearEarnings * dollarCurrency;
            var averageDaylySalary = salaryInLevs / 365;
            Console.WriteLine("{0:F2}",averageDaylySalary);
        }
    }
}
