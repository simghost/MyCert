using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1Lesson2Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string verse = "The old brown fox jumps over the lazy dog.";

            string[] stringList = verse.Split(' ');

            Array.Sort(stringList);

            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
