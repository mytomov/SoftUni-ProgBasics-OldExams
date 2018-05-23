using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var op = Console.ReadLine();

            if (op == "+")
            {
                var sum = num1 + num2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", num1, op, num2, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", num1, op, num2, sum);
                }
            }
            else if (op == "-")
            {
                var sum = num1 - num2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", num1, op, num2, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", num1, op, num2, sum);
                }
            }
            else if (op == "*")
            {
                var sum = num1 * num2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", num1, op, num2, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", num1, op, num2, sum);
                }
            }
            else if (op == "/")
            {
                if (num1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num2);
                }
                else if (num2 == 0 )
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    var sum = num1 / num2;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", num1, op, num2, sum);
                }
            }
            else if (op == "%")
            {
                if (num1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num2);
                }
                else if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    var sum = num1 % num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, sum);
                }
            }
        }
    }
}
