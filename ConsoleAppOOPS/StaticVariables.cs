﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class StaticVariables
    {
        static void Main()
        {
            StaticDemo obj1 = new StaticDemo();//Memory allocated to instance var's when you create an instance.
            //For instance var's/ class var's for every obj creation memory is going to allocate.
            StaticDemo obj2 = new StaticDemo();//separate memory for "no" for obj2
            //Initially obj1.no=0,sno=0, obj2.no=0. Why?
            //For a class if no constructor is defined. Implicit default constructor defined by Compiler. And it assign instance var's as 0 to value type& NULL to reference type var's. But for static variables value will be 0 by default.
            //int a;
            //Console.WriteLine("Use of unassigned local var is not supported."+a);
            obj1.increment();//obj1.no=1,sno=1
            obj1.increment();//obj1.no=2,sno=2
            obj1.display();
            obj2.increment();//obj2.no=1,sno=3. 
            obj2.display();
            //For every customer the minimum balance should be 1000. So we can make minbal as static, so that each customer (obj) should have minbal as 1000. name, accno, balance are vary with each cu (obj). It going to save the Memory. Problem with static var is: everyone can change the static var. To control that: StaticReadonlyDemo.cs
        }
    }
    class StaticDemo
    {
        int no;//instance var| class var
        static int sno;//static var.
        //Before obj creation, memory is allocated for static var's and only one static var is created in Memory same is shared for all obj's of the class.
        public void display()//Instance method: It can access both instance var's & static var's 
        {
            Console.WriteLine("Instance var:" + no);
            Console.WriteLine("Static var:" + sno);
        }
        public static void display1()//Static method: It can only access static var's.
        {
            Console.WriteLine("Instance var:" + sno);
        }
        public void increment()//instance method
        {
            no++;
            sno++;
        }

        /*An Instance member can access both instance members & non-instance members (static members)
         * A static member can access only static members. Why?For instance var's, when instant created, memory will be allocated. For static var's when program executed, memory allocated. Also static methods can access by class name. In main program without creating obj we can access static methods. So, how we can access instance var's without memory allocation.
         * Because of these reasons static members can't access normal instance members (variable/ method).
         */
        //Is there any to access instance members from static method? Yes. By instantiating class.
        public static void decrement()//static method
        {
            //no--;
            StaticDemo obj = new StaticDemo();
            obj.no--;//We are able to access instant var from static method.
            sno--;
        }
    }
}
