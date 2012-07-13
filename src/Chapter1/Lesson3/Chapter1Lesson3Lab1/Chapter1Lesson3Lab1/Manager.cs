using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1Lesson3Lab1
{
    class Manager : Person
    {
        string _phoneNumber;
        string _location;

        public Manager(string firstName, string lastName, int ripeOldAge, string phoneNumber, string location) :
            base(firstName, lastName, ripeOldAge)
        {
            _phoneNumber = phoneNumber;
            _location = location;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nPhone: {0}\nLocation : {1}", _phoneNumber, _location);
        }
    }
}
