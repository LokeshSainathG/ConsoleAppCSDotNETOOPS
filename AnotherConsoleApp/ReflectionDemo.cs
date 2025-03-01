using System;
using System.Reflection;
using System.Windows.Forms;

//Reflection is the ability of inserting an Assemblies metadata at Runtime.
//[from metadata] means it is present in different Project, only description about assembly like name, visibility, base class, interfaces, methods, fields, properties, events are visible. 

//Reflection objects are used for obtaining type information at runtime. The classes that give access to the "metadata" of a running program are in the System.Reflection namespace.
//The System.Reflection namespace contains classes that allow you to obtain information about the application and to dynamically add types, values, and objects to the application.



namespace AnotherConsoleApp
{
    class ReflectionDemo
    {
        static void Main()
        {

            //Reflection helps to fetch the Class members like var's, properties, Constructors, Methods, interfaces.
            //When you developed a SW and make users to choose what they want, at runtime we can do by using Reflections.
            //Reflection related classes available in System.Reflection namespace.
            Type T = Type.GetType("AnotherConsoleApp.Customer");//Customer class type is present in AnotherConsoleApp namespace. [here Type is a class that to abstract, so we can't instantiate only can create obj. 'T' is a obj, GetType() is Static constructor, so ]

            //To know the properties in that Customer type: use GetProperties()
            PropertyInfo[] propertiesList = T.GetProperties(); //Retuns all the properties availale in Customer class and store into array.
            //[PropertyInfo is abstract class.]
            foreach (var item in propertiesList)
                Console.WriteLine(item.Name + " - "+item.PropertyType);//Like this we can fetch all Properties info related to Customer class. if you want you can fetch the Property type as well.
            Console.WriteLine();
            /*OUTPUT: Name_of-theProperty - Type_of-theProperty]
            Cid - System.Int32
            Cname - System.String
            */

            /////////////////////To fetch available methods info in Customer class ////////////////////////
            MethodInfo[] methodsList = T.GetMethods();
            foreach (var item in methodsList)
                Console.WriteLine(item.Attributes);
            Console.WriteLine();

            /////////////////////To fetch available constructors info  in Customer class ////////////////////////
            ConstructorInfo[] constructorList = T.GetConstructors();//List of Constructors
            foreach (var item in constructorList)
                Console.WriteLine(item.Attributes);//You can check it is IsPublic/ IsStatic/ GetParameters (to fetch Parameters List)/ Attributes
            Console.WriteLine();

            /* PropertyInfo - GetProperties()
             * MethodInfo - GetMethods()
             * ConstructorInfo - GetConstructors()
             */


            //Similarly, if you want all info reg CheckBox class: Assembly qualified name is "System.Windows.Forms.CheckBox"
            //Properties of CheckBox:
            //CheckBox is present in System.Windows.Forms namespace
            //Console.WriteLine("CheckBox class information:");
            //T = Type.GetType("System.Windows.Forms.CheckBox");//Getting NullReference Exception......... Why it is causing. reason could be this library not added for this project. Even if import "using System.Windows.Forms;" also it can't identify. Add Reference > Assemblies > Framework > System.Windows.Forms.
            //That also not resolved...
            //PropertyInfo[] propertiesList1 = T.GetProperties(); //To get all the properties availale in Customer class.
            //foreach (var item in propertiesList1)
            //    Console.WriteLine(item.Name + " - " + item.PropertyType);
            //Console.WriteLine();

            T = Type.GetType("System.String");//With String class it is working fine.
            PropertyInfo[] propertiesList1 = T.GetProperties();
            foreach (var item in propertiesList1)
                Console.WriteLine(item.Name + " - " + item.PropertyType);
            Console.WriteLine();
            //Has two properties: Chars, Length.

            /*Like this in Forms, when you click on any control > that button/ checkbox/ radio button and that control Root properties are getting plcaed into Properties window. This is because of Reflections concept. How they are shiwubg is they prepared a window, inside that for the property Name: type of the property, default value. They are showing by using the Reflections concept. Bcs of Reflection, we are getting those many properties for a COntrol.
             * Similarly for Events concept also. If you select any control > open Events in Properties Window.
             * Reflections are helpful when you are creating Softwares, not for aplications. to make users choice more easy 
             */

            /////////////////////// To fetch all events list: ///////////////////////
            EventInfo[] eventsList = T.GetEvents();//Return all event list in Customaer class. But Customer class doesn't have any Events.
            foreach (var item in eventsList)
                Console.WriteLine(item.Attributes);
            Console.WriteLine();
        }
    }
}
