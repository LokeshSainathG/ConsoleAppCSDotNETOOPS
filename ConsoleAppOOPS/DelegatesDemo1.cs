using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class DelegatesDemo1
    {
        public delegate int Transformer(int x);//Delegate signature similar to the Method. It won't have body like a method. Delegate is a Reference type. To acess Reference type, we need to create a Reference.
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Sqaure of given number is " + Square(i));//Calling method directly without delegate. If Square() present in another class, we have to either create object/ inherit the class/ if it is static method, use class name to call the method.

            //To create a Delegate for a method, we need match its signature to the method that it will point.
            
            Transformer t;//Creating obj of delegate
            t = Square;//instantiating delegate
            Console.WriteLine("Square of given number is " + t(i));//Invoking the delegate
            //Invoking can be re-write as using "Invoke()"
            Console.WriteLine("Square of given number is " + t.Invoke(i));

            //Directly pointing method to the Delegate.
            Transformer t2 = new Transformer(Square);
            Transformer t3 = Square;
            //Why we used Delegates to invoke the functions?
            //Delegates helps to achieve the flexibility in classes or Decoupling the methods with Classes.  If you are working in Big projects like Banking or insurance, you may use Delegates more in your classes. 
        }
        
        static int Square(int x)
        {
            return x * x;
        }

        //Instead of method: we can use LINQ:
        int Square2(int x) => x * x;

    }
}
