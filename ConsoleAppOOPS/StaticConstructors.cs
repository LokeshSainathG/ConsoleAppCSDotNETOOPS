using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class StaticConstructors
    {
        static void Main()
        {
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
    class StaticDemo3
    {
        int no;static int sno;
        //Normal Constructor can be Default/ Parametrized/ Copy constructor of obj type. We can give Access specifiers (public/ private/ internal) to them.
        //Can be overloaded. Like differ in no.of parameters.
        public StaticDemo3()//Default Instance Constructor
        {
            Console.WriteLine("Hi, control is at inside Instance Constructor.");
            no = 100;
        }
        //Static Constructor always be a unparametrized constructor type only i.e. it can't take parameters. It won't accept Access specifiers/ parameters. Because static constructor called automatically by CLR. User has no control on it (so, scope is not req). Static const invoke only once by CLR whether how many objects are created.
        //It can't be inherited/ can't be overloaded (Since it can't accept any parameters). So, a class / struct can have only 1 static constructor.
        //A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed only once.   
        static StaticDemo3()//Static Constructor
        {
            Console.WriteLine("Hi, control is at inside static Constructor.");
            sno = 300;
        }
    }
}
