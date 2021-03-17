using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_b2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a line of numbers with blank space between numbers");
            string str = Convert.ToString(Console.ReadLine());
            string[] strs = str.Split(' ');
            int[] ints = new int[strs.Length];
            int total = 0;
            for (int i = 0; i < strs.Length; i++)
            {
                ints[i] = Convert.ToInt32(strs[i]);
                total = ints[i] + total;
            }
            Array.Sort(ints);
            Console.WriteLine("The smallest number is {0}, the largest number is {1}, the total of these numbers is {2}," +
                " and the average is {3}", ints[0], ints[strs.Length-1], total, total / strs.Length);
            Console.ReadKey();
        }
    }
}
