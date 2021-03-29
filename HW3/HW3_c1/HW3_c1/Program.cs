using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_c1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> nodes = new GenericList<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                nodes.Add(random.Next(0, 100));
            }
            int total = 0, min = 100, max = -1;
            Console.Write("The elements in the list are: ");
            GenericList<int>.LikeFoeEach(nodes, e => Console.Write(e+" "));
            Console.WriteLine();
            Console.WriteLine();
            GenericList<int>.LikeFoeEach(nodes, e => total += e);
            Console.WriteLine($"The total of these elements is: { total }");
            Console.WriteLine();
            GenericList<int>.LikeFoeEach(nodes, e => max = Math.Max(max, e));
            Console.WriteLine($"The biggest element is {max}");
            Console.WriteLine();
            GenericList<int>.LikeFoeEach(nodes, e => min = Math.Min(min, e));
            Console.WriteLine($"The smallest element is {min}");
            Console.ReadKey();
        }
    }
}
