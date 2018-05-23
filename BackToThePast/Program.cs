using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var inheritance = double.Parse(Console.ReadLine());
            var year = double.Parse(Console.ReadLine());
            var ageOld = 17;
            
            for (double currentYear = 1800; currentYear <= year; currentYear++)
            {
                ageOld++;
                if (currentYear % 2 == 0)
                {
                    inheritance = inheritance - 12000;
                }
                else if (currentYear % 2 != 0)
                {
                    inheritance = inheritance - (12000 + (50 * ageOld));
                }
                
            }

            Console.WriteLine(inheritance >= 0  ? 
                $"Yes! He will live a carefree life and will have{(inheritance): 0.00} dollars left." : 
                $"He will need{(Math.Abs(inheritance)): 0.00} dollars to survive.");
        }
    }
}
