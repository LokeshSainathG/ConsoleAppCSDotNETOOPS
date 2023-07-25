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
        //Interview Question:
        //Can we define constructor as "Private"?
        //YES. Like methods how we are defining scope, same way we can define scope for constructor as well (public, private, internal). Except return type Constructor is similar to Method. Based on the design patterns we can define scope.
        //Instance creation is not possible with Private constructor. Then what is the use? In singleton Design patterns, we have to restrict users to create obj for the class. To have just a single instance available to all clients. E.g. A single database object shared by different parts of the program. Go through the Design Patterns.
        //Private constructors are used to prevent creating instances of a class when there are no instance fields or methods, such as the Math class, or when a method is called to obtain an instance of a class. 
        public void display()
        {
            Console.WriteLine(no);
        }
    }

}
