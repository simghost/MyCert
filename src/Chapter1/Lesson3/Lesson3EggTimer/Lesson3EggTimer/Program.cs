using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson3EggTimer
{
    class Program
    {
        public static bool completed = false;
        static void Main(string[] args)
        {

            EggTimer eggTimer = new EggTimer();
            //eggTimer.Duration = 3000;
            eggTimer.onAlarm += new EggTimer.EventHandler(eggTimer_onAlarm);

            Console.WriteLine("Press Key to start....");
            Console.ReadLine();
            Console.WriteLine("Started...");
            eggTimer.Start();
            while (!completed)
            {

            }

            Console.WriteLine("Press Key to exit...");
            Console.ReadLine();

        }

        static void eggTimer_onAlarm()
        {
            Console.WriteLine("The timer has expired");
            completed = true;
        }

    }
}
