using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main()
        {
            var cargo = int.Parse(Console.ReadLine());
            var busCargo = 0.00;
            var truckCargo = 0.00;
            var trainCargo = 0.00;
            var totalCargo = 0.00;

            var busPercent = 0.00;
            var truckPercent = 0.00;
            var trainPercent = 0.00;
            var price = 0.00;

            for (int i = 1; i <= cargo; i++)
            {
                var ton = int.Parse(Console.ReadLine());

                if (ton <= 3)
                {
                    busCargo += ton;
                }
                if (ton > 3 && ton <= 11)
                {
                    truckCargo += ton;
                }
                if (ton > 11)
                {
                    trainCargo += ton;
                }

                totalCargo = busCargo + truckCargo + trainCargo;
                busPercent = (busCargo / totalCargo) * 100;
                truckPercent = (truckCargo / totalCargo) * 100;
                trainPercent = (trainCargo / totalCargo) * 100;
                price = (((busCargo * 200) + (truckCargo * 175) + (trainCargo * 120)) / totalCargo);
            }
            Console.WriteLine("{0:f2}", price);
            Console.WriteLine("{0:f2}%", busPercent);
            Console.WriteLine("{0:f2}%", truckPercent);
            Console.WriteLine("{0:f2}%", trainPercent);
        }
    }
}
