using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Constructors behaviour in Inheritance.
    abstract class Parent1//If you make the class as "abstract", no class (even derived also) can create instance to this class.
    {
        public int i;
        //public Parent1()
        protected Parent1()//We are restricting other classes to create object to Parent1 class. Only derived classes can.
        {
            Console.WriteLine("Control is at Parent1 const");
        }
    }
    class Child1 : Parent1
    {
        public int j;
        public Child1():base()//Internally compiler add base() in child class constr though u didn't specify. So, it executes default parent const.
        {
            Console.WriteLine("Control is at Child1 const");
        }
        //base() is going to call base class members.
        //But it is not like this in case of Methods.
        public void Test()
        {
            
        }
    }
    class InheritanceDemo2
    {
        static void Main()
        {
            Child1 obj = new Child1();//In Inheritance, we keep the common data in Parent class, and child anyway has access to Parent. Then why we need to create object for Parent class. So, we create obj for child class, so that we have access to child class and parent class.
                            //Stil we can create obj for Parent class. To control instantiation of Parent class: Define Parent as "abstract". so that no one can create an instance for that class.
                            //Output: Control is at Parent1  const
                            //Though we are not calling Parent class Constructor, it is executing when we instatntiate Child class.
                            //When you are not implemented a constructor, when you execute compiler will create an implicit default constructor and that will call parent class constructor first. 
                            //Make Parent class constructor as "protected" still it is invoking. Protected members can't accessed by outer class. But accessed by children.
                            //create Child1 constructor also, which one call first? Always preference goes to Parent constructor. Even though explicitly we are not calling base class constructor, internally 
                            //create Child1 constructor also, which one call first? Always preference goes to Parent constructor. Even though explicitly we are not calling base class constructor, internally compiler add ":base()" and call base class constr. Why bcs, we always create object for child class, then when will Parent class constr gets executed? That's why even though we create super most child class instance, it starts executing from super most parent class constr.
                            //Output:Control is at Parent1 const
                                   //Control is at Child1 const
                            //What happens is: Control comes to InstantiaTIon and goes to Child1 cons > internally it defines ":base()". So, it goes to Parent const first, again control comes here.






            //My understandings:
            //Child1 obj2 = new Parent1();//We can't assign Parent class instance or constructor to Child class obj, though it has public constructor
            Parent1 obj3 = new Child1();//We can assign Child class instance or constructor to Parent class obj.
            //This is because: The child class's constructor might initialize additional members, but their blueprint might not be defined in the parent class like in the above case.
            //Though we instantiate Child class constructor (memory) to the Parent class object (reference), we can't access child class members. To do that there is a special mechanism is required called Run-time Polymophism, where we define all child members also in Parent class but with virtual keyword so that it will redirect to child class only.
            obj3.i = 10;
            //obj3.j = 100;//Parent1 reference not able to access Child1 members.
            //Note: Here if you observe, the Parent class is abstract [abstract classes cannot be instantiated]
            //We are not instantiating, but we can able to access its members by using its child class constructor..
            //By comparing this concept with Exception handling try-catch it is opposite. Need further investigation on this. This concept is called Run time Polymorphism which is explained in InheritanceDemo5.cs
            //This concept used only with virtual-override keyword based member (method/ property) overriding.

            //Understood[Abstract classes can't be instantiated. But with Run-time polymorphism we are creating objects and using those members.]
        }
    }
}
