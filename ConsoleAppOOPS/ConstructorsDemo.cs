using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class ConstructorsDemo
    {
        public static void Main()
        {
            Number n1 = new Number();//Default constructor will be executed.
            n1.display();
            Number n2 = new Number(23);//Parametrized constructor will be executed.
            n2.display();
            Console.ReadKey();
        }
    }
    class Number
    {
        //If there is no constructor defined for a class. Implicit default constructor will be created when you create an object for the class. <class-name>(); is instantiation nothing but object creation.
        int no;
        public Number()//Explicit default constructor
        {
            no = 0;
        }
        public Number(int a)//Parametrized constructor
        {
            no = a;
        }

        //Interview Questions:
        //Default scope of Constructor? All class members have default scaope as private including constructors.
        //Scope of Default constructor? By default, implicit default constructor scope is "public", explicit default constructor scope "private".

        //Can we define constructor as "Private"?
        //YES. Like methods how we are defining scope, same way we can define access specifier for constructor also (public, private, internal). Based on the design patterns we can define the scope. Some design patterns require constructor to be declared as private then we should use private.
        //Instance creation is not possible with Private constructor. Then what is the use of it? In singleton Design patterns, we have to restrict users by creating obj for the class. To have just a single instance available to all clients. E.g. A single database object shared by different parts of the program. Go through the Design Patterns.
        //Private constructors are used to prevent creating instances of a class when there are no instance fields or methods, such as the Math class, or when a method is called to obtain an instance of a class. 
        public void display()
        {
            Console.WriteLine(no);
        }

        ////////////////////////////////////////////////////////////////////////////
        //constructor-overloading helps in initializing an object in different ways.
        //We can overload constructors in different ways as follows:
        /*
        By using different type of arguments
        By using different number of arguments
        By using different order of arguments*/

        ///////////////////////////////////////////////////////////////////////////
        /*Constructor Chaining: [Invoke an Overloaded Constructor using “this” keyword]
        We can call an overloaded constructor from another constructor using this keyword but the constructor must be belong to the same class, because this keyword is pointing the members of same class in which this is used. This type of calling the overloaded constructor also termed as Constructor Chaining. 

        Let's say class name is About
        public About()
        public About(int a) : this() [Invoke first constructor which is default cons then executes the constructor body]
        public About(double b) : this(int) [Invoke second constructor then executes the constructor body]

        If you just create instance for third oncstructor it calls 2nd and it calls 1st. So execution is 1st body> 2nd body > 3rd body.
        */
    }

}
