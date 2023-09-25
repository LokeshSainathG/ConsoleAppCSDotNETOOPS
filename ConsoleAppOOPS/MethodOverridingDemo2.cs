using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //1. virtual - override keywords
    //2. base keyword in method overriding
    class baseClass2
    {
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }

    class derived2 : baseClass2
    {
        //Both the override method and the virtual method must have the same access level modifier.
        //'show()' is 'override' here
        public override void show()
        {
            //base.showdata();
            Console.WriteLine("Derived class");
        }
    }
    class MethodOverridingDemo2
    {
        public static void Main()
        {   
            baseClass2 obj;
            obj = new baseClass2();
            obj.show(); //Base class
            obj = new derived2();
            obj.show(); //Derived class
            //Rereferencing the Object, can call derived class methods with [virtual-override]
        }
    }
    /*base keyword in method overriding:
     * We can use "base.showdata();" to call base class method in derived class method. And it is enough to create obj and instance for Child class.
     * We can use "base" keyword in both cases "new" or "virtual-override". 
     */
}
