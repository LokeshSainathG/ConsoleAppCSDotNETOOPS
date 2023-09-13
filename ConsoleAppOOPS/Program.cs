using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class Program//Main class
    {
        static void Main(string[] args)
        {
            //Till now we implemented all programs inside a Class.
            //But in any real time project: There will be multiple implementations and functionalities.
            //In a Banking proj: There are diff Account types (Savings, Current, Joint, Minor), for each acc functionality is different.
            //In structured Programming like C, we have a format - Header secttion > Global var declaration, Pre-processor directives > Functions.
            //But there is no concept of security for our data.
            //Because of that reason: Obj-oriented paradigms came into picture.
            //for any organisation, data security first and foremost.
            //OOP mainly concentrated on Data security.

            /*In OOP: there are 2 imp terms:
             * Class, Object
             * Class - Blueprint/ Template of data variables, Methods. Nothing is initialised or executed untill the object is instantiated except Main() method and not Main() method class.
             * Object - Real time entities. Memory gets allocated by creating an object to class. A class can have multiple objects. For each obj the memory is separately allocated since an obj is real time entity.
             * Class defines characteristics of its Objects. 
             * Class is a User-defined type. We can't access class directly.
             */
            Employee e1 = new Employee();//e1 is an object. Obj is called an instance of a class.
            //An obj is an entity which has properties and behaviour associated with it for identifying the state, methods for behaviour, events for descrition. 
            //Memory gets allocated in the way: e1.eno, e1.ename, e1.sal

            Employee e2 = new Employee();
            //e2.eno, e2.ename, e2.sal - separate Memory
            //Instances won't share memory with other instance.
            //Employee e2 is Object creation.
            //new Employee() is Instance creation with the help of "new". "new" helps in allocating memory at Runtime.
            Employee e3; //Memory is not allocated for e3. Employee is user-defined type. [Obj creation done at compile time]
            int a=0;//int is pre-defined type
            e3 = new Employee(); //Memory is instantiated for e3. [instantiation done at run time
            e1.getdata();
            e1.display();

        }
    }

    class Employee//Creating new type called Employee
    {//class is internal to project by default. But if this class need to visible outside the project (using namespace/ by loading the dll) make this as public specifier
        //class can have static MethodAccessException/ normal method
        //Inside class we can have Data members, member functions, constructors, properties, indices.

        //Class var/ Data members/ Fields
        public int eno;
        string ename;
        long sal;
        //Memory is not allocated to Data members untill obj is instantiated.

        //Function inside class is called method/ member functions.
        public void getdata()//Method Which function need to visible publicly only those make as public. Some might as internal to project. Some might as protected based on requirement.
        {

        }
        public void display()
        {

        }
    }

        /*OOP Principles:
        -----------------
        Encapsulation, Data hiding, Inheritance, Polymorphism
         * Encapsulation (Putting data, methods inside one block. 
         * Fully Encapsulation: Object can access behaviour (methods) through the methods they can access the data memebers. It can be achieved with the help of class. Objecct can't access data members directly. Accessing Data memebers using object can be acehived by the help of Access Specifiers)
         * Access Specifiers:
         * public (publicly available), private (with-in class only), internal (with-in the project only), protected()
         * class scope is internal by default. And we can change to public only
         * class members scope is private by default. And you can make it as public or internal.
         * 
         * 
         * Data hiding
         * 
         * 
         * Inheritance
         * Polymorphism 
         * Overloading (Operator overloading, Method overloading 
         * Operator Overloading: Predefined unary, arithmetic, equality and comparison operators
         * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
         * 
         * 
         * What ever project you take, all are using OOPS concepts. Recollect how exactly they are using.
         */
        //Java vs C#:
        //Java doesn't support for operator overloading whereas C# provides operator overloading for multiple operators.
        //Java does not support pointers while C# supports pointer only in an unsafe mode.
        //In Java, Arrays are a direct specialization of Object whereas arrays in C# are a specialization of System.
        //No jump statement (goto) in Java.
        //Lambda, generics support. Also LINQ (Language Integrated Query) Expressions in C#

        //No.of Public classes:
        //In C#, there are multiple public classes included in the source code.
        //In Java, there is an only a single public class inside source code, or it will display compilation error.

        //Just-In-Time compiler(JIT) is a part of Common Language Runtime (CLR) in .NET which is responsible for managing the execution of .NET programs regardless of any .NET programming language.
}
