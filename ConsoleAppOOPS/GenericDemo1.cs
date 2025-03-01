using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppOOPS
{
    class GenericDemo1
    {
        static void CheckAvailable(int[] arr, int no)
        {
            if (arr.Contains(no))//Contains() present Linq namespace.
                Console.WriteLine(no + " is present in the Array..");
            else
                Console.WriteLine(no + " is not present in the Array..");
        }
        static void Main()
        {
            int[] a = {23,45,67,89,12,34};
            CheckAvailable(a, 78);//Int array & one int number. It can't take string array, string. It only work for int type.
            //How CheckAvailable() ready to handle string/ float/ char/ double?
            //Generics are gong to useful. Functionality is applicable for any type.
            //Generics allows for the creation of reusable code by creating parameterized types. it enables us to create classes, interfaces, and methods that work with different data types without having to define the data type explicitly.
            //If you are doing a mini project where you are storing Data into DB. If you wrote the method in Generic way, advantage is: For every table we can use that functionality in a Generic way.
            string[] s = { "Lokesh", "Vamsi", "Praveen", "Bhanu" };
            GenCheckAvailable<string>(s, "Lokesh");//When calling Generic function: you can specifu the type. Even if you didn't specify also, it won't through any error.
            GenCheckAvailable<int>(a, 78);
        }

        //Let's implement same CheckAvailability() method in a Generic way:
        static void GenCheckAvailable<T>(T[] arr, T no)//Generic Method: We have to give "T" and specify <T> in Func def. That T type we have to pass in func calling.
        {
            Console.WriteLine(arr.GetType()+" - " +no.GetType());
            if (arr.Contains(no))//Contains() present Linq namespace.
                Console.WriteLine(no + " is present in the Array..");
            else
                Console.WriteLine(no + " is not present in the Array..");
        }
        //Generic Method is a mechanism which is used to implement the method in a Generic way. Any type of data you can pass to that Method. In the same way, whole class/ Interface we can make Generic. GenericDemo2.cs
        //Performance:
        //Generics are faster. Generic implementations are somewhat faster than the non generic counterparts with reference types due to a change in the underlying implementation.
    }
}
