using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_b4
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] shapes = { "square", "rectangle", "triangle" };
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                total = GetArea(shapes) + total;
            }
            Console.WriteLine("The total area of these polygon are {0}", total);
            Console.ReadKey();
        }

        static double GetArea(String[] shapes)
        {
            int random = new Random(BitConverter.ToInt32(new Guid().ToByteArray(), 0)).Next(0, 3);
            IShape shape = new Factory().GetShape(shapes[random]);
            double random_area = shape.getArea();
            if (shape.isLegal())
            {
                Console.WriteLine("It has produced a {0} and its area is {1}.", shapes[random], random_area);
                return random_area;
            }
            else
                Console.WriteLine("Fail to produce...");
            return 0;

        }

    }
}
