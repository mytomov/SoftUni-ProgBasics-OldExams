using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var seats = Console.ReadLine().ToLower();
            var numberOfFans = int.Parse(Console.ReadLine());
            var price = 0.00;

            if (numberOfFans <= 4)
            {
               var moneyForTransport = money * 0.75;
               var totalMoney = money - moneyForTransport;

                if (seats == "vip")
                {
                    price = 499.99 * numberOfFans;
                    if (price > totalMoney)
                    {
                        var left = Math.Abs(price - totalMoney);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", left);
                    }
                    else
                    {
                            var left = totalMoney - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                       
                    }            
                }
                else if (seats == "normal")
                {
                    price = 249.99 * numberOfFans;
                    if (price <= totalMoney)
                    {
                        var left = totalMoney - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        var left = Math.Abs(price - totalMoney);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", left);
                    }
                }
            }

            if (numberOfFans > 4 && numberOfFans < 10)
            {
                var moneyForTransport = money * 0.60;
                var totalMoney = money - moneyForTransport;

                if (seats == "vip")
                {
                    price = 499.99 * numberOfFans;
                    if (price > totalMoney)
                    {
                        var left = Math.Abs(price - totalMoney);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", left);
                    }
                    else
                    {
                        var left = totalMoney - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);

                    }
                }
                else if (seats == "normal")
                {
                    price = 249.99 * numberOfFans;
                    if (price > totalMoney)
                    {
                        var left = Math.Abs(price - totalMoney);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", left);
                    }
                    else
                    {
                        var left = totalMoney - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);

                    }
                }
            }
            if (numberOfFans > 9 && numberOfFans < 25)
            {
                var moneyForTransport = money * 0.50;
                var totalMoney = money - moneyForTransport;

                if (seats == "vip")
                {
                    price = 499.99 * numberOfFans;
                    if (price > totalMoney)
                    {
                        var left = Math.Abs(price - totalMoney);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", left);
                    }
                    else
                    {
                        var left = totalMoney - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);

                    }
                }
                else if (seats == "normal")
                {
                    price = 249.99 * numberOfFans;
                    if (price > totalMoney)
                    {
                        var left = Math.Abs(price - totalMoney);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", left);
                    }
                    else
                    {
                        var left = totalMoney - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);

                    }
                }
            }

            if (numberOfFans > 24 && numberOfFans < 50)
            {
                var moneyForTransport = money * 0.40;
                var totalMoney = money - moneyForTransport;

                if (seats == "vip")
                {
                    price = 499.99 * numberOfFans;
                    if (price > totalMoney)
                    {
                        var left = Math.Abs(price - totalMoney);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", left);
                    }
                    else
                    {
                        var left = totalMoney - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);

                    }
                }
                else if (seats == "normal")
                {
                    price = 249.99 * numberOfFans;
                    if (price > totalMoney)
                    {
                        var left = Math.Abs(price - totalMoney);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", left);
                    }
                    else
                    {
                        var left = totalMoney - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);

                    }
                }
            }

            if (numberOfFans > 49)
            {
                var moneyForTransport = money * 0.25;
                var totalMoney = money - moneyForTransport;

                if (seats == "vip")
                {
                    price = 499.99 * numberOfFans;
                    if (price > totalMoney)
                    {
                        var left = Math.Abs(price - totalMoney);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", left);
                    }
                    else
                    {
                        var left = totalMoney - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);

                    }
                }
                else if (seats == "normal")
                {
                    price = 249.99 * numberOfFans;
                    if (price > totalMoney)
                    {
                        var left = Math.Abs(price - totalMoney);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", left);
                    }
                    else
                    {
                        var left = totalMoney - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);

                    }
                }
            }
        }
    }
}
