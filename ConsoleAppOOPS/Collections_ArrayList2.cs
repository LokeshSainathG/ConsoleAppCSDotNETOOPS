using System;
using System.Collections;
namespace ConsoleAppOOPS
{
    class Collections_ArrayList2
    {
        static void Main()
        {
            //How much Memory is allocated for ArrayList:
            //Based on the items we are inserting, memory gets dynamically allocated.
            ArrayList al = new ArrayList();
            
            Console.WriteLine(al.Capacity);//0. No memory allocated. When start inserting, memory get.
            al.Add(23444);
            Console.WriteLine(al.Capacity);//4.
            al.Add(78.890990);
            Console.WriteLine(al.Capacity);//4.
            al.Add(4560);
            al.Add("Lokesh Sainath");
            Console.WriteLine(al.Capacity);//4. Till here 4 elements
            
            al.Add("G");
            Console.WriteLine(al.Capacity);//8
            al.Add(6); al.Add(7); al.Add(8);
            Console.WriteLine(al.Capacity);//8

            //Iniitial capacity is 0. When 1 element is added, it is 4. After filling 4 locations, also, it is 4.
            //When 5th element is added, it becomes 8
            al.Add(9); 
            Console.WriteLine(al.Capacity);//16
            al.Add(10); al.Add(11); al.Add(12); al.Add(13); al.Add(14); al.Add(15); al.Add(16);
            Console.WriteLine(al.Capacity);//16
            al.Add(17);
            Console.WriteLine(al.Capacity);//32.

            //ArrayList size is Variable length. 0, 4, 8, 16, 32, .... Based on the elements, capacity will increase.

            //OR
            var arlist = new ArrayList() //Recommended
            {2, "Lokesh", 'G'
            };//Adding elements using Object Inititaliser sytntax.
            var firstEle = arlist[0];
            var secondEle = arlist[1];
            var thirdEle = arlist[2];
            //Other ArrayList functions:
            //CopyTo() 
            //ToArray()
            //IndexOf()
            //GetRange()

            /*Note:
             * It is not recommended to use ArrayList class due to performance issue. Instead, use List<object> to store Hetrogeneous objects. List is more memory-efficient than ArrayList because it doesn't have to store an object reference for every element in the collection.
             * To store data of same type/ Homogeneous, use Generic List<T> OR Array if you know array size.
             */

            //char is 2 bytes, int is 4 bytes, double is 8 bytes
            //Since string, object are reference types they contain address only.
            //object is 4 byte adress bytes.
            //string is 4 byte adress bytes.
            Console.WriteLine("Size of Integer:" + sizeof(int));
            //Console.WriteLine("Size of String:" + sizeof(string));//Error: bcs it is reference type.
        }
    }
}
