using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class ConstructorsDemo2CopyConstru
    {
        public static void Main()
        {
            //Course obj = new Course();//If a class has only Parametrized Constructor & no overloaded default constructor, then we should pass required args to the instance just like method. There will be no concept of default constructor for that class.


            Course obj1 = new Course(12000, 4, "C#");//We are passing 2 ints, 1 string
            obj1.display();
            Course obj2 = new Course(12000, 4, "C#");
            obj2.display();
            Course obj3 = new Course(12000, 4, "C#");
            obj3.display();
            Course obj4 = new Course(12000, 4, "C#");
            obj4.display();
            //Suppose we have a situation where multiple obj's taking same type of data at Constructor level, then this is not the recommended way to do. Because if something need to be changed, everywhere we have to change. For each student in a batch, course details are same only personal details will be diff like name, phone no, Roll no.

            //Solution is, we can create a copy constructor which can accept the argument as objects means class type parameter. For first student we can pass the arguments data, later on we can pass the obj1 to next Student objects.
            //Passing object to constructor of class-type parameter.
            Course obj5 = new Course(obj1);//Calls copy constructor.
            obj5.display();
            //If obj1 values changed, then all objects which are using copy constructor will change.
            //For everyone courses are same, course duration and fee also same. Only name and phone.no are different. So by creating copy constructor we can copy one obj to another object.
        }
    }
    class Course
    {
        int cduration, cfee;
        string cname;
        public Course(int cfee, int cduration, string cname)//Parametrized Constructor
        {
            this.cduration = cduration;//"this" used to refer to the current instance of the class
            this.cfee = cfee;
            this.cname = cname;
        }
        //Copy Constructor: It is a special type of Patrametrized constructor where we have class-type as parameter in the definition. Use this type of constructor, when you want to copy one obj values to another obj at Constructor level. So that it won't affect the original Object values.Very rarely we use it.
        public Course(Course c)//Copy Constructor (Parametrized Constructor as class type which can take object as argument).
        {
            //When we pass object while calling constructor that obj is copied into 'c'
            cduration = c.cduration;
            cname = c.cname;
            cfee = c.cfee;
        }//Copy constructor reduces redundancy of data in code.
        public void display()
        {
            Console.WriteLine("Course Name: "+cname+"\nCourseDuration: "+cduration+"\nCourse fee: "+cfee);
        }
    }
}
