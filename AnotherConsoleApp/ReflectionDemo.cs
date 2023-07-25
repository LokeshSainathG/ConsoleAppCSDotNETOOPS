using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[from metadata] means it is present in different Project, only description about assembly like name, visibility, base class, interfaces, methods, fields, properties, events are visible. 

//Reflection objects are used for obtaining type information at runtime. The classes that give access to the "metadata" of a running program are in the System.Reflection namespace.
//The System.Reflection namespace contains classes that allow you to obtain information about the application and to dynamically add types, values, and objects to the application.
using System.Reflection;

namespace AnotherConsoleApp
{
    class ReflectionDemo
    {
        static void Main()
        {
            //Reflection helps to fetch the Class members like var's, properties, Constructors, Methods, interfaces. 
            //When you developed a SW and make users to choose what they want, at runtime we can do by using Reflections.
            //Reflection related classes available in System.Reflection namespace.
            Type T = Type.GetType("AnotherConsoleApp.Customer");//of Customer type is present in AnotherConsoleApp namespace 
            PropertyInfo[] propertiesList = T.GetProperties(); //Retuns all the properties availale in Customer class and store into array.
            foreach(var item in propertiesList)
                Console.WriteLine(item.Name + " - "+item.PropertyType);//Like this we can fetch all Properties info related to Customer class.
            Console.WriteLine();
            /*OUTPUT:
            Cid - System.Int32
            Cname - System.String
            Name-of-the-Property - Type-of-the-Property*/ 

            MethodInfo[] methodsList = T.GetMethods();
            foreach (var item in methodsList)
                Console.WriteLine(item.Attributes);
            Console.WriteLine();

            ConstructorInfo[] constructorList = T.GetConstructors();//List of Constructors
            foreach (var item in constructorList)
                Console.WriteLine(item.Attributes);//You can check it is IsPublic/ IsStatic/ GetParameters (to fetch Parameters List)/ Attributes
            //To fetch available constructor:
            /*
             * PropertyInfo - GetProperties()
             * MethodInfo - GetMethods()
             * ConstructorInfo - GetConstructors()
             */

            /*Like this in Forms, you click on any control > that button/ checkbox/ radio button and that control Root properties are getting into Properties window. This is because of Reflections concept.
             * Similarly for Events concept also.
             */
            EventInfo[] eventsList = T.GetEvents();//Return all event list


            //Properties of CheckBox:
            //CheckBox is present in System.Windows.Forms namespace
            //T = Type.GetType("System.Windows.Forms.CheckBox");
            //PropertyInfo[] propertiesList1 = T.GetProperties(); //To get all the properties availale in Customer class.
            //foreach (var item in propertiesList1)
            //    Console.WriteLine(item.Name + " - " + item.PropertyType);

        }
    }
}
