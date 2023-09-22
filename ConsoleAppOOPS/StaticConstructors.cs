using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    /*A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed only once. It is called automatically before the first instance is created or any static members are referenced. A static constructor will be called at most once.
       Syntax:
       static Class_Name(){inialize static data}
     */

    class StaticDemo3
    {
        int no; static int sno;
        //Normal Constructor can be default/ Para/ Copy constructor of obj type. Also we can give Access specifiers (public/ private/ internal) to them. Default scope is private.
        //Can be overloaded. Since supports para constructor (differ in no.of parameters).
        public StaticDemo3()//Default Instance Constructor
        {
            Console.WriteLine("Hi, control is at inside Instance Constructor.");
            no = 100;
            Console.WriteLine(no);
            //We can assign static variables at normal constructor.
            //sno=1234;
            //But that is wrong bcs, static concept is to grab the common properties that are shared by the class objects. That's reason we always use "static readonly".
        }
        //Static Constructor always be a unparametrized constructor type only i.e. it can't take parameters. So, no overloading concept with static constructor. It won't accept Access specifiers/ parameters. Because static constructor called automatically by CLR. User has no control on it (so, scope is not req). Static const invoke only once by CLR though no.of objects were created.
        //----------------------------------------------------------------------
        //Reason of no access specifiers, no parameters is we don't have any control of calling this constructor. What ever instance you create CLR will call static constr once.
        //----------------------------------------------------------------------
        //It can't be inherited/ can't be overloaded (Since it can't accept any parameters). So, a class / struct can have only 1 static constructor.
        static StaticDemo3()//Static Constructor [must be parameterless]
        {
            Console.WriteLine("Hi, control is at inside static Constructor.");
            sno = 300;//intitalising static var.

            //However we can create an instance to access instance variable in static constructor. But no use, because the life ends after end brace of this static const.
            StaticDemo3 sd = new StaticDemo3();
            sd.no = 1;
            Console.WriteLine(sd.no);
            Console.WriteLine();
        }
    }
    class StaticConstructors
    {
        static void Main()
        {
            // Static constructor will call implicitly as soon as the class start to execute
            // the first block of code to execute will be static constructor.
            StaticDemo3 obj1 = new StaticDemo3();
            StaticDemo3 obj2 = new StaticDemo3();
            //OUTPUT:
            //Hi, control is at inside static Constructor.
            //Hi, control is at inside Instance Constructor.
            //Hi, control is at inside Instance Constructor.
            
            //This means that static constructor called before instantiation/ object creation automatically by CLR (Common Language Runtime).
            //Requirement static const for a class is class might contain static var's and normal variables. Normal var's initialisation happen in normal default/ parametrized const. Static var's intialisation happen in static constructor.
        }
    }
    /*Note:
    Static Constructor cannot be overload, because Static Constructors are parameterless constructor, but for overloading, we must need parameterized constructor.
    Private Constructor can be overloaded and we can use that by instance of this class inside the same class. Private members cannot be accessed from outside the class.
    */
    
}
