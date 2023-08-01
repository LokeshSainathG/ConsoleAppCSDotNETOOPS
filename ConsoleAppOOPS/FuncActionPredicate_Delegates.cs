using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class Utility2 //Framework class (Maintained by Client)
    {
        //public delegate int Transformer(int x);//Delegate
        //public static int Transform(int x, Transformer t)//Generalised method: Passing Delegate (Transformer type) to this method as a parameter.
        public static int Transform(int x, Func<int, int> t)//Instead of using custom delegate, we are using Func delega te. Func here takes integer and returns an int value.
        {
            return x = t(x);//t(x) is invoking the delegate and return Result.
        }//Since Func delegate returning integer, we use Transform method return type also int.

        public static void Transform2(int x, Action<int> t)
        {
            t(x);//t(x) is invoking the delegate and does not return anything.
        }

        public static bool Check(int x, Predicate<int> t)
        {
            return t(x);//t(x) is invoking the delegate and return true or false.
        }
    }

    class FuncActionPredicate_Delegates
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int i = int.Parse(Console.ReadLine());

            int sresult = Utility2.Transform(i, Square);
            Console.WriteLine("Sqaure of given number is " + sresult);

            int cresult = Utility2.Transform(i, Cube);//Plugging Cube functionality.
            Console.WriteLine("Cube of given number is " + cresult);

            //Utility2.Transform2(i, SquareAgain);

            var check = Utility2.Check(i, CheckNumber);
            Console.WriteLine(check);

            if(check.Equals(false))
            {
                Console.WriteLine("Number should be grater than 0");
                return;//If number == 0, SquareAgain() method won't be executed. Since Program is returning here.
            }
            Utility2.Transform2(i, SquareAgain);
        }


        public static int Square(int x)
        {
            return x * x;
        }
        public static int Cube(int x)
        {
            return x * x * x;
        }
        public static void SquareAgain(int x)
        {
            Console.WriteLine("Square again: "+x * x);
        }
        public static bool CheckNumber(int x)
        {
            if(x == 0)
                return false;
            else
                return true;
        }
    }
}
