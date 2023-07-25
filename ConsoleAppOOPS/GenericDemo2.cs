using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class GenericDemo2
    {
        static void Main()
        {
            Testing<int> t = new Testing<int>();//Testing is a Generic class. Befor Object we need to specify what type we are using.
            int[] a = { 23, 45, 67, 89, 12, 34 };
            t.GenCheckAvailable(a, 23);
            t.GenCountAvailable(a, 45);
        }
    }
    class Testing<T> //Generic class: When we specify generic type at class level it is Generic class. It allows the user to define classes and methods with the placeholder
    {
        public void GenCheckAvailable(T[] arr, T no)//Since we specified at class level, no need to specify here.
        {
            if (arr.Contains(no))
                Console.WriteLine(no + " is present in the Array..");
            else
                Console.WriteLine(no + " is not present in the Array..");
        }
        public void GenCountAvailable(T[] arr, T no)
        {
            int count = 0;
            foreach(var item in arr)
                if (no.Equals(item))
                    count++;
            Console.WriteLine(no + " is appeared: " + count);
        }
        //When we are dealing with Design pattern (Repository pattern), Generic Repository pattern is important.
        //To uderstand Generic Collections, Generics is helpful.
        /*Generics idea is similar to using "var". With Generics you avoid doing boxing/unboxing since you are dealing with the parameter type T , which is a natural parameter that the compiler will replace it with the concrete type at compilation time without doing the boxing operation at runtime.
         * This reson Generics are good in performance.
         */
    }
}
