using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*//The common data we can have in Accounts class to avoid Redundancy of the code. So that we can easily Maintainance the code.
Accounts
{
}
//For all kinds accounts, basic info is req.
SavingAcc{}
CurrentAcc{}
JointAcc{}


//Both Java stu, .NET stu have their own subjects. Basic info like Student name, contact, address etc., are maintained in Student class.
JStud//Java Students
{
}
NStd//.NET Students
{
}
Student{}
 */
namespace ConsoleAppOOPS
{
    abstract class Student//Can't create obj for this class. We have to create Child class obj instantiate this also.
    {
        int sno;
        string name, fname, email;
        long phone;
        //At constructor level, read the data: Always initialise data members using constructor.
        public Student(int sno, string name, string fname, string email, long phone)
        {
            this.sno = sno; this.name = name;this.fname = fname;this.email = email;this.phone = phone;
        }
        public void display()
        {
            Console.WriteLine("Sno: "+sno);
            Console.WriteLine("Sname: " + name);
            Console.WriteLine("Fname: " + fname);
            Console.WriteLine("Email: " + email) ;
            Console.WriteLine("Phone: " + phone);
        }
    }
    class JStu:Student
    {
        int corejava, advjava;
        public JStu(int sno, string name, string fname, string email, long phone, 
            int corejava, int advjava):base(sno, name, fname, email, phone)
        {
            this.corejava = corejava;
            this.advjava = advjava;
        }
        public new void display()//To hide the parent class method by re-defining same method child: Use "new"
        {
            base.display();//To call Base class members from child: Use "base"
            Console.WriteLine("Core Java Marks: " + corejava);
            Console.WriteLine("Adv Java Marks: " + advjava);
            Console.WriteLine("Total = :" + GetTotal());
        }
        private int GetTotal()
        {
            return corejava + advjava;
        }
    }
    class NStu:Student
    {
        int csharp, vb, asp;
        public NStu(int sno, string name, string fname, string email, long phone, int csharp, int vb, int asp):base(sno, name, fname, email, phone)
        {
            this.csharp = csharp;
            this.vb = vb;
            this.asp = asp;
        }
        //Method Overriding
        public new void display()//To hide the parent class method by re-defining same method child: Use "new"
        {
            base.display();//To call Base class members from child: Use "base"
            Console.WriteLine("C# Marks: " + csharp);
            Console.WriteLine("VB Marks: " + vb);
            Console.WriteLine("ASP Marks: " + asp);
            Console.WriteLine("Total = :" + GetTotal());
        }
        private int GetTotal()
        {
            return csharp + vb + asp;
        }
    }
    class InheritanceDemo4
    {
        static void Main()
        {
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
                NStu n;//Done at compilation time [Obj creation]
                n = new NStu(sno, name, fname, email, phone, csharp, vb, asp);//Done at Run time [Instantiation]
                n.display();
            }
            else if (ch == 2)
            {
                Console.WriteLine("Enter Core Java, Adv Java marks: ");
                int corejava = Convert.ToInt32(Console.ReadLine());
                int advjava = Convert.ToInt32(Console.ReadLine());
                JStu j = new JStu(sno, name, fname, email, phone, corejava, advjava);
                j.display();

            }
            else
                Console.WriteLine("Invalid choice");
            //In this Main() there is some issue. In Compilation state, 2 objs are created for this Program. Are we using these 2 obj's t Run time? No, either JStu or NStu based on choice. 
            //Compile time, it is creating 2 obj's. But at Run time, we can use one.
            //In Exception Handling also, we are not handling all 100 Exception classes. Instead we catch parent Exception class.
            try
            {
                //Set of stats;//new FormatException()
            }
            catch (Exception ex)//Exception ex = new FormatException();
            {
                //Base-class obj = derived-class reference();
                Console.WriteLine(ex.Message);//It will call FormatException class Message property. ex is Exception class obj, but reference is FormatException class. So it will call child class only.
            }
            //This is called as Run-time Polymorphism.
            //Create an obj for Base class and assign reference of derived class to the obj.
            //In this, instead of creating multiple obj's. InheritanceDemo5.cs
        }
    }
}
/*Types of Inheritences in OOPS:
There are 5 types Inheritence concepts proposed in OOPS.
1. Single: 1 Parent, 1 Child
2. Multi-Level: Multiple Levels - Grand Parent, arent, Child
3. Hierarchical: 1 Parent, multiple childrens

2 more Concepts are not supported by C#: [Java also won't support]
4. Multiple:2 Parents, 1 Children 
5. Hybrid: 1 Grand parent, 2 Parents, 1 Children (It is merging of Hierarchical, Multiple)
Hybrid (combination of Multi-level, Hierarchical) is supported by C#, Java
 * 
 */