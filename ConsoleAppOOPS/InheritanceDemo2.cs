using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Constructors behaviour in Inheritance.
    class Parent1
    {
        //public Parent1()
        protected Parent1()
        {
            Console.WriteLine("Control is at Parent1 const");
        }
    }
    class Child1 : Parent1
    {
        public Child1():base()//Internally compiler add base() in child class const though u didn't specify. So, it executes default parent const.
        {
            Console.WriteLine("Control is at Child1 const");
        }
        //base() is going to call base class members.
        //But it is not like this in case of Methods.
    }
    class InheritanceDemo2
    {
        static void Main()
        {
            Child1 obj = new Child1();//In Inheritance, we keep the common data in Parent class, and child anyway has access to Parent. Then why we need to create object for Parent class. So, we create obj for child class, so that we have access to child class and parent class.
                                      //Stil we can create obj for Parent class. To control instantiaon of Parent class:
                                      //Define Parent as "abstract". No one can create an instance for that class.
                                      //Output: Control is at Parent1  const
                                      //Though we are not calling Parent class Constructor, it is executing when we instatntiate Child class.
                                      //When you are not implemented a constructore, when you execute compiler will create an implicit default constructor and that call parent class constructor. 
                                      //Make Parent class constructor as "protected" still it is invoking. Protected members can't accessed by outer class. But accessed by children.
                                      //Define Child1 constructor, which one call first? Always preference goes to Parent constructor.
                                      //Output:Control is at Parent1 const
                                      //Control is at Child1 const
                                      //What happens is: Control comes to Instantiaon and goes to Child1 cons > internally it defines ":base()". So, it goes to Parent const first, again control comes here.

        }
    }
}
