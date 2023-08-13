using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    public delegate void Callback(string message);
    class CallbackMethod_DelegatesDemo
    {
        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        public static void MethodWithCallback(int param1, int param2, Callback callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
        static void Main()
        {
            // Instantiate the delegate.
            Callback handler = DelegateMethod;
            // Call the delegate.
            handler("Hello World");
            MethodWithCallback(1, 2, handler);
        //Passing function as a parameter to another function using Delegates.
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates
        }
    }
}
