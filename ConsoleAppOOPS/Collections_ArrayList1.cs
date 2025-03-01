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
            //Type of the value it is taking as Object type. So, it can hold any type of data integer, decimal, String, character.
            //To display ArrayList data:
            foreach (object item in al)//Since ArrayList contain Object type of data, we can use var/ object type.
                Console.Write(item+"\t");
            Console.WriteLine();
            //////////////////////Let's test any diff exist b/w 'var', 'object'///////////////////////
            foreach (var item in al)
            {
                Console.Write(item + " Test" + "\t");
            }Console.WriteLine();

            foreach (object item in al)
            {
                Console.Write(item + " Test" + "\t");
            }Console.WriteLine();
            ////////////////////////////////////////////////////////////////////////////////////////
            
            //To insert another collection (multiple elements at a time): 
            ArrayList al1 = new ArrayList();
            al1.Add("Sai"); al1.Add(24.567); al1.Add("Vamsi"); 
            al.AddRange(al1);//AddRange() expects Collection type.
            //It take collection as parameter.
            foreach (var item in al)
                Console.Write(item + "\t");
            Console.WriteLine();

            ///////// To insert an element at middle position: ///////////
            al.Insert(0,"Ram");//2 args: Where, what element
            foreach (var item in al)
                Console.Write(item + "\t");
            Console.WriteLine();

            al.InsertRange(1, al1);//Where, what collection
            foreach (var item in al)
                Console.Write(item + "\t");
            Console.WriteLine();

            /////////// To remove elements: ///////////
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

            /////////// To search an element: Contains(): ///////////
            if (al.Contains(23))
                Console.WriteLine("23 is present in ArrayList");

            al1.Clear();//To remove all elements in al1.

            /* ArrayList Methods:
            al.Add();//obj                  al.AddRange();//collection
            al.Insert();//index, obj        al.InsertRange();//index, collection
            Add() add elements at last index.
            al.Remove();//obj               al.RemoveRange();//index, count         al.RemoveAt()//index
            al.Contains();//obj
            */
            //Add() - Add element(s) at last index
            //Insert() - Inserts at specified Index position. So 'index' argument is must.
            //Remove element                RemoveAt index              RemoveRange from index, no.of elements.

            //Go to Form5.cs, all these methods available in "Items" of CheckedListBox, ListBox, ComboBox controls in Forms also. Bcs Items is collections type property for all the above 3 controls we can use these methods with those.

        }
    }
}