using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_c2
{
    class Program
    {
        static void Main(string[] args)
        {
            //设置闹钟时间
            string time = "16:55:00";  //可改为离当前时间较近的时间
            Clock c = new Clock();
            c.clock.OnAlarm(time);     //将设置的闹钟时间传入时钟当中，时钟开始一直Tick Tock，到设定的时候后输出
            Console.ReadKey();
        }

    }
}
