using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapTravel
{
    class Program
    {
        static void Main()
        {
            var distance = int.Parse(Console.ReadLine());
            var timeOfDay = Console.ReadLine();

            if (distance >= 100)
            {
                var trainPrice = distance * 0.06;
                Console.WriteLine(Math.Round(trainPrice, 2));
            }
            else if (distance < 100 && distance >= 20)
            {
                var busPrice = distance * 0.09;
                Console.WriteLine(Math.Round(busPrice, 2));
            }
            else if (distance < 20)
            {
                if (timeOfDay == "day")
                {
                    var taxiPrice = distance * 0.79 + 0.70;
                    Console.WriteLine(taxiPrice);
                }
                else
                {
                    var taxiPrice = distance * 0.90 + 0.70;
                    Console.WriteLine(taxiPrice);
                }
            }
        }
    }
}
