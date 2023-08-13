using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    public delegate string GreetingsDelegate(string name);
    class AnonymousMethodsDemo2
    {
        //public static string Greetings(string name)
        //{
        //    return "Hello " + name + " good morning.";
        //}
        static void Main()
        {
            //GreetingsDelegate gd = Greetings;

            //Anonymous method:
            GreetingsDelegate gd = delegate (string name)//Method without a name
            {
                return "Hello " + name + " good morning.";
            };
            string str = gd.Invoke("Lokesh");
            Console.WriteLine(str);
        }
    }
}
