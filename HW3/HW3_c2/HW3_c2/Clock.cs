using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_c2
{
    public class Clock
    {
        public AlarmClock clock = new AlarmClock();

        public Clock()
        {
            clock.alarming += Tick;
            clock.alarming += Alarm;
        }


        public static void Tick(object sender,AlarmEventArgs args)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Tick Tock ! ");
        }

        public static void Alarm(object sender, AlarmEventArgs args)
        {
            //在当前时间等于设定的闹钟时间是，输出 time's up!
            if (AlarmEventArgs.Time == DateTime.Now.ToLongTimeString().ToString())
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"Now is the time {AlarmEventArgs.Time}, time's up! ");
            }
        }
    }
}
