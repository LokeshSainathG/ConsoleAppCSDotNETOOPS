using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class MulticastDelegatesDemo
    {
        delegate int Transformer(int x);
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int i = int.Parse(Console.ReadLine());
            Transformer t = Square;
                        t += Cube;//OR [t = t + Cube;] Delegate instance is pointing to both Functions.
            //The - and -= operators remove the right delegate operand from the left delegate operand:
            int result = t.Invoke(i);
            Console.WriteLine("Result: " + result);//Ip: 2, Op: 8
            //why only getting Cube of no, because, Square() method added first to Delegate instance. Then added Cube(). Square returns a value& Cube returns a value and Square method value is discareded. last added method to multicast delegate instance that's value will be accepted other are overridden.
            //We can print the Result of Square and then assign Cube() to the delegate instance.
            //Solution of problem of discarding values: When you are using Multicast Delegates, the Delegate return type, method return type should be void. Since previous values will be discarded by next invoking function.

        }
        public static int Square(int x)
        {
            return x * x;
        }
        public static int Cube(int x)
        {
            return x * x * x;
        }
    }
}
