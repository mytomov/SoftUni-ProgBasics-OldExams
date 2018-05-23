using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortress
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            if (n > 4)
            {
                Console.Write(new string('_', n / 2));
            }
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");

            for (int rows = 1; rows <= n; rows++)
            {

                Console.Write("|", n - 2);
                if (n > 4 && rows == n - 1)
                {
                   // Console.Write("|");
                    Console.Write(new string(' ', n / 2 + 1));
                    Console.Write(new string('_', (2 * n) - 2 * (n / 2) - 4));
                    Console.Write(new string(' ', n / 2 + 1));
                   // Console.WriteLine("|");

                }
               if (n <= 4)
               {
                   // Console.Write("|");
                    Console.Write(new string(' ', n * 2 - 2));
                   // Console.WriteLine("|");
               }
                Console.WriteLine("|", n / 2);

            }
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            if (n > 4)
            {
                Console.Write(new string(' ', n / 2));
            }
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
        }
    }
}
