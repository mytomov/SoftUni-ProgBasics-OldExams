using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCat
{
    class Program
    {
        static void Main()
        {
            var holidays = int.Parse(Console.ReadLine());

             var workingDays = 365 - holidays;
             var timeForPlay = (workingDays * 63) + (holidays * 127);
             var timeLeft = Math.Abs(30000 - timeForPlay);
             var hours = timeLeft / 60;
             var minutes = timeLeft % 60;
            
             if (timeForPlay > 30000)
             {
                 Console.WriteLine("Tom will run away");
                 Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
             }
             else
             {
                 Console.WriteLine("Tom sleeps well");
                 Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
             }
            
        }
    }
}
