using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washMachinePrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());
            var savedMoney = 0.0;
            var toys = 0;
            var receivedMoney = 10;
            for (int year = 1; year <= age; year++)
            {
                
                if (year % 2 == 0)
                {
                    savedMoney += (receivedMoney - 1);
                    receivedMoney += 10;
                }
                else
                {
                    toys++;
                }
            }
            savedMoney += toys * toyPrice;

            Console.WriteLine(savedMoney >= washMachinePrice ? $"Yes!{(savedMoney - washMachinePrice): 0.00}" :
                $"No!{(washMachinePrice - savedMoney): 0.00}");
        }
    }
}
