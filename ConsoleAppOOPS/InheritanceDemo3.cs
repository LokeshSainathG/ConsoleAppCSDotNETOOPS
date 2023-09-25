using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //What if base class has only Parametrized constructor, will Compiler calls that if we didn't specify in base(parameters)? No, explicitly we have to specify.
    class Parent2
    {
        protected Parent2(string name)
        {
            Console.WriteLine("Hello "+name+" Control is at Parent2 const");
        }
        //protected Parent2() { }
    }
    class Child2 : Parent2
    {
        public Child2():base("Lokesh")//In this case base() is must. To call base class parametrized constructor, we have to declare base() in child class const.
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
            Child2 obj1 = new Child2("Sainath");//passing data from constructor, by making child constr also parametrized
            Child2 obj2 = new Child2("Lokesh","Sainath");//some data for child, some for parent
            //Base class is taking one parametrized const. Then it is child class responsibility to pass that data.
            //So, we have to create a constructor in Child class and pass the argument to Parent class const.
        }
    }

    /*Parent class having Parametrized constructor:
     1. Parent class having only Parametrized constr    >  We have to create a constr in Child also as Parent having only parametrized constr and pass required data, otherwise at compile time only error will get :base(params) is mandatory. 
     2. We are doing 2 things here, 1 [passing required data] 2 [in case parent having multiple overloaded constructors, we are specifying which constructor needs to executed.] For Default constructor, specifying :base() not required.
     3. If Parent class having default, parametrized constructors, it is not mandatory for child to pass the data. If req, it can.
    */
}
