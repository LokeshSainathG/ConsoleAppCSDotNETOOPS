using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class StaticDemo4
    {
        public StaticDemo4() { Console.WriteLine("Control is inside instance constructor"); }
        public void display() { Console.WriteLine("Control is inside instance display() method"); }

        static StaticDemo4() { Console.WriteLine("Control is inside static constructor"); }
        public static void show() { Console.WriteLine("Control is inside static show() method"); }

    }
    class StaticMethods
    {
        static void Main()
        {
            StaticDemo4 obj = new StaticDemo4();
            obj.display();
            //OUTPUT:
            /*
             Control is inside Static Constructor
             Control is inside Instance Constructor
             Control is inside instance display() method
            */
            //To call show(), obj is not req. Using class name we can call. Class having static method is called Static class. 
            StaticDemo4.show();
            //Static constructors automatically executed by CLR. 
            //To call static method instant creation is not req. By using class name we can call.
            //Same static show() can present in another class. With respective class name we can call our required static method.
            //If we remember we are calling so many pre-defined static methods with their respective class names. Console.Write(), Console.Read(), Convert.ToINT32(),... All these are static members.
        }
    }
}
/*
 * Real time example of static members:
 * We use BookmyShow to book movie tickets
 * If 4 people log-in to the website currently. 4 people means 4 obj's in OOP. After session data is stored in backend server/ DB. If incase all seats are instance var's, then each obj have a separate copy. customer name, gender, address, DOB and other personal details should be instance var;s so that each person (object) can have separate memory.
 * For consistency in seating of the hall, the seats are static members, so that all objects (customers) can access uniquely. Otherwise if it is declared as instance var, same seat can be booked by multiple people.
 * If obj1 selected 2 seats upper right corner seat and adjacent seat to that, those will be greyed so that other people can see. Once transaction done it will change to Red/ Green based on Gender. If the person cancelled, then it become normal as available seat.
 * Same applies to Travel apps (Red bus, IRCTC, State RTC)
 * In case E-commerce apps like Amazon, Mytra, Flipkart. If laptop is ordered, only count is decreased, because in the warehouse there are multiple laptops. So, it is instance variable.
 */