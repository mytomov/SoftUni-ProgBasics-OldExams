using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veli2
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            var age = double.Parse(Console.ReadLine());
            var sport = Console.ReadLine();
            
            var price = 0.00;

            if (age <= 19)
            {
                if (gender == "m")
                {
                    if (sport == "Gym")
                    {
                        price = 42 * 0.80;
                    }
                    else if (sport == "Boxing")
                    {
                        price = 41 * 0.80;
                    }
                    else if (sport == "Yoga")
                    {
                        price = 45 * 0.80;
                    }
                    else if (sport == "Zumba")
                    {
                        price = 34 * 0.80;
                    }
                    else if (sport == "Dances")
                    {
                        price = 51 * 0.80;
                    }
                    else if (sport == "Pilates")
                    {
                        price = 39 * 0.80;
                    }
                }
                else if (gender == "f")
                {
                    if (sport == "Gym")
                    {
                        price = 35 * 0.80;
                    }
                    else if (sport == "Boxing")
                    {
                        price = 37 * 0.80;
                    }
                    else if (sport == "Yoga")
                    {
                        price = 42 * 0.80;
                    }
                    else if (sport == "Zumba")
                    {
                        price = 31 * 0.80;
                    }
                    else if (sport == "Dances")
                    {
                        price = 53 * 0.80;
                    }
                    else if (sport == "Pilates")
                    {
                        price = 37 * 0.80;
                    }
                }
                else
                {
                    if (gender == "m")
                    {
                        if (sport == "Gym")
                        {
                            price = 42;
                        }
                        else if (sport == "Boxing")
                        {
                            price = 41;
                        }
                        else if (sport == "Yoga")
                        {
                            price = 45;
                        }
                        else if (sport == "Zumba")
                        {
                            price = 34;
                        }
                        else if (sport == "Dances")
                        {
                            price = 51;
                        }
                        else if (sport == "Pilates")
                        {
                            price = 39;
                        }
                    }
                    else if (gender == "f")
                    {
                        if (sport == "Gym")
                        {
                            price = 35;
                        }
                        else if (sport == "Boxing")
                        {
                            price = 37;
                        }
                        else if (sport == "Yoga")
                        {
                            price = 42;
                        }
                        else if (sport == "Zumba")
                        {
                            price = 31;
                        }
                        else if (sport == "Dances")
                        {
                            price = 53;
                        }
                        else if (sport == "Pilates")
                        {
                            price = 37;
                        }
                    }
                }
            }
            if (money >= price)
            {
                Console.WriteLine("You purchased a 1 month pass for {0}.", sport);
            }
            else
            {
                var total = price - money;
                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", total);
            }
        }
    }
}
