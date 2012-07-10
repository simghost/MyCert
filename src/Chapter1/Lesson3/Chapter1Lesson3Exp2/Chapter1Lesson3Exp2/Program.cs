using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1Lesson3Exp2
{
    class Program
    {
        static void Main(string[] args)
        {
            obj o = new obj("Hello", "World");

            Console.WriteLine("{0} {1}",(string)o._t,o._u);
            Console.ReadLine();

            Gen<String,String> g = new Gen<String, String>("Hello","World");
            Console.WriteLine("{0} Generic {1}", g._t, g._u);
            Console.ReadLine();

            Gen<double, int> g1 = new Gen<double, int>(22.6, 44);
            Console.WriteLine("{0} Generic {1}", g1._t, g1._u);
            Console.ReadLine();
        }
    }

    class obj
    {
        public object _t;
        public object _u;

        public obj(object t, object u)
        {
            _t = t;
            _u = u;
        }
    }

    class Gen<T, U>
    {
        public T _t;
        public U _u;

        public Gen(T t, U u)
        {
            _t = t;
            _u = u;
        }
    }
}
