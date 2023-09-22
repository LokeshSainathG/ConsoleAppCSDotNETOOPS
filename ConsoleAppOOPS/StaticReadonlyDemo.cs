using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Static readonly variable used to protect static variable from modifications.
    
    class StaticDemo2
    {
        int a; //Instancs var
        static int b;//Static var. Only one Memory location created.
        readonly int c;//Instance variable, You can initialise (or)only you can change at constructor level/ init-only setter level.
        static readonly int d;//static nature & Readonly nature. Single memory shared across obj and no method can change this value.
        //We can assign "static readonly" field at variable initialisation/ static constructor only.
        const int e = 30;//const var should be initialised and can't be change anywhere.
        //constant var can't be static. const can apply for instance var's/ block var readonly can be apply for  instance var's/ static instance var's. But not for local/ block var's. [there is no global var concept in C#, in C/C++, const can be applied to global var's also]. 

        public StaticDemo2()//Instance Constructor
        {
            a = 10;
            b = 20;//We able to change static field at instance constructor level, this is the problem
            c = 200;
            //d = 20;//Normal constructor can't assign static read-only field, need explicit Static constructor.
            //e = 50;//e is constant
        }
        public void display()//Instance Method
        {
            a = 100;
            b = 200;//We able to change static var value anywhere. To control this:
            //c = 400;//Error: readonly can change at constructor level not at method
            //d = 500;//static method req for static var readonly. But instance method can access static var. 
            const int dd= 12;
            //readonly int ee = 23; //readonly only for class var's only
        }
        static StaticDemo2()//Static constructor
        {
            d = 1000;//If you initialise fields and assign at constructor level also, it consider constructor values only.
        }
        //Always put the initialisation code in the Constructor. Don't initialise Data members directly.

        class StaticReadonlyDemo
        {
            static void Main()
            {
                //Interview Question: Difference b/w const, readonly, static & static-readonly variables
                const int x = 0;//block const variable
                //readonly int y = 1;
                //static readonly int y = 3;
                //unlike const, readonly can't be used with methods or blocks. Even static also not valid.
                //static int z= 9;
            }
        }
    }
}
