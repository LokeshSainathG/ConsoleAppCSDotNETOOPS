using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Instead of writing from the scratch, try to use pre-defined classes, methods. Also reuse existing classes, methods using Inheritance concept.
    /*To understand use of Inheritance let's create a WindowsForms proj. [AllWindowsForms(.NetFramework)]
     * WindowsForms designing provides Drag& Drop to create instances of pre-defined classes.
     * In the Toolbox, all tools are nothing but classes. All these classes developed by MS and given under single window called "Toolbox".
     * Based on your proj requirement, you use the controls. If you drag and drop the button control. It means you are creating an instance for the "Button" class. You can create no.of instances for a single class. So, you can drag& drop multiple times. Each obj have their own values. Select the button > Properties (F4)(Alt+Enter). You can change BG color, text, ...all those will reflect to button1 only.
     * Incase, if you want to design a Desktop app like create Button, Textbox, Chekbox, Combobox, etc., you have to write from scratch and will take so much time.
     * In Java, Applets (need HTML code) & Swings (Uses MVC) are to design UI applications like Forms.
     * What Properties you are changing based on that the background code is going to generates and changes.
     * To go to Properties Window (F4) in that we can see so many properties. Readonly, Writeonly, Read&Write. Many common properties like Font, BG Color, FG Color are there for Button, Checkbox, Textbox also.
     * If you goto "Button" definition, it has only few properties inside its definition. Font, BGColor, FGColor, etc., are not define inside it. All common properties are defined inside Base class.
     * "Control" is the Base class for all controls.
     * class <name> : <Parent-class-name>
     * colon : b/w 2 classes represents Inheritance.
     */


    //Tells the scope Second on First class members:
    public class First//Parent|Base|Super class
    {
        public void Method1() { }//Accessible in entire assembly also another assembly that references it (dlls)
        private void Method2() { }//Scope restricted to class [Default scope for class members]
        internal void Method3() { }//Scope restricted to Project/ assembly
        //For Inheritance we have one more access specifier called protected.

        protected void Method4() { }//Scope is restricted to class & Derived classes
                                    //We have two more called "private protected", "protected internal" 
        private protected void Method5() { }//[private/ protected]Scope is restricted to derived classes that declared within current assembly.
        //private protected Introduced recently.
        protected internal void Method6() { }//[protected/ internal]Scope is restricted to derived classes in the same assembly also in another assembly.
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

    }
    class Second : First//Child| derived| Sub class
    {
        public void Test()
        {
            Method1();
            //Method2();//Private members can't access in derived classes also
            Method3();
            Method4();
            Method5();
            Method6();
        }

    }
    class InheritanceDemo1
    {
        static void Main()
        {
            //InheritanceDemo1 is not inheriting First class. So to access the methods in it, we have to create obj for First class.
            First f = new First();
            f.Method1();
            //f.Method2();//Private type
            f.Method3();
            //f.Method4();//Protected types can be accessible by children classes & can't accessible using objects outside class.
            //f.Method5();//private - we can't access outside class. protected - within children classes
            f.Method6();//protected or internal any one rull applicable. so you can access in derived classes (even in another assembly) as well as in the same assembly

        }
    }
}

/*
 * When you are using Inheritance concept Scope is very important. Demo1
How constructors and others are behaving. Demo2

The program InheritanceDemo1.cs is in ConsoleAppOOPS:
	First class
Lets say we have another project "TestProject"
	class Test:First
	{//What methods we can call by inheriting First class:
	Actually the Scope of class First is internal, so we can't access in another project. First, we have to make that as public.
	public void Demo(){
	//Method1();//Obj req - public
	Method4();
	Method5();
	Method6();
	}
	}
class ABC//No Inheritence
{
static void Main()
{
First obj = new First();
obj.Method1();//public - only public members you can access outside the project.
}
}
Suppose I have to projects in a Solution. How to access the class outside the project?
We have to create Reference:
Right click on the Project where you wanna to add ref > Add > Reference > Add the second project by selecting > OK.
OR
Select the References > Right click > Add Reference > Projects > Select the Source Project > Ok.
Then the Source project will add to the References.
If you make class a public then only it visible outside the project and Referencing proj's can use that.
Import the namespace in destination proj and rock.

If you want to use Console.WriteLine(): import System above at begining as a namespace. And System dll should be available in References.


How we include headerfiles in C/C++, we include namespaces.
Headerfile comprises all class declarations in C++.
In C# all classes of a project are comes under a Namespace.
https://www.c-sharpcorner.com/blogs/types-of-namespace-in-c-sharp

https://stackoverflow.com/questions/11814771/why-doesnt-c-sharp-have-header-files-will-the-namespace-take-care-of-everythin
 */