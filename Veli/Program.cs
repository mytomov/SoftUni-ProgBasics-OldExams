using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veli
{
    class Program
    {
        static void Main(string[] args)
        {
            var exp = double.Parse(Console.ReadLine());
            var skills = Console.ReadLine();
            var sallary = 0.00;

            var cSharp = 5400 * 12;
            var java = 5700 * 12;
            var gameDesigner = 3600 * 12;
            var ui = 3100 * 12;
            var frontEnd = 4100 * 12;

            if (exp <= 5)
            {
                if (skills == "C# Developer")
                {
                    sallary = cSharp - (cSharp * (65.8 / 100));
                    Console.WriteLine("Total earned money: {0:f2} BGN", sallary);
                }
                else if (skills == "Java Developer")
                {
                    sallary = java - (java * (65.8 / 100));
                    Console.WriteLine("Total earned money: {0:f2} BGN", sallary);
                }
                else if (skills == "UX / UI Designer")
                {
                    sallary = ui - (ui * (65.8 / 100));
                    Console.WriteLine("Total earned money: {0:f2} BGN", sallary);
                }
                else if (skills == "Front-End Web Developer")
                {
                    sallary = frontEnd - (frontEnd * (65.8 / 100));
                    Console.WriteLine("Total earned money: {0:f2} BGN", sallary);
                }
                else if (skills == "Game Designer")
                {
                    sallary = gameDesigner - (gameDesigner * (65.8 / 100));
                    Console.WriteLine("Total earned money: {0:f2} BGN", sallary);
                }
               
            }
            else
            {
                if (skills == "C# Developer")
                {
                    sallary = cSharp;
                    Console.WriteLine("Total earned money: {0:f2} BGN", sallary);
                }
                else if (skills == "Java Developer")
                {
                    sallary = java;
                    Console.WriteLine("Total earned money: {0:f2} BGN", sallary);
                }
                else if (skills == "UX / UI Designer")
                {
                    sallary = ui;
                    Console.WriteLine("Total earned money: {0:f2} BGN", sallary);
                }
                else if (skills == "Front-End Web Developer")
                {
                    sallary = frontEnd;
                    Console.WriteLine("Total earned money: {0:f2} BGN", sallary);
                }
                else if (skills == "Game Designer")
                {
                    sallary = gameDesigner;
                    Console.WriteLine("Total earned money: {0:f2} BGN", sallary);
                }

            }
        }
    }
}
