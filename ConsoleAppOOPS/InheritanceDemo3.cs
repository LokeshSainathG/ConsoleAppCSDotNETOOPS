using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class Parent2
    {
        protected Parent2(string name)
        {
            Console.WriteLine("Hello "+name+" Control is at Parent2 const");
        }
    }
    class Child2 : Parent2
    {
        public Child2():base("Lokesh")//In this case base() is must. To call base class parametrized constructo, we have to declare base() in child class const.
        {
            Console.WriteLine("Control is at Child2 const");
        }
        //You can also pass the argument from Main() program. Pass the arg using parametrized constructor and pass that to base().
        public Child2(string name) : base(name)
        { Console.WriteLine("Hi " + name + " Control is at Child2 const"); }
        //Also if you want to pass Child arg, Parent arg separately.
        public Child2(string cname, string pname) : base(pname)
        { Console.WriteLine("Hi "+cname+" Control is at Child2 const"); }
        //If the Parent class having Parametrized const only, then it is Child class responsibility to pass the req args. If not passing it won't allow to proceed coding.
        //In case in Parent class, if there is a Default constructor, then it is not mandatory that child has to pass args.
    }
    class InheritanceDemo3
    {
        static void Main()
        {
            Child2 obj = new Child2();
            Child2 obj1 = new Child2("Sainath");
            Child2 obj2 = new Child2("Lokesh","Sainath");
            //Base class is taking one parametrized const. It is child class responsibility to pass that data.
            //So, we have to create a constructor in Child class and pass the argument to Parent class const.
        }
    }
}
