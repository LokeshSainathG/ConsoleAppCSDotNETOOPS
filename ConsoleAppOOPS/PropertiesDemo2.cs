using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    /*To simplify the properties:
     * In a class we might have 30 var's and 30 properties is difficult. Solution is: From C# 3.x, one
     * concept introduced called "Auto properties"
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
        public int Accno { get; }//Read only accessor
        public string Name { private get; set; }//Without get, we can't give set. "private get", "public set". Write only accessor outside class.
        //In Auto properties, we have a rule that, only "set" accessor is not allowed. If you want only Write access the give get access also but make private scope. So that it is only Write accessor outside class.
        public long Bal { get; set; }
        //Compiler creates variables internally.
        //variable for the Property "Accno" is "accno".
        //variable for the Property "accno" is "_accno".
        //To access these var's: use the property name itself
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
}

