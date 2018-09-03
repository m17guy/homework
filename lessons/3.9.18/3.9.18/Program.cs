using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9._18
{
    class Program
    {
        static int x;
        static void Main(string[] args)
        {
            //catchin exception
            try
            {
                Console.WriteLine(10 / x); //DivideByZeroException
                ;
            }
            catch (Exception e) //handling
            {
                Console.WriteLine(e);
            }

            //throw exception manualy
            
            try
            {
                if (x == 0) throw new Exception("zero is very bad");
            }
            catch(Exception e)
            {
                x = 1;
                Console.WriteLine(e);
            }


            try
            {
                throw new NullReferenceException();
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("null bebe");
                
            }

            //try -finally
            try
            {
                Console.WriteLine("before ex");
                x = 0;
                //int y = 4 / x;
                Console.WriteLine("after ex");
            }
            finally //critical cleanups - always executed
            {
                Console.WriteLine("in the end");
            }

            //try - catch- finally
            try
            {
                throw new Exception();
            }
            catch
            {
                Console.WriteLine("some exception caught");
            }
            finally
            {
                Console.WriteLine("always executed");
            }



            Console.ReadKey();
        }
    }
}
