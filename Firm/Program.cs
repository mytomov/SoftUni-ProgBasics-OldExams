using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main()
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var hoursPearWeek = (days * 10) * workers;
            var timeOff = hoursPearWeek - (hoursPearWeek * 0.10);
            var hoursLeft = Math.Abs(timeOff - hoursNeeded);

            if (timeOff >= hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(hoursLeft));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Floor(hoursLeft));
            }
        }
    }
}
