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
            Course obj1 = new Course(12000,3,"C#");//We are passing 2 ints, 1 string
            Course obj2 = new Course(12000,4,"ASP.Net");
            obj1.display();
            obj2.display();
            //Suppose we have a situation where multiple obj's taking same type of data at Constructor level, then this is not the recommended way to do.
            //We can create one more constructor which accpet the obj type parameter.
            Course obj3 = new Course(obj1);//Calls copy constructor.
            obj3.display();
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
        //Copy Constructor: It is a special type of Patrametrized constructor where we have class-type parameter in the definition. Use this type of constructor, when you want to copy one obj values to another obj at Constructor level. So that it won't affect the original Object values.Very rarely we use it.
        public Course(Course c)//Copy Constructor (Parametrized Constructor as object type).
        {
            //When we pass object while calling constructor that obj is copied into 'c'
            cduration = c.cduration;
            cname = c.cname;
            cfee = c.cfee;
        }
        public void display()
        {
            Console.WriteLine("Course Name: "+cname+"\nCourseDuration: "+cduration+"\nCourse fee: "+cfee);
        }
    }
}
