using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class ExceptionHandlingDemo3
    {
        //checked{} block OR cheked()
        static void Main()
        {
            try
            {
            Console.WriteLine("Enter 2 no's: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //int c = a * b;
            int c = checked(a * b);//Arithmetic operation resulted in an overflow.
            Console.WriteLine("Result: " + c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*Enter 2 no's:
            6787890
            56789809
            Result: 1071862418
            //Result is not correct though it is not throwing Overflow exception for 'c'. Exception class also not handling
            */
            //These kind of errors (Result of a formula is overflow) are called as "ArithmeticOverflow Exceptions" and Exception class can't handle automatically, the best approach to handle is "checked block".
            /*checked
            {
                int c = a * b;
                Console.WriteLine("Result: " + c);
            }*/
            //OR
            //int c = checked(a * b);
            //When writing formulas and all always put inside a checked block. So that it can catch ArithmeticOverflowExceptions and caught by Exception class.
            //One more issue we have is ""
            //One more issue we have is "ExceptionHandlingDemo4.cs"
        }
    }
}
