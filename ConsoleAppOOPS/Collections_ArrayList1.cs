using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace ConsoleAppOOPS
{
    class Collections_ArrayList1
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add(23); al.Add(34.456); al.Add("Lokesh"); al.Add('G');
            //Type of the value it is taking as Object type. So, it can hold any type of data.
            //To display ArrayList:
            foreach (var item in al)
                Console.Write(item+"\t");
            Console.WriteLine();

            //To insert another collection (multiple elements at a time): 
            ArrayList al1 = new ArrayList();
            al1.Add("Sai"); al1.Add(24.567); al1.Add("Vamsi"); 
            al.AddRange(al1);
            //It take collection as parameter.
            foreach (var item in al)
                Console.Write(item + "\t");
            Console.WriteLine();

            //To insert an element at middle position:
            al.Insert(0,"Ram");
            foreach (var item in al)
                Console.Write(item + "\t");
            Console.WriteLine();

            al.InsertRange(1, al1);
            foreach (var item in al)
                Console.Write(item + "\t");
            Console.WriteLine();

            //To remove elements:
            al.Remove("Vamsi");//Only first occurance removed.
            foreach (var item in al)
                Console.Write(item + "\t");
            Console.WriteLine();

            al.RemoveAt(1);//Remove element with index.
            foreach (var item in al)
                Console.Write(item + "\t");
            Console.WriteLine();

            al.RemoveRange(0, 2);//2 elements from index 0.
            foreach (var item in al)
                Console.Write(item + "\t");
            Console.WriteLine();
            //If you observe, in Forms, we used Add(), Remove(), Clear() functions & Count property we used in "Form5.cs". Because "Items" is a collection type.

            //To search an element: Contains():
            if (al.Contains(23))
                Console.WriteLine("23 is present in ArrayList");

            al1.Clear();//To remove all elements in al1.

            /*
            al.Add();//obj                  al.AddRange();//collection
            al.Insert();//index, obj        al.InsertRange();//index, collection
            Add() add elements at last index.
            al.Remove();//obj               al.RemoveRange();//index, count         al.RemoveAt()//index
            al.Contains();//obj
            */
        }
    }
}
