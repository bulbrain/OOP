using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _2.AsynchronousTimer
{
    class AsyncTimer
    {
        private static Timer aTimer;
        public Action Action { get; set; }
        public int Ticks { get; set; }
        public int T { get; set; }


        public static void Main()
        {
            double interval = 1500.0;
            aTimer = new System.Timers.Timer(interval);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.AutoReset = false;
            aTimer.Enabled = true;
            System.Threading.Thread.Sleep((int)interval * 2);
            Console.ReadLine();
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
