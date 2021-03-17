using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter an operator(+-*/):");
            string str = Console.ReadLine();
            switch (str)
            {
                case "+":
                    {
                        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                        break;
                    }
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
