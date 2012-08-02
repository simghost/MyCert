using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.IsolatedStorage;


namespace Chapter2Lesson2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream isoFile = new IsolatedStorageFileStream("output.txt", FileMode.Create, isoStore);
            StreamWriter sw = new StreamWriter(isoFile);


            Console.WriteLine("Please enter text now. Enter 'quit' when finished...");

            
            while ((text=Console.ReadLine()) != "quit")
            {
                sw.WriteLine(text);
            }

            sw.Flush();
            sw.Close();

            isoFile.Close();

            Console.Clear();
            
            Console.WriteLine("Text entered in to isloated storage...");
            isoFile = new IsolatedStorageFileStream("output.txt", FileMode.Open, isoStore);
            StreamReader sr = new StreamReader(isoFile);

            Console.WriteLine(sr.ReadToEnd());
            isoFile.Close();
            sr.Close();

            Console.ReadLine();

           

        }
    }
}
