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
            Person person1 = new Person("Tony", "DeMarco", 53,Person.Gender.Male);

            Console.WriteLine(person1.ToString());

            Console.ReadLine();
        }
    }

    struct Person
    {
        public enum Gender { Male, Felmale };
        public string _firstName;
        public string _lastName;
        int _age;
        Gender _gender;


        public Person(string firstName, string lastName, int age, Gender gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _gender = gender;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, Age: {2}  Gender: {3}", _firstName, _lastName, _age, _gender);
        }
    }
}
