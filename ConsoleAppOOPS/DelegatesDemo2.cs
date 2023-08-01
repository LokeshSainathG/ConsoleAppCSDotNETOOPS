using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class Utility //Framework class (Maintained by Client)
    {
        //Let's not define the methods in this Framework class.
        public delegate int Transformer(int x);
        public static int Transform(int x, Transformer t)//Generalised method: Passing Delegate (Transformer type) to this method as a parameter.
        {
            return x = t(x);//t(x) is invoking the delegate and return Result.
        }
    }
    class DelegatesDemo2
    {
        
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int i = int.Parse(Console.ReadLine());

            int sresult = Utility.Transform(i, Square);//First parameter is integer, second is Delegate type [Any method that resembles this delegate type. We can pass Square/ Cube/ any method that delegate can point]
            //Instead of calling Square() from class name/ delegate, plugging-in the method at Run-time.
            //We are passing Square method as a parameter to this Transform().
            //We can plug any functionality to the Transform method.
            Console.WriteLine("Sqaure of given number is " + sresult);

            int cresult = Utility.Transform(i, Cube);//Plugging Cube functionality.
            Console.WriteLine("Cube of given number is " + cresult);
        }
        public static int Square(int x)
        {
            return x * x;
        }
        public static int Cube(int x)
        {
            return x * x * x;
        }
        //If you want to pass a method to other method as a parameter you can use Delegates.
        //We no need to change the client class. We can define any no.of functions outside the Framework and plug-in the method to the Client Framework Transform method with the help of Transformer Delegate.
    }

}
