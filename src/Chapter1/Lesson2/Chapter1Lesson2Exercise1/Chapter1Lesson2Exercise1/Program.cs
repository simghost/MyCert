using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1Lesson2Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb = 0;
            byte byt = 0;
            Int16 i16 = 0;
            Int32 i32 = 0;
            Int64 i64 = 0;
            string str = "0";
            Exception ex = new Exception();

            object[] o = {sb,byt,i16,i32,i64,str,ex };

            string type;

            foreach (var obj in o)
            {
                if (obj.GetType().IsValueType)
                {
                    type = "Value Type";
                }
                else
                    type = "Reference Type";

                Console.WriteLine("{0} : {1}", obj.GetType(),type);
            }


            Console.ReadLine();
        }
    }
}
