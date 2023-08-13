using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class FuncActionPredicate_Delegates2
    {
        public static double AddNums1(int x, float y, double z)//Value returning method
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)//non-value returning method
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLentgh(string str)//bool returning method
        {
            if (str.Length > 5)
                return true;
            return false;
            //OR We can replace if-else with Ternary operator.
            //return (str.Length > 5) ? true : false;
        }
        //We can call these 3 using 3 different delegates as signature is different. Now, let's call these 3 methods using pre-defined delegates:
        static void Main()
        {
            //Instead of instantiating the custom delegate, we just used pre-defined delegate.
            Func<int, float, double, double> obj1 = AddNums1;
            //4th overload is req now, since it takes 3 i/p's. We need to specify the type of Generic type 'T'.
            double res = obj1.Invoke(12, 34.4f, 45.678d);
            Console.WriteLine(res);

            Action<int, float, double> obj2 = AddNums2;
            obj2.Invoke(12, 13, 14);

            Predicate<string> obj3 = CheckLentgh;
            bool s = obj3.Invoke("Lokesh");
            Console.WriteLine("Status: " + s);

            //We can simplify the code, by using Anonymous methods or Lambda Expressions. Instead of writing method separately and binding it to delegate, directly we can write the Anonymous method or Lambda expression.
            //Lambda Expression:
            Func<int, float, double, double> f = (x, y, z) =>
            {
                return x + y + z;
            };
            double result = f.Invoke(12, 34.4f, 45.678d);
            Console.WriteLine(result);
            //OR
            Func<int, float, double, double> f2 = (x, y, z) => x + y + z;
            //Since Func<> already specified the return type as double, no need to use the "return" statement.
            //Note: When to use "return" keyword in Lambda expression. 
            //If the body of the Lambda expression is a single statement, no need to use "return" keyword. It does the execution and return result.
            //If the body has more than one statement (or) you are using {}. Then you need to specify the "return" keyword.
            Action<int, float, double> a = (x, y, z) => Console.WriteLine(x + y + z);
            a.Invoke(12, 13, 14);

            Predicate<string> p = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool s2 = p.Invoke("Lokesh");
            Console.WriteLine("Status: " + s2);
            //Or
            //Predicate<string> p2 = (str) => (str.Length > 5) ? true : false;
            //Or Much Simple:
            Predicate<string> p2 = (str) => str.Length > 5;
            bool s3 = p2.Invoke("Lok");
            Console.WriteLine("Status: " + s3);
        }
    }
}
