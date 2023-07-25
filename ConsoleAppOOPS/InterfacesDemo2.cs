using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Multiple Inheritence:
    //Since it is not possile that a class can have multiple Base classes(Multiple Inheritence). We are creating Interfaces for each Base class.
    interface ITest1 {void Hello();}
    class Test1
    {
        public void Hello()
        {

        }
    }
    interface ITest2 { void Hi(); }
    class Test2
    {
        public void Hi()
        {

        }
    }
    interface ITest3 { void Wish(); }
    class Test3
    {
        public void Wish()
        {

        }
    }
    //class ChildTest:Test1, Test2, Test3 
    class ChildTest : ITest1, ITest2, ITest3//Child should implement all Interface methods, in implementation, we are calling the correponding class methods.
    {
        public void Hello()
        {
            //Redirecting the request to actual class method.
            Test1 t1 = new Test1();
            t1.Hello();
            //We can write both in one line:
            new Test1().Hello();
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
            ChildTest obj = new ChildTest();
            obj.Hello();
            obj.Hi();
            obj.Wish();
            //Interfaces uses:
            /*Capturing similarities among unrelated classes without artificially forcing a class relationship.
            When you are learning Solid Principles: In that 3 solid principles depends on Interfaces.
            S: Single Responsibility Principle (SRP)
            O: Open-closed Principle (OCP)
            L: Liskov substitution Principle (LSP)
            I: Interface Segregation Principle (ISP)
            D: Dependency Inversion Principle (DIP)
            https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/
            */
        }
    }
}
