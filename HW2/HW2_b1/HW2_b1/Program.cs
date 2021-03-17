using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_b1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] factors = new int[10000];
            int index = 0;     //数组的索引号
            //先将用户输入数字的所有因子存入factors数组中
            for(int i = 2;i <= num; i++)
            {
                if (num % i == 0)
                {
                    factors[index] = i;
                    index++;                  
                }
                              
            }
            //再判断这些因子是否是质数，是则输出
            for (int i = 0; i < index;i++)
            {
                for (int j = 2; j <= factors[i]; j++)
                {
                    if (factors[i] % j == 0 && j != factors[i])
                    {
                        break;
                    }
                    else if(j == factors[i])
                    {
                        Console.WriteLine("{0}", factors[i]);
                    }                   
                }
            }
            Console.ReadKey();
            
        }
    }
}
