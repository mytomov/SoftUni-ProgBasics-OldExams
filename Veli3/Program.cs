using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veli3
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var totalDistance = 0.0;
            var totalTime = 0;
            var callsBurned = 0;
            

            for (int i = 1; i <= days; i++)
            {
                var timeRunning = int.Parse(Console.ReadLine());
                var distance = double.Parse(Console.ReadLine());
                var measure = Console.ReadLine();

                if (measure == "km")
                {
                    distance *= 1;
                }
                else if (measure == "m")
                {
                    distance *= 0.001;
                }

                totalDistance += distance;
                totalTime = timeRunning * days;
                callsBurned = totalTime * 20;
                

            }
               
            Console.WriteLine("He ran {0:f2}km for {1} minutes and burned {2} calories.", totalDistance, totalTime, callsBurned);
        }
    }
}
