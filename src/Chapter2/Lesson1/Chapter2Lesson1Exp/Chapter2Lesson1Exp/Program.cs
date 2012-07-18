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
            Console.WriteLine("reading drives\n");
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                Console.WriteLine("{0} : {1}",drive.Name, drive.DriveType);
            }

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("reading directories\n");

            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");
            foreach (DirectoryInfo item in dirInfo.GetDirectories())
            {
                Console.WriteLine(item.FullName);
            }
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("read files");
            foreach (FileInfo item in dirInfo.GetFiles())
            {
                Console.WriteLine(item.FullName);
            }

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Create directory");
            DirectoryInfo newDir = new DirectoryInfo(@"C:\DeleteMe");
            if (!newDir.Exists)
            {
                newDir.Create();
                Console.WriteLine("Folder created");
            }
            else
                Console.WriteLine("Directory already exists.");

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("creating file");
            FileInfo fInfo = new FileInfo(@"C:\deleteme\mynewfile.txt");
            fInfo.CreateText();

            Console.WriteLine("copy file");
            fInfo.CopyTo(@"c:\deleteme\Mycopiedfile.txt");

            Console.WriteLine("move file");
            FileInfo fInfo2 = new FileInfo(@"C:\deleteme\MycopiedFile.txt");
            fInfo2.MoveTo(@"c:\deleteme\mythirdfile.txt");

    

            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}
