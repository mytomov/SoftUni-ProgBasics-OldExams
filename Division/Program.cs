using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;

            double percentOne = 0.00;
            double percentTwo = 0.00;
            double percentThree = 0.00;

            for (int i = 1; i <= numbers; i++)
            {
                var nums = int.Parse(Console.ReadLine());

                if (nums % 2 == 0)
                {
                    p1++;
                    
                }
                if (nums % 3 == 0)
                {
                    p2++;
                    
                }
               if (nums % 4 == 0)
                {
                    p3++;
                    
                }
            }

            percentOne = (p1 / numbers) * 100;
            percentTwo = (p2 / numbers) * 100;
            percentThree = (p3 / numbers) * 100;

            Console.WriteLine("{0:f2}%", percentOne);
            Console.WriteLine("{0:f2}%", percentTwo);
            Console.WriteLine("{0:f2}%", percentThree);
        }
    }
}
