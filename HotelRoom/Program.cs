using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main()
        {
            var month = Console.ReadLine().ToLower();
            var daysInHotel = decimal.Parse(Console.ReadLine());         

            if (month == "may" || month == "october")
            {
                if (daysInHotel > 7 && daysInHotel < 15)
                {
                    var priceForStudio = Math.Abs(((50.00m * 0.05m) - 50.00m) * daysInHotel);
                    var priceForAppart = 65.00m * daysInHotel;
                    Console.WriteLine("Apartment: {0:f2} lv.", decimal.Round(priceForAppart, 2));
                    Console.WriteLine("Studio: {0:f2} lv.", decimal.Round(priceForStudio, 2));

                }
                else if (daysInHotel > 14)
                {
                    var priceForStudio = Math.Abs(((50.00m * 0.30m) - 50.00m) * daysInHotel);
                    var priceForAppart = Math.Abs(((65.00m * 0.10m) - 65.00m) * daysInHotel);
                    Console.WriteLine("Apartment: {0:f2} lv.", decimal.Round(priceForAppart, 2));
                    Console.WriteLine("Studio: {0:f2} lv.", decimal.Round(priceForStudio, 2));
                }
                else if (daysInHotel <= 7)
                {
                    var priceForStudio = 50.00m * daysInHotel;
                    var priceForAppart = 65.00m * daysInHotel;
                    Console.WriteLine("Apartment: {0:f2} lv.", decimal.Round(priceForAppart, 2));
                    Console.WriteLine("Studio: {0:f2} lv.", decimal.Round(priceForStudio, 2));
                }
            }
            if (month == "june" || month == "september")
            {
                if (daysInHotel >= 0 && daysInHotel < 15)
                {
                    var priceForStudio = 75.20m * daysInHotel;
                    var priceForAppart = 68.70m * daysInHotel;
                    Console.WriteLine("Apartment: {0:f2} lv.", decimal.Round(priceForAppart, 2));
                    Console.WriteLine("Studio: {0:f2} lv.", decimal.Round(priceForStudio, 2));

                }
                else if (daysInHotel > 14)
                {
                    var priceForStudio = Math.Abs(((75.20m * 0.20m) - 75.20m) * daysInHotel);
                    var priceForAppart = Math.Abs(((68.70m * 0.10m) - 68.70m) * daysInHotel);
                    Console.WriteLine("Apartment: {0:f2} lv.", decimal.Round(priceForAppart, 2));
                    Console.WriteLine("Studio: {0:f2} lv.", decimal.Round(priceForStudio, 2));
                }
            }
            if (month == "july" || month == "august")
            {
                if (daysInHotel >= 0 && daysInHotel < 15)
                {
                    var priceForStudio = 76.00m * daysInHotel;
                    var priceForAppart = 77.00m * daysInHotel;
                    Console.WriteLine("Apartment: {0:f2} lv.", decimal.Round(priceForAppart, 2));
                    Console.WriteLine("Studio: {0:f2} lv.", decimal.Round(priceForStudio, 2));

                }
                else if (daysInHotel > 14)
                {
                    var priceForStudio = 76.00m * daysInHotel;
                    var priceForAppart = Math.Abs(((77.00m * 0.10m) - 77.00m) * daysInHotel);
                    Console.WriteLine("Apartment: {0:f2} lv.", decimal.Round(priceForAppart,2));
                    Console.WriteLine("Studio: {0:f2} lv.", decimal.Round(priceForStudio,2));
                }
            }
        }
    }
}
