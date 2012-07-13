using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1Lesson3Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bob", "Davis", 53);

            Console.WriteLine(person1.ToString());
            Console.ReadLine();

            Manager manager1 = new Manager("Carole", "Davis", 48, "603-320-6257", "Derry");
            Console.WriteLine(manager1.ToString());
            Console.ReadLine();
        }
    }
}
