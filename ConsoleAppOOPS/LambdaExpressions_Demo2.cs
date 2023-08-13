using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //public delegate string GreetingsDelegate(string name);
    //Delegate already defined in AnonymousMethodsDemo.cs
    class LambdaExpressions_Demo2
    {
        public static string Greetings(string name)
        {
            return "Hello " + name + " good morning.";
        }
        static void Main()
        {
            //GreetingsDelegate gd = new GreetingsDelegate(Greetings);string str = gd.Invoke("Lokesh"); Console.WriteLine(str);
            //In Anonymous method we simplified process of creating a separate method and binding to the delegate instance. We only need to pass the parameters in Anonymous method. Return type also specified in the delegate definition.


            GreetingsDelegate gd = delegate (string name)//Anonymous method (method without a name)
            {
                return "Hello " + name + " good morning.";
            };
            string str = gd.Invoke("Lokesh");
            Console.WriteLine(str);

            //Lambda Expressions:
            GreetingsDelegate gd2 = (name)=>
            {
                return "Hello " + name + " good morning.";
            };
            //no need to specify type of 'name' or you can do so.
            //Since the delegate already knows the parameter what it is going to take.
            string str2 = gd2.Invoke("Lokesh");
            Console.WriteLine(str2);
        }
    }
}