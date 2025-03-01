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
            Testing<int> t = new Testing<int>();//Testing is a Generic class. Before Object we need to specify what type we are using.
            int[] a = { 23, 45, 67, 89, 12, 34 };
            t.GenCheckAvailable(a, 23);//Instance method

            Testing<int>.GenCountAvailable(a, 45);//static method, for static method like this we can specify actual type for the Generic.
        }
    }
    class Testing<T> //Generic class: When we specify generic type at class level it is Generic class. It allows the user to define classes and methods with the placeholder
    {
        public void GenCheckAvailable(T[] arr, T no)//Since we specified at class level, no need to specify in func def.
        {
            if (arr.Contains(no))
                Console.WriteLine(no + " is present in the Array..");
            else
                Console.WriteLine(no + " is not present in the Array..");
        }
        public static void GenCountAvailable(T[] arr, T no)
        {
            int count = 0;
            foreach(var item in arr)
                if (no.Equals(item))//if(item == no) //Error.
                    count++;
            Console.WriteLine(no + " is appeared: " + count);
        }
        //When we are dealing with Design pattern (Repository pattern), Generic Repository pattern is important.
        //To understand Generic Collections, Generics concept is helpful. In Calculator example only, with Generic method, you can apply for int, float numbers. No need to write separate methods. 
        /*Generics idea is similar to using "var". With Generics you can avoid doing boxing/unboxing since you are dealing with the parameter type T , which is a natural parameter that the compiler will replace it with the concrete type at compilation time without doing the boxing operation at runtime.
         * This reson Generics are good in performance.
         */
    }
}
