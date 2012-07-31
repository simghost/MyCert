using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chapter2Lesson1Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher fileWatcher = new FileSystemWatcher(@"C:\");

            fileWatcher.IncludeSubdirectories = true;
            fileWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
            fileWatcher.Filter = "*.txt";
            fileWatcher.Changed += new FileSystemEventHandler(fileWatcher_Changed);
            fileWatcher.Renamed += new RenamedEventHandler(fileWatcher_Renamed);
            fileWatcher.Deleted += new FileSystemEventHandler(fileWatcher_Deleted);
            fileWatcher.EnableRaisingEvents = true;

            while (true)
            {
                
            }
	{
	         
	}
        }

        static void fileWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Deleted: {0}",e.Name);
        }

        static void fileWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("{0}:{1}",e.Name,e.OldName);
        }

        static void fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("{0}:{1}",e.ChangeType.ToString(),e.FullPath);
        }
    }
}
