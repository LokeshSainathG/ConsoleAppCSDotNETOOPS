using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Handling exceptions (Recovarable errors) for Desktop like windows/ Mobile/ web apps is called Excepion handling.
    class ExceptionHandlingDemo1
    {
        static void Main()
        {
            Recover:
            Console.WriteLine("Enter 2 no's: ");
            int c = 0;
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                c = a / b;//One more thing is if you declare 'c' here, it become as block scope (try block)
            }
            //Exceptions you may guess, put it in multiple catch blocks.
            //Immediately we have to catch/ finally or both blocks.
            //We can't even write a single statement in b/w try-catch/ try-finally except comments :-).
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                //Value was either too large or too small for an Int32. Result: 0
            }
            /*What is this Message? constructor/ method/ property/ indexer?
             * Mesage is Readonly property in Exception class. All children classes like DivideByZero can call the property called Message.
             * We have declared a obj for Exception class called ex.
             */
            catch(DivideByZeroException)//We can give own exception messages. No need 
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Denominator 0 cause infinite value.");
                goto Recover;
            }
            //Sometimes unknown exceptions might occur. After writing all, write one more catch block with Exceptions base class.
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);//Exception is base class for all kind of pre-defined exceptions like Overflow
                                              //DivideByZero
                                              //IndexOutOfRange
                                              //Format etc., it can handle all exceptions. Above 2 catch blocks also we can remove. If user entered 0 as denaminator, the control again sent back to i/ps then we can define individual blocks.
                //Input string was not in a correct format. Result: 0
            }
            //catch { Console.WriteLine("Error occured"); }
            //A catch block can include a parameter of a built-in or custom exception class to get an error detail.
            finally //If exception is there or not, in both cases finally block will execute.
            {
                Console.WriteLine("Result: " + c);//Printing on console won't cause any issue.
                //If exception is there:
                //try - catch - finally
                //If exception is not there:
                //try - finally

            }
            //"Result: " outside finally also executing in both cases. Then what is the use of finally{}. In ADO.NET it is mandatory.


        }
    }
    /*
    * Errors: Categorised into 3 types
    -Compile (or) syntax errors
    -Runtime - caused after executing the program like infinite loops. giving wrong data type values. As a developer we have to handle it properly. User might give character for Account number. Programmer should think like sigma user and handle in code.
    -Logical erros: wrong logic

    Exceptions:
    -Runtime: like Index out of bound, divide by zero,
    -checked
    */

    /*Exception 1: 
    * Enter 2 no's:
    84389473224201
    Unhandled Exception: System.OverflowException: Value was either too large or too small for an Int32.
    at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info
    at System.Convert.ToInt32(String value)
    */

    /*Exception 2: Giving charc for int type
    * Enter 2 no's:
    Lokesh
    Unhandled Exception: System.FormatException: Input string was not in a correct format.
    at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
    at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
    at System.Convert.ToInt32(String value)
    */
    /*Exception 3:
    * Enter 2 no's:
    345
    0
    Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero.
    */

    //All these exceptions should be handled properly in a block/ multiple sub blocks based on your choice.
    //Keywords: try-catch/ try-finally. try block is must.
    //Suspecting code which might throw an exception > keep in try block. try block expects catch/ finally block

    //Exception class contain no.of pre-defined exceptions. In real time we have to write user-defined exceptions based on Domain & project requirements.
}
