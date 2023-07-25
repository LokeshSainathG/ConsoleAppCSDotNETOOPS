using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class ExceptionHandlingDemo4
    {
        static void Main()
        {
            //We can keep try inside another try block. That seoncd try block can be here or outside.
            try//Outer try
            {
                Console.WriteLine("Enter 2 no's: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                //int c = a * b;
                int c = checked(a * b);
                Console.WriteLine("Result: " + c);
                Div(a, b);
                //If a=58, b=0. Mul=0, Div=Divide by Zero error. But the Div() does not have DivideByZeroException / parent Exception class in the catch blocks. If the inner try is not handling the Exception, it checks outer try catch block.
                //We can have nested try. Outer try should have Exception class catch block.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //In case if you are writting 100 lines of code in finally block. We may need to put in try-catch blocks, bcs it could raise an Exception/ error.
            finally
            {
                try
                {
                    //100 lines
                }
                catch
                {

                }
                //Always make it as a habit that put the code in try-catch blocks.
            }
        }
        static void Div(int a, int b)
        {
            try//Inner try - throwing new DivideByZeroException()
            {
                int c = a / b;
                Console.WriteLine("Deivision Result:" + c);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
