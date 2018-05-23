using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            if (money > 1000 && season == "summer" || money > 1000 && season == "winter")
            {
                var moneySpend = money * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", moneySpend);
            }
            else if (money > 100 && season == "summer")
            {
                var moneySpend = money * 0.40;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:f2}", moneySpend);
            }
            else if (money > 100 && season == "winter")
                   
            {
                var moneySpend = money * 0.80;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:f2}", moneySpend);
            }

           else if (money <= 100 && season == "summer")
            {
                var moneySpend = money * 0.30;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:f2}", moneySpend);
            }
            else if (money <= 100 && season == "winter")
            
            {
                var moneySpend = money * 0.70;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:f2}", moneySpend);
            }
        }
    }
}
