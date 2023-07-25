using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class StaticReadonlyDemo
    {
        static void Main()
        {
            //Interview Question: Difference const, readonly & static Readonly

        }
    }
    class StaticDemo2
    {
        int a; //Instancs var
        static int b;//Static var. Only one Memory location created.
        readonly int c;//Instance variable only. You can initialise. Or you can assign at constructor level/ init-only setter level.
        static readonly int d; //static nature & Readonly nature. Single memory shared across obj and no method can change this value.
        //We can assign "static readonly" field at variable initialisation/ static constructor only.
        const int e = 30;//const var should be initialised and can't be change anywhere. Similar to readonly, but initilisation is compulsory.
        //constant var can't be static. const can apply for instance var's/ global var/ block var. readonly can be apply for static & instance var's. But not for local/ block var's.
        public StaticDemo2()//Instance Constructor
        {
            a = 10;
            b = 20;//We able to change
            c = 200;
            //d = 20;//Normal constructor can't assign at Instance constructor.
            //e = 50;
        }
        public void display()//Instance Method
        {
            a = 100;
            b = 200;//We able to change static var value anywhere. To control this:
            //c = 400;
            //d = 500;
            const int dd= 12;
            //readonly int ee = 23; //readonly only for class var's only
        }
        static StaticDemo2()//Static constructor
        {
            d = 1000;
        }
        //Always put the initialisation code in the Constructor. Don't initialise Data members directly.

    }
}
