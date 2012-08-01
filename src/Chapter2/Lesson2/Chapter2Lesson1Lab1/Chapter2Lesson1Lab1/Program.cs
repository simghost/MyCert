using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chapter2Lesson1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);

            Console.WriteLine("Enter text. Type 'quit' when finished...");

            while ((text=Console.ReadLine()) != "quit")
            {
                sw.WriteLine(text);
            }

            sw.Flush();

            FileStream fs = File.Create(@"C:\memStreamTest.txt");
            ms.WriteTo(fs);

            fs.Close();
            sw.Close();
            ms.Close();

            Console.Clear();
            Console.WriteLine("Entered Text:");
                                   
            StreamReader sr = new StreamReader(@"C:\memStreamTest.txt");
            Console.Write(sr.ReadToEnd());
            sr.Close();
            Console.ReadLine();
        }
    }
}
