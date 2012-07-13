using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Lesson3EggTimer
{
    class EggTimer
    {
        Timer timer;
        int Ticks;
        DateTime startTime;

        public double Duration { get; set; }

        public event EventHandler onAlarm;
        public delegate void EventHandler();

        public EggTimer()
        {
            startTime = new DateTime();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            Duration = 10000;
        }

        //Responds to Timer Elapsed event
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Ticks++;
            if (DateTime.Now >= startTime.AddMilliseconds(Duration))
            {
                timer.Enabled = false;
                onAlarm();
            }
            else
                Console.WriteLine(Ticks.ToString());
        }

        
        public void Start()
        {
            Ticks=0;
            timer.Enabled = true;
            startTime = DateTime.Now;
        }
    }
}
