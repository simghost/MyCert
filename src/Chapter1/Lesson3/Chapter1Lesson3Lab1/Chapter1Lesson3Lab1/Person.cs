using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1Lesson3Lab1
{
    public class Person
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
            return String.Format("{0} {1}, Age: {2}", _fName, _lName, _age);
        }
    }
}
