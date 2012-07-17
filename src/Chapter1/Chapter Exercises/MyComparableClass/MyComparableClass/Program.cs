using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyComparableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bob", "Davis", 53);
            Person person2 = new Person ("Carole","Davis",48);
            Person person3 = new Person ("Anna", "Davis", 9);
            Person person4 = new Person("Carole", "Richardson", 72);
            Person person5 = new Person("Jimtom", "Richardson", 82);
            Person person6 = new Person("Bob", "Davis", 23);

            Person[] pArray = {person1,person2,person3,person4,person5,person6};

            foreach (Person p in pArray)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();

            Console.WriteLine("\nSorting...\n");

            Array.Sort(pArray);

            foreach (Person p in pArray)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }
    }
 


    class Person : IComparable, IDisposable
    {
        string _fName;
        string _lName;
        int _age;

        public Person(string fName, string lName, int age)
        {
            _fName = fName;
            _lName = lName;
            _age = age;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} : Age: {2}", _fName, _lName, _age);
        }



        public int CompareTo(object obj)
        {
            int Result = 0;

            Person p = (Person)obj;

            Result = this._lName.CompareTo(p._lName);

            if (Result == 0)
            {
                Result = this._fName.CompareTo(p._fName);
            }

            return Result;
        }

        public void Dispose()
        {
            
            
        }
    }
}
