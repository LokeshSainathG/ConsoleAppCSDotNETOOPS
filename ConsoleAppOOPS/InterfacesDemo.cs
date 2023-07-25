using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    /*Class vs abstract class vs Interface:
    In Class, we are writting Data Members, Methods.
    Interface is another way to achieve abstraction in C#, is with interfaces. An interface is a completely "abstract class", which can only contain abstract and properties but !var's (with empty bodies)
    By default, members of an interface are abstract and public.
    Like abstract classes, interfaces cannot be used to create objects. So, it can't have Constructor.
    Note: Interfaces can contain properties and methods, but not fields/ variables.
    */
    interface IDemo//All pre-defined interfaces start with "I", so follow that habit.
    {
        void Hello();//Abstract method by birth
        void Hi(string name);//Abstract method by birth
        string test();//Abstract method by birth
    }
    //Class which implement (or) inherit the Interface should implement the methods of that Interface.
    class Demo : IDemo
    {
        //On implementation of Interface, must override all methods with same method signature child class. If it is a property, you should implement it.
        //Interfaces are used to maintain some uniqueness in the whole proj.
        public void Hello()//InheritanceDemo5.cs - Observe the abstract method GetTotal()
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
            //We can't instantiate abstract class/ Interface. But we can create obj.
            //We can use Interfaces in many ways. But with imlementation class object you can call Interface methods and class methods as well.
            //IDemo obj = new IDemo();
            IDemo obj = new Demo();
            //OR
            Demo obj2 = new Demo();
            //OR
            //Inject the Interface IDemo [Wil discuss later]
            obj2.Hello();
            obj2.Hi("Lokesh");
            Console.WriteLine(obj2.test());
            obj2.Wish();
        }
    }
}



/*Rules in Interfaces:
1. Connect 2 Interfaces:*/
interface IFirst
{
void Hello();
}
interface ISecond : IFirst
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
//A class can connect with more than one interfaces
//So, we can also write class ABC as: ISecond no need to inherit IFirst
interface IFirst1
{
    void Hello();
}
interface ISecond1 : IFirst1
{
    void Hi();
}
class CBA:ISecond1, IFirst1
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