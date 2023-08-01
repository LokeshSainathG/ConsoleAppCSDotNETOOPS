using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class MulticastDelegatesDemo2
    {
        delegate void Transformer(int x);
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int i = int.Parse(Console.ReadLine());
            Transformer t = Square;
                        t += Cube;//OR [t = t + Cube;] Delegate instance is pointing to both Functions.
            //The - and -= operators remove the right delegate operand from the left delegate operand:
            //t -= Cube;
            t.Invoke(i);

        }
        public static void Square(int x)
        {
            Console.WriteLine( x * x);
        }
        public static void Cube(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
}
