using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class ExceptionHandlingDemo4
    {
        //Nested 'try' blocks:
        //sometimes we need to keep 'try' inside another try block. That second try block can be inside directly OR in a separate method visually outside of the first try (logically inside only).

        static void Div(int a, int b)
        {
            try//Inner try - throwing new DivideByZeroException()
            {
                int c = a / b;
                Console.WriteLine("Division Result:" + c);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //In this method there is no check for DivideByZero exception & no catch having Exception base class. How try will handle this? first it checks this catch blocks, later it checks parent catch blocks.
        }

        static void Main()
        {
            try//Outer try
            {
                Console.WriteLine("Enter 2 no's: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                //int c = a * b;
                int c = checked(a * b);
                Console.WriteLine("Result: " + c);
                Div(a, b);//We are calling Div method, means Div(a,b); is replaced by the actual method definition {try{....} catch(FormatExc) catch(OverflowExc)}. It becomes inner try and and Main() try becomes outer try.
                //If a=58, b=0. Mul=0, Div=Divide by Zero error. But the Div() does not have DivideByZeroException /Exception class in the catch blocks. What's happening is if the inner try is not handling the Exception, it checks with outer try catch block.
                //We can have nested try blocks. Always, outer try block should have Exception class catch block.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Always make it as a habit that put the code in try-catch blocks.
            //In case if you are writting 100 lines of code in finally block. We may need to put in try-catch blocks, bcs it also could raise an Exception/ error.
            finally
            {
                try
                {
                    //100 lines of Bussiness logic.
                }
                catch
                {

                }
            }
        }
    }
}
