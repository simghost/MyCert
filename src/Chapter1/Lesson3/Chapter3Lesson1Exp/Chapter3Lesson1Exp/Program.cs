using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3Lesson1Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new DerivedException();
            }
            catch ( Exception ex)
            {

                Console.WriteLine("{0} : {1}",ex.Source,ex.Message);
            }

            Console.ReadLine();

        }
    }

    class DerivedException : Exception
    {
        public override string Message
        {
            get
            {
                return "An error occured in the application";
            }
        }
    }

    class BigClass : IDisposable
    {

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
