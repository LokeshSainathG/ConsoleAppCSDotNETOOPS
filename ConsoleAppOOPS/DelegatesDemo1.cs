using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class DelegatesDemo1
    {
        public delegate int SquareDelegate(int x);//Delegate signature similar to the Method. It won't have body like a method. Delegate is a Reference type. To acess Reference type, we need to create a Reference.
        public delegate string HelloDelegate(string str);
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Sqaure of given number is " + Square(i));//Calling method directly without delegate. If Square() present in another class, we have to either create object/ inherit the class/ if it is static method, use class name to call the method.
            int result = DelegatesDemo1.Square(i);//Normal approach of callig a static method.
            DelegatesDemo1 obj = new DelegatesDemo1();
            string str = obj.Hello("Lokesh");//Normal approach of calling a non-static method.

            //We can also call these methods using a delegate.
            //To create a Delegate for a method, we need match its signature to the method that it will point.

            SquareDelegate t;//Creating obj of delegate
            t = Square;//instantiating delegate
            Console.WriteLine("Square of given number is " + t(i));//Invoking the delegate
            //Invoking can be re-write as using "Invoke()"
            Console.WriteLine("Square of given number is " + t.Invoke(i));

            //Directly pointing method to the Delegate.
            SquareDelegate t2 = new SquareDelegate(Square);
            //Note: if you are using referencing static method Square() outside the class, you should use class name: <class>.Square()
            SquareDelegate t3 = Square;//Without explicitly calling constructor, we can directly asssign method.
            //Why we used Delegates to invoke the functions?
            //Delegates helps to achieve the flexibility in classes or Decoupling the methods with Classes.  If you are working in Big projects like Banking or insurance, you may use Delegates more in your classes. 

            HelloDelegate s = new HelloDelegate(obj.Hello);//a non-static member of a class can never be accessed from a static block directly.
            //Address of the Hello() method is passed to the delegate as a parameter.
            string wish = s("Lokesh");
            Console.WriteLine(wish);
        }
        
        static int Square(int x)//Static method
        {
            return x * x;
        }
        //Instead of method: we can use LINQ:
        int Square2(int x) => x * x;

        string Hello(string name)//Non-static method
        {
            return "Hello" + name;
        }
    }
}
