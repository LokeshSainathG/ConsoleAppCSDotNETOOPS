using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //In real time projects we very rarley use Indexers. But it is important to learns bcs, in C# pre-defined classes there are many Indexers used. To understand the behaviour of those, we need to learn this concept. Similar to properties, indexers are used to access the private data which is inside the class at outside the class scope.
    //Diff b/w Indices & properties is: for each var, we create separate property. For all var's we create single indexer.
    
    class IndexerTest
    {
        int accno;
        string name;
        //Property/ indexer should be public.
        //In property: we use return as that of var type. Here all var's have single Indexer. Since base type for all types is "object", we use object type for indexer. Indexer won't have name. They are going to represent with "this" keyword. So, for one class, only one Indexer enough. Indexers can be overloaded also.
        public object this [int index]//
        {
            get
            {
                if (index == 0)
                    return accno;
                else if (index == 1)
                    return name;
                else return 0;//OR
                //else return null;
            }
            set 
            {
                if (index == 0)
                    accno = (int)value;//Return type of Indexer is "object", so we have to explicitly type cast value.
                else if (index == 1)
                    name = (string)value;
            }
        }
        //Diff b/w property & Indexer:
        //For each var, define separate property. Property will have a name. return type as var. 
        //For all var's. define single Indexer. Indexer won't have any name. It is represented by "this". Indexer return type is "object". So, explicit type casting is req when assigning values.
        //Indexer will be either int index/ string index. Indexer index starts from 0.

        class IndexerDemo
        {
            static void Main()
            {
                IndexerTest obj = new IndexerTest();
                //How to access indexers?
                //Properties we accessed in normal class variables mannar.  
                //In a class if we are having a Indexer, then that class obj will behave like an Array.
                obj[0] = 1000;
                obj[1] = "Lokesh";
                //Indexer is array like Property. Indexers allow instances of a class or struct to be indexed just like arrays.
                Console.WriteLine("Acc no: " + obj[0]);
                Console.WriteLine("Acc holder Name: " + obj[1]);
                //We can restrict Read/ Write accessor for the data members.
                //To assign data/ fetch data, we are making obj as array type. Any class obj behaving like an array, then for sure class has an Indexer in it. And we can write either Int Indexer/ String Indexer. Other than these 2 no other type is available.
                //obj[0]/ obj[accno] both are valid in case of string indexer.
            }
            //Existing classes like SQL Data Reader, Collections are having Indexers. This reason we have to understand this concept.
        }

        /*String Indexer:
        public object this[string index]
        {
            get
            {
                if (index == "accno")
                    return accno;
                else if (index == "name")
                    return name;
                else return 0;
            }
            set
            {
                if (index == "accno")
                    accno = (int)value;//Return type of Indexer is "object", so we have to explicitly type cast.
                else if (index == "name")
                    name = (string)value;
            }
        }
        //either integer index/ string index both are valid with String Indexer.
        //obj["name"] = "Lokesh";
        //obj[1] = "Lokesh";
        */
        //Real time projects, we use properties. We have pre-defined classes like "SQLReader" have indexers. Also , collections have indexers.
    }
    //C# allows us to define custom indexers, generic indexers, and also overload indexers.
}
