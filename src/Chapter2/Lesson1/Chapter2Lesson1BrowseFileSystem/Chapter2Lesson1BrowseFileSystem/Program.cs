using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chapter2Lesson1BrowseFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Drives:");
            foreach (DriveInfo item in DriveInfo.GetDrives())
            {
                Console.WriteLine("{0},{1}",item.Name,item.DriveType);
            }

            Console.WriteLine("\nPress a letter to view files and folders");
            ConsoleKeyInfo key =  Console.ReadKey();

            foreach (var item in Directory.GetDirectories(key.KeyChar+":\\"))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Files:");

            foreach (var item in Directory.GetFiles(key.KeyChar+":\\"))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
