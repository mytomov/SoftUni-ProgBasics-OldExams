using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {

            var volume = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            
            var water = pipe1 * hours + pipe2 * hours;

            if (pipe1 <= 0 || pipe2 <= 0 || volume <= 0)
            {
                var capacity = 0;
                Console.WriteLine("The pool is {0:f0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.", capacity, pipe1, pipe2);
            }

            if (water <= volume && hours > 0)
            {
                                          
                    var volumePercent = Math.Truncate((water * 100) / volume);
                    var pipeOnePercent = Math.Truncate((pipe1 * hours * 100) / water);
                    var pipeTwoPercent = Math.Truncate((pipe2 * hours * 100) / water);

                    Console.WriteLine("The pool is {0:f0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.", volumePercent, pipeOnePercent, pipeTwoPercent);               
            
            }
            if (water > volume)
            {
                var overflow = water - volume;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, overflow);
            }

            if (water < volume && hours <= 0)
            {
                var notFiled = 0;
                var capacity1 = 0;
                var capacity2 = 0;
                Console.WriteLine("The pool is {0:f0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.", notFiled, capacity1, capacity2);
            }


        }
    }
}
