using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Multiple Inheritance:
    //Since it is not possile that a class can have multiple Base classes(Multiple Inheritence). We are creating Interfaces for each Base class.
    //for each class, there is a Interface
    interface ITest1 {void Hello();}
    class Test1
    {
        public void Hello() { } //original Hello()
    }
    interface ITest2 { void Hi(); }
    class Test2
    {
        public void Hi() { } //original Hi()
    }
    interface ITest3 { void Wish(); }
    class Test3
    {
        public void Wish() { } //original Wish()
    }
    //class ChildTest:Test1, Test2, Test3 //A class can't connect with more than one class. But it can connect with more than one Interface.
    class ChildTest : ITest1, ITest2, ITest3//Child should implement all Interface methods, in implementation, we are calling the correponding class methods.
    {
        public void Hello()
        {
            //Redirecting the request to actual class method.
            Test1 t1 = new Test1();//Hello() belongs to Test1 class which implements ITest1.
            t1.Hello();
            //We can write both in one line by creating only instance not object:
            new Test1().Hello();//directly we are calling the method using Constructor.
        }

        public void Hi()
        {
            new Test2().Hi();
        }

        public void Wish()
        {
            new Test3().Wish();
        }
    }
    class InterfacesDemo2
    {
        static void Main()
        {
            ChildTest obj = new ChildTest();//Class which implemented all 3 interfaces
            //We are calling original methods by redirecting.
            obj.Hello();
            obj.Hi();
            obj.Wish();
            //We are creating obj to child class, with the help of child class we are calling all parent classes members by using Interfaces. 3 Base classes, one derived class.
            //For each Parent we have to write an Interface and Child class need to connect to the corresponding interfaces, in the method body we have to redirect the request respective class.
            //OR

        }
    }
}

// [Go through "C# Design Patterns" in COnstructorsDemo.cs]
//Interfaces uses:
/*Capturing similarities among unrelated classes without artificially forcing a class relationship.
When you are learning SOLID Design Principles: In that 3 solid principles depends on Interfaces.
S: Single Responsibility Principle (SRP)    
O: Open-closed Principle (OCP)
L: Liskov substitution Principle (LSP)
I: Interface Segregation Principle (ISP)
D: Dependency Inversion Principle (DIP)

SRP states: Each software module should have one and only one reason to change.
OCP states: Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.
LSP states: Subtypes must be substitutable for their base type.
ISP states: Clients should not be forced to depend on methods they do not use. ISP can be used in conjunction with LSP
DIP states: High-level modules should not depend on low-level modules. Both should depend on abstraction
https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/

*/
