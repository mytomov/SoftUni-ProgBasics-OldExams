using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeshoTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoinAmount = int.Parse(Console.ReadLine());
            var yoansAmount = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine()) / 100.00;

            var levs = bitcoinAmount * 1168;
            var dollars = yoansAmount * 0.15;
            var dollarsToLevs = dollars * 1.76;
            var totalAmount = (levs + dollarsToLevs) / 1.95 - ((levs + dollarsToLevs) / 1.95 * comission);
            
            Console.WriteLine(totalAmount);

        }
    }
}
