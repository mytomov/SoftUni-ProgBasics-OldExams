using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            for (int i = 0; i < n - 2; i++)
            {
                var pipes = new string('/', (n * 2) - 2);
                var spaces = new string(' ', n);
                
                
                Console.Write("*");
                Console.Write(pipes);
                Console.Write("*");
                if (i == (n - 1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(spaces);
                }
                
                Console.Write("*");
                Console.Write(pipes);
                Console.WriteLine("*");
            }
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
