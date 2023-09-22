using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //To create User-defined excep - need to throw keyword.
    //Bussiness requirement for the SW app: When dividing 2 no's, both numerator, denominator should be +ve - Handle using "ApplicationException" which inherits "Exception" class. So it is a pre-defined class.
    //Denominator should be Even no. - Handle by creating a new Exception class.
    //These are the 2 ways to create User-defined Exceptions.
    class ExceptionHandlingDemo2
    {
        static void Main()
        {
            Console.WriteLine("Enter 2 no's: ");
            int c = 0;
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());//If you give a bigger number like 345345345345345:
                                                            //internally it creates "new OverflowException". Means try block creates an instance of the class and throws the instance of that exception to catch block. In catch block we create object and object points to that instance [go through notes in catch{}].
                int b = Convert.ToInt32(Console.ReadLine());
                if (a < 0 || b < 0)
                    throw new ApplicationException("Both numbers should be +ve integers.");//User-defined Exception [manually we need to throw the error]
                //[In general it is not wrong. So, try block don't know to raise exception in this case, this is our own requirement. So manually we need to throw exception here]
                //For pre-defined exceptions, we no need to "throw" manually. try will do that. "try" block throws an instance of the class respective to the error either DivideByZero/ Format/ IndexOutOfRange etc., then it checks any catch block having that instance related class, if so then directly comes to there and executes. If not, base class Exception is going to handle.

                //2nd type of User-def Excep req: Suppose, in the proj there are multiple places we might get this kind of ApplicationException, showing 15 to 20 times same is redundancy and modifications to the message is also cause rework. 
                //Instead of ApplicationException, we can handle by creating a new Exception class. "OddNoException.cs
                if (b % 2 != 0)
                    throw new OddNoException();//It can cach in Exception catch block or separately. 
                //Observe clearly: we are throwing an instance here. In first case "ApplicationException", we are throwing an instance with parameters. In pre-defined Exceptions, try block throws instance automatically.
                c = a / b;//One more thing is if you declare 'c' here, it become as block scope (try block)
            }
            catch (Exception ex)//In catch block it checks any OverflowException is declared. If not it checks base class of that is declared. If so: Exception ex = new OverflowException() [Base class obj = new Dervived class constructor().]
            //This is called Runtime Polymorphism (OR) Late binding. Discuss in Inheritance concept.
            {
                Console.WriteLine(ex.Message);//Here we are calling OverflowException Message propety message.
                //If you go to OverflowException inheriting from > ArithmeticException > SystemException > Exception. Exception class consisting Message property with Write accessor
            }
            //catch (OddNoException) { }//To handle OddNoException separately.
            finally
            {
                Console.WriteLine("Result: " + c);//Printing on console won't cause any issue.
            }
            Console.ReadKey();
        }
    }
}
