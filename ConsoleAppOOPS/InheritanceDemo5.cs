using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    abstract class Student1//Can't Instantiate this class. We have create Child class obj instantiate this also.
    {
        int sno;
        string name, fname, email;
        long phone;
        //At constructor level, read the data: Always initialise data members using constructor.
        public Student1(int sno, string name, string fname, string email, long phone)
        {
            this.sno = sno; this.name = name; this.fname = fname; this.email = email; this.phone = phone;
        }
        public virtual void display()
        {
            Console.WriteLine("Sno: " + sno);
            Console.WriteLine("Sname: " + name);
            Console.WriteLine("Fname: " + fname);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone: " + phone);
        }
        public abstract int GetTotal();//Abstrat/ dummy method.
        //Class which has abstract method, should be an abstract. Abstract class can be combination of abstract members & normal members.

        /*virual vs abstract:
        Virtual method must have override method in Derived class. 
        Abstract method don't have implementation and forces child class to override.
        Abstract methods, virtual methods always declared with "public" specifier.
        virtual members can override in child.
        absract members should override in child.
        */
    }
    class JStu1 : Student1
    {
        int corejava, advjava;
        public JStu1(int sno, string name, string fname, string email, long phone, int corejava, int advjava) : base(sno, name, fname, email, phone)
        {
            this.corejava = corejava;
            this.advjava = advjava;
        }
        public override void display()//To hide the parent class method by re-defining same method child: Use "new"
        {
            base.display();//To call Base class members from child: Use "base"
            Console.WriteLine("Core Java Marks: " + corejava);
            Console.WriteLine("Adv Java Marks: " + advjava);
            
        }
        public override int GetTotal()
        {
            return corejava + advjava;
        }
    }
    class NStu1 : Student1
    {
        int csharp, vb, asp;
        public NStu1(int sno, string name, string fname, string email, long phone, int csharp, int vb, int asp) : base(sno, name, fname, email, phone)
        {
            this.csharp = csharp;
            this.vb = vb;
            this.asp = asp;
        }
        public override void display()//To hide the parent class method by re-defining same method child: Use "new"
        {
            base.display();//To call Base class members from child: Use "base"
            Console.WriteLine("C# Marks: " + csharp);
            Console.WriteLine("VB Marks: " + vb);
            Console.WriteLine("ASP Marks: " + asp);

        }
        public override int GetTotal()
        {
            return csharp + vb + asp;
        }
    }
    class InheritanceDemo5
    {
        static void Main()
        {
            Student1 s;//Crete obj for Parent class
            Console.WriteLine("Enter Student no, Student name, Father name, EMail, phoneno");
            int sno = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            string fname = Console.ReadLine();
            string email = Console.ReadLine();
            long phone = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("1. .NET\n2. Java\nWhich course you are in:");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("Enter .NET, VB, ASP.NET marks: ");
                int csharp = Convert.ToInt32(Console.ReadLine());
                int vb = Convert.ToInt32(Console.ReadLine());
                int asp = Convert.ToInt32(Console.ReadLine());
                s = new NStu1(sno, name, fname, email, phone, csharp, vb, asp);//Give reference to Paret class Obj. Done at Run time [Instantiation]
                //At Comiple time, s obj created, it will check display() is present in Student class or not.
                s.display();//Since 's' is Student class obj, it will call Student class display() method. To avoid this, declare Parent class Override method with "virual" & Derived classes Override method  as "override".
                //If you are calling, overrided method with Base class obj, since it is declared as virtual, it redirected to overrided method in derived class.
                //In OddNoException.cs also we are doing same. Message property is declared as "virual" in Exception class. So, we can reuse it in our child classes. We override the Message property of Exception class.
                Console.WriteLine("Total = :" + s.GetTotal());//Throwing Error, Student1 doesn't contain definition for GetTotal().
                //To resolve error, define GetTotal() in Base class as "abstract".
                //Abstract methods are the methods which don't have body.
            }
            else if (ch == 2)
            {
                Console.WriteLine("Enter Core Java, Adv Java marks: ");
                int corejava = Convert.ToInt32(Console.ReadLine());
                int advjava = Convert.ToInt32(Console.ReadLine());
                s = new JStu1(sno, name, fname, email, phone, corejava, advjava);
                s.display();
                Console.WriteLine("Total = :" + s.GetTotal());
            }
            else
                Console.WriteLine("Invalid choice");
            //In Run-time Polymorphism, base class & Derived class having same method signature. Base class method should declare as "virtual" & Derived class method should declare as "override".
        }
    }
}
/*To ways to deal with Method overriding:
 * Declare overrided method as "new" in child class& create obj's for child classes and call the child class method. TO call Base class method from child: Use "base.<Met>();"
 * Declare Base class method as "virtual", overrided methods in child class as "override"& create obj for Parent class and instantiate with child class ref, call child class method.
 */

