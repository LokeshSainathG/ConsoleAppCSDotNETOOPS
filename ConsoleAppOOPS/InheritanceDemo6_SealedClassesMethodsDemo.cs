using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Sealed class is used to prevent Inheritance.
    //Sealed method is used to prevent Method Overriding in child class.
    class FirstClass
    {
        public virtual void Hello() { }
        public virtual void Hi() { }
    }
    class SecondClass:FirstClass
    {
        public override void Hello() { }
        public override void Hi() { }
    }
    class ThirdClass:SecondClass
    {
        public sealed override void Hello() { }
        public override void Hi() { }
        public void Hello(string name) { }//sealed method prevent only overriding, not overloading.
                                          
    }
    //Multi-Level Inheritence [Where multiple levels are there]
    sealed class FourthClass:ThirdClass
    {
        //sealed method can't override in Child.
        //public override void Hello() { } //sealed method. Though you can override in child class by hiding the base class, by using "new" keyword.
        public override void Hi() { }
    }
    //sealed class will be the ending of Inheritance or last child.
    //class FifthClass : FourthClass
    //{
    //    public override void Hello() { }
    //    public override void Hi() { }
    //}
    //If we define any class as "sealed". Then we can't create a child for that class.
    //We can create object to it, where we get limited access t it. But if you inherit that you will get complete access into it. So it can be defined as "sealed" to prevent Inheritance.
    class InheritanceDemo6_SealedClassesMethodsDemo
    {
        static void Main()
        {

        }
    }
}
