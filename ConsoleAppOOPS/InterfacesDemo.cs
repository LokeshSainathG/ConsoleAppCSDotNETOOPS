using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    /*Class vs abstract class vs Interface:
    In Class, we are writting Data Members, Methods.
    Interface is another way to achieve abstraction in C#. An interface is a completely "abstract class", which can only contain abstract and properties but !var's (with empty bodies)
    By default, members of an interface are abstract and public implicitly.
    Like abstract classes, interfaces cannot be used to create objects. So, it can't have Constructor.
    Note: Interfaces can contain properties and methods, but not fields/ instance variables. But abstract contain fields. Because abstract class can contain both abstract & non-abstract fields.
    */
    interface IDemo//All pre-defined interfaces start with "I" or _, so follow that habit.
    {
        void Hello();//Abstract method by birth and public implicitly
        void Hi(string name);//Abstract method by birth
        string test();//Abstract method by birth
        //In Interfaces we write only skeleton, no body.
    }
    //Class which implement (or) inherit the Interface should implement the members of that Interface. Since these are abstract implicitly.
    class Demo : IDemo
    {
        //On implementation of Interface, must override all methods with same method signature child class. If it is a property, you should implement it.
        public void Hello()//InheritanceDemo5.cs - Observe the abstract method GetTotal()
                           //no need to specify "override" keyword like abstract methods. 
        {
            Console.WriteLine("Hello..");
        }
        public void Hi(string name)
        {
            Console.WriteLine("Hi..");
        }

        public string test()
        {
            return ("Control at test()");
        }
        public void Wish()
        {
            Console.WriteLine("Soon, you will receive a gift..");
        }
    }
    class InterfacesDemo
    {
        static void Main()
        {
            //We can't instantiate abstract class/ Interface. But we can create obj to them. By Run-time polymorphism we can create objects.
            //We can use Interfaces in many ways. But with imlementation class object you can call Interface methods and class methods as well.
            //IDemo obj = new IDemo();
            IDemo obj = new Demo();
            //OR
            Demo obj2 = new Demo();
            //OR
            //Inject the Interface IDemo [Will discuss later] https://www.section.io/engineering-education/implementation-of-dependency-injection-in-csharp/
            obj2.Hello();
            obj2.Hi("Lokesh");
            Console.WriteLine(obj2.test());
            obj2.Wish();

            //using Interface obj: We can't access child class only methods which is Wish().
            obj.Hello();
            obj.Hi("Lokesh");
            Console.WriteLine(obj.test());
            //this is difference b/w interface obj & child class obj. You can call interface members which were overriden in child class & that class members also we can call.

            //Important thing is we shouldn't use scope for Interface members, since those are public implicitly, no explicit scope required.
        }
    }

    /// <summary>
    /// Rules in Interfaces:
    /// </summary>
    //1. Connecting 2 Interfaces:

    //Inheriting multiple classes is not allowed in C#.
    /*class ABCD : Demo, InterfacesDemo //Using Interfaces we solve this problem of inheriting multiple classes.
    {

    }*/

    interface IFirst
    {
        void Hello();
    }
    interface ISecond : IFirst //how class inheriting from another class, same way Interface can inherit from another interface. 
    {
        void Hi();
    }

    class ABC : ISecond //class which implementing ISecond interface should implement both interfaces methods i.e. Hi() & Hello()
    {
        public void Hi()
        {

        }

        public void Hello()
        {

        }
    }

    //A class can't connect with more than one class
    //But a class can connect with more than one interface. 
    //but, if we write class ABC as: ISecond we need to implement IFirst also no need to mention IFirst. Since ISec inheriting from IFirst.

    interface IFirst1
    {
        void Hello();
    }
    interface ISecond1 : IFirst1
    {
        void Hi();
    }
    class CBA : ISecond1, IFirst1//To inherit ABC class, we should mention class before interfaces in inheritance list.
    {
        public void Hi()
        {

        }
        public void Hello()
        {

        }
    }


    /*When to use Interface and when Abstract class in Real applications:
    Suppose you have 2 classes:
    public cass PermanentEmployee
    {
    }
    public clas ContractualEmployee
    {
    }
    An Interface is good choice when you know a method has to be there, but it can be implemented differently by independent derived classes.  
    interface IEmployee
    {
    void AssignEmil();
    void AssignManager();
    }

    Also you can create Abstract class:
    public abstract class EmployeeDress
    {
    public abstract void DressCode();
    public void DressColor()
    {
    Consol.WriteLine("Blue");
    }
    }
    Abstract class is a good choice when you are sure some methods are concrete/ defined and must be implemented in the same way in all derived classes.

    Best way: Use kind of relationships b/w classes:

    "Is a" -> abstract class
    ContractualEmployee is an "Employee" | 'Dog' is a 'Animal'

    "Has a" -> Interface
    Car has an Engine | Dog has a tail
    */
}