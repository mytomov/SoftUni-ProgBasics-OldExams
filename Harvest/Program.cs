using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main()
        {
            var squareMeters = int.Parse(Console.ReadLine());
            var grapesPearMeter = double.Parse(Console.ReadLine());
            var litersNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var squareMetersLeft = (squareMeters * 0.100) * 4;
            var grapesForHarvest = (squareMetersLeft * grapesPearMeter) / 2.5;
            var wineLeft = Math.Abs(grapesForHarvest - litersNeeded);
            var wineForWorkers = wineLeft / workers;

            if (grapesForHarvest >= litersNeeded)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(grapesForHarvest));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineLeft), Math.Ceiling(wineForWorkers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wineLeft));
            }
            
        }
    }
}
