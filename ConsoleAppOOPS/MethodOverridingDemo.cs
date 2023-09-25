using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    /*
    * In C# we can use 4 types of keywords for Method Overriding:
    1. base Keyword: 
    Use of Base keyword: 
    • Call methods or functions of base class from derived class.
    • Call constructor internally of base class at the time of inheritance.

    2. new keyword: To hide the member that is inherited from a base class intentionally. When you hide an inherited member, the derived version of the member replaces the base class version.

    3. virtual keyword: This modifier or keyword use within base class method. It is used to modify a method in base class for overridden that particular method in the derived class.

    4. override: This modifier or keyword use with derived class method. It is used to modify a virtual or abstract method into derived class which presents in base class.
     */
    class baseClass
    {
        public void show()
        {
            Console.WriteLine("Base class");
        }
    }

    class derived : baseClass
    {
        new public void show()// overriding using 'new'. Our intension is to hide only, if any one want to call display(), need to call child class method only not base class one. From child we call base class method if require. To override method with out hiding completely means, we need to use virtual-override keywords.
        {
            Console.WriteLine("Derived class");
        }
    }

    class MethodOverridingDemo
    {
        public static void Main()
        {
            baseClass obj = new baseClass();
            obj.show(); //Base class
            obj = new derived();//re-referencing obj to derived class.
            obj.show(); //Base class
            //Rereferencing the obj can't call dervied class method.
            //obj invokes class baseClass two times.
            //To avoid this problem we use virtual and override keyword. [Demo2]
            derived obj2 = new derived();
            obj2.show(); //Derived class
        }
    }
}
