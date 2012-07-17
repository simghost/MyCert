using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chapter2Lesson1Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                Console.WriteLine("{0} : {1}",drive.Name, drive.DriveType);
            }

            Console.ReadLine();
        }
    }
}
