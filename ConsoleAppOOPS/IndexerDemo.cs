using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //In real time projects we very rarley use Indexers. But it is important to learns bcs, in C#, there are many Indexers in pre-defined classes. To access the private data which is inside the class at outside, indexers are going to use.
    //Diff b/w Indices & properties is: for each var, we create separate property. For all var's we create single indexer.
    class IndexerDemo
    {
        static void Main()
        {
            IndexerTest obj = new IndexerTest();
            //In a class if we are having a Indexer, then that class obj will behave like an Array.
            obj[0] = 1000;
            obj[1] = "Lokesh";
            Console.WriteLine("Acc no: " + obj[0]);
            Console.WriteLine("Acc holder Name: " + obj[1]);
            //We can avoid Read/ Write accessor.
            //To assign data/ fetch data, we are making obj as array type. Any class obj behaving like an array, then for sure it has Indexer in it. And we can write either Int Indexer/ String Indexer. Other than these 2 no other type is available.
            //obj[0]/ obj[accno] both are valid in case of string indexer.
        }
    }
    class IndexerTest
    {
        int accno;
        string name;
        //Property/ indexer should be public.
        //In property: we use return as that of var type. Here all var's in single Indexer. Base type for all types is "object". Indexer won't have name. They are going to represent with "this" keyword.
        public object this [int index]
        {
            get
            {
                if (index == 0)
                    return accno;
                else if (index == 1)
                    return name;
                else return 0;//else return null;
            }
            set 
            {
                if (index == 0)
                    accno = (int)value;//Return type of Indexer is "object", so we have to explicitly type cast.
                else if (index == 1)
                    name = (string)value;
            }
        }
        //Diff b/w property & Indexer:
        //For each var, define separate property. Property will have a name. return type as var. 
        //For all var's. define single Indexer. Indexer won't have any name. It is represented by "this". Indexer return type is "object". So, explicit type casting is req when assigning values.
        //Indexer will be either int indexer/ string indexer. Indexer index starts from 0.
        /*
        public object this[string index]
        {
            get
            {
                if (index == "accno")
                    return accno;
                else if (index == "name")
                    return name;
                else return 0;//else return null;
            }
            set
            {
                if (index == "accno")
                    accno = (int)value;//Return type of Indexer is "object", so we have to explicitly type cast.
                else if (index == "name")
                    name = (string)value;
            }
        }
        */
        //Real time projects, we use properties. We have pre-defined classes like "SQLReader" have indexers. Also , collections have indexers.
    }
}
