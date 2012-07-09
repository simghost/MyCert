using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1Lesson1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Tony", "DeMarco", 53);

            Console.WriteLine(person1.ToString());

            Console.ReadLine();
        }
    }

    struct Person
    {
        public string _firstName;
        public string _lastName;
        int _age;


        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, Age: {2}", _firstName, _lastName, _age);
        }
    }
}
