using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begining
{
    class Program
    {
        static void Main()
        {
             double vegPrice = double.Parse(Console.ReadLine());
             double fruitsPrice = double.Parse(Console.ReadLine());
               int vegPerKilo = int.Parse(Console.ReadLine());
               int fruitPerKilo = int.Parse(Console.ReadLine());
            
               double vegResult = vegPrice * vegPerKilo;
                double fruitsResult = fruitsPrice * fruitPerKilo;

               Console.WriteLine((vegResult + fruitsResult) / 1.94);

        }
    }
}
