using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_b3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("2 3 5 7");
            for (int i = 2; i < 101; i++)
            {               
                    if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                    {
                        Console.Write(" ");
                        Console.Write(i);
                    }                                                         
            }
            
            Console.ReadKey();
        }
    }
}
