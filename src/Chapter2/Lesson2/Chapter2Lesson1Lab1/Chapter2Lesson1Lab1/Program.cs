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
            string text="";

            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);

            Console.WriteLine("Please enter text. When complete, type 'quit'...");
            while ((text=Console.ReadLine()) != "quit")
            {
                
                sw.WriteLine(text);
            }

            sw.Flush();

            Console.Clear();
            Console.WriteLine("Writin memory stream contents to file...");

            FileStream fs = new FileStream(@"C:\memStreamTest2.txt", FileMode.Create);
            ms.WriteTo(fs);
            fs.Close();
            sw.Close();
            ms.Close();

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("This is the co ntents of the file:..."
                );
            TextReader tr = File.OpenText(@"C:\memStreamTest2.txt");
            Console.WriteLine(tr.ReadToEnd());
            tr.Close();

            Console.ReadLine();

        }
    }
}
