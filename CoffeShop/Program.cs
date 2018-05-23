using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingHour = int.Parse(Console.ReadLine());
            var startingMinutes = int.Parse(Console.ReadLine());
            var hourOfArrival = int.Parse(Console.ReadLine());
            var minutesOfArrival = int.Parse(Console.ReadLine());

            string late = "Late";
            string onTime = "On Time";
            string early = "Early";

            var examTime = (startingHour * 60) + startingMinutes;
            var arrivalTime = (hourOfArrival * 60) + minutesOfArrival;

            var totalTime = arrivalTime - examTime;

            
             if (totalTime < -30)
            {
               var studentArrival = early;
                Console.WriteLine(studentArrival);
            }         

            else if (totalTime <= 0)
            {
               var studentArrival = onTime;
                Console.WriteLine(studentArrival);
            }
            else
            {
                var studentArrival = late;
                Console.WriteLine(studentArrival);
            }
                   
            string result = string.Empty;
            if (totalTime != 0)
            {
                var hoursDiff = Math.Abs(totalTime / 60);
                var minutesDiff = Math.Abs(totalTime % 60);

                if (hoursDiff > 0)
                {
                    result = string.Format("{0}:{1:00} hours", hoursDiff, minutesDiff);
                }
                else
                {
                    result = minutesDiff + " minutes";
                }
                if (minutesDiff < 0)
                {
                    result += " before the start";
                }
                else
                {
                    result += " after the start";
                }
            }
            
            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
