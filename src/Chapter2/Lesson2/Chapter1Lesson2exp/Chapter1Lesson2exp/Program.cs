using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chapter1Lesson2exp
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader tr = File.OpenText(@"C:\windows\win.ini");
            Console.WriteLine(tr.ReadToEnd());
            tr.Close();

            Console.ReadLine();

            StreamReader sr = new StreamReader(@"C:\windows\win.ini");
            string line;

            while ((line=sr.ReadLine()) != null)
            {
                Console.WriteLine(line);

            }

            Console.ReadLine();

            TextWriter tw = File.CreateText(@"C:\testtext.txt");
            tw.WriteLine("This is a test line to see if this file was created properly.");
            tw.WriteLine("This is a second line just for the heck of it.");
            tw.Close();

            FileStream fs = new FileStream(@"C:\bintest.bin",FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < 11; i++)
            {
                bw.Write(i);
            }
            bw.Close();
            fs.Close();

            fs = new FileStream(@"C:\bintest.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(br.ReadInt32().ToString());
            }
            br.Close();
            fs.Close();
            Console.ReadLine();

           

        }
    }
}
