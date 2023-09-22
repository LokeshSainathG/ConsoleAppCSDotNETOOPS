using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    /*To simplify the properties:
     * In a class we might have 30 var's and 30 properties is difficult. Solution is: From C# 3.x, one
     * concept introduced called "Auto properties", which will be used in real time projects.
     * Question arises, how we can put conditions to the accessors? In those bussiness req's we go with full properties.
    */
    class PropertiesDemo2
    {
        static void Main()
        {
            PropTest2 obj = new PropTest2();
            Console.WriteLine(obj.Accno);
            obj.Name = "Lokesh"; 
            obj.Bal = 13000;
            Console.WriteLine("Balance:" + obj.Bal);
        }
    }
    class PropTest2
    {
        //First of all, no need to declare private var's, only define public props.
        public int Accno { get; }//Read only accessor
        public string Name { private get; set; }//Without get, we can't give set in auto properties. So to write 'Write only accessor' we use "private get" only inside class, "public set" outside class also.
        //In Auto properties, we have a rule that, only "set" accessor is not allowed. If you want Write only access in auto props give get access also but in a private scope. So that it is Write accessor for outside class.
        public long Bal { get; set; }
        //How about var's? Compiler creates variables internally for auto props.
        //variable for the Property "Accno" is "accno".
        //variable for the Property "accno" is "_accno".
        //Can we access these var's? No. To access these var's: use the property name itself
        public void display()
        {
            Console.WriteLine("Variable accno: " + Accno);
            Console.WriteLine("Variable name: " + Name);
            Console.WriteLine("Variable bal: " + Bal);
        }
        //You can use Auto prperties
        //You can define property if you want additional logic: name should be above 3 char's, if bal = 0 then assign else add. For these kind of logics, we created functions. But by defining properties we can write this logic. "PropertiesDemo.cs".
        //Going forward, we declare properties instead of variables. In Windows programming, we only use properties. Usually we won't define var's inside a class in Windows prog.
    }
    //In real-time projects, we use properties only 90%, we use var's only 10%. In Windows programming also we use props.
}

