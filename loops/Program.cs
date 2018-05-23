using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            double cntP1 = 0;
            double cntP2 = 0;
            double cntP3 = 0;
            double cntP4 = 0;
            double cntP5 = 0;

            for (int i = 1; i <= n; i++)
            {
                var numbers = int.Parse(Console.ReadLine());

                if (numbers < 200)
                {
                    cntP1++;
                }
                else if (numbers >= 200 && numbers <= 399)
                {
                    cntP2++;
                }
                else if (numbers >= 400 && numbers <= 599)
                {
                    cntP3++;
                }
                else if (numbers >= 600 && numbers <= 799)
                {
                    cntP4++;
                }
                else if (numbers >= 800)
                {
                    cntP5++;
                }
            }

            p1 = cntP1 * 100.0 / n;
            p2 = cntP2 * 100.0 / n;
            p3 = cntP3 * 100.0 / n;
            p4 = cntP4 * 100.0 / n;
            p5 = cntP5 * 100.0 / n;

            Console.WriteLine("{0:f2}", p1);
            Console.WriteLine("{0:f2}", p2);
            Console.WriteLine("{0:f2}", p3);
            Console.WriteLine("{0:f2}", p4);
            Console.WriteLine("{0:f2}", p5);
        }
    }
}
