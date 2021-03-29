using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_c2
{
    public class AlarmEventArgs : EventArgs
    {
        public static string Time
        {
            get;
            set;
        }
        
    }
    public delegate void AlarmEventHandler(object sender, AlarmEventArgs args);

    public class AlarmClock
    {
        public event AlarmEventHandler alarming;
        public void OnAlarm(string time)
        {
            AlarmEventArgs alarm = new AlarmEventArgs();
            AlarmEventArgs.Time = time;
            //时钟会一直Tick Tock
            while (true)
            {
                alarming(this, alarm);
            }
        }
    }
}
