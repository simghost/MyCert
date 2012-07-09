using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chapter1Lesson2Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 2, 8, 6, 4, 9, };

            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\n");

            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
            Console.Clear();

            StreamWriter sw = new StreamWriter("C:\\text.txt");
            sw.WriteLine("This is a string that chose to write to this file.");
            sw.WriteLine("It is two lines long.");
            sw.Close();

            StreamReader sr = new StreamReader("C:\\text.txt");
            string readString = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(readString);

            Console.ReadLine();

            Console.Clear();

            try
            {
                sr = new StreamReader(@"C:\boot.in");
                readString = sr.ReadToEnd();
                Console.WriteLine(readString);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            sr.Close();
        }
    }
}
