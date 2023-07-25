using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Sealed class is used to prevent Inheritence.
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
    }
    sealed class FourthClass:ThirdClass
    {
        //sealed method can't override in Child.
        //public override void Hello() { }
        public override void Hi() { }
    }
    //class FifthClass : FourthClass
    //{
    //    public override void Hello() { }
    //    public override void Hi() { }
    //}
    //Multi-Level Inheritence
    //If we define any class as "sealed". Then we can't create a child for that class.
    class InheritanceDemo6_SealedClassesMethodsDemo
    {
        static void Main()
        {

        }
    }
}
