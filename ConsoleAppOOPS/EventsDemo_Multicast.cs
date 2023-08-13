using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    delegate void Transformer(int x);
    class EventsDemo_Multicast
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int i = int.Parse(Console.ReadLine());
            Transformer t = Square;
            t += Cube;
            t.Invoke(i);
            //[Multicast Delegates concept]

            NotificationOfMethods obj = new NotificationOfMethods();
            //Hooking XHandler method with Delegate object. Since Delegate defined in another class
            obj.transformerEvent += User1.XHandler;//Using the obj, we are assigning the User1 XHandler to Delegate object.
            obj.transformerEvent += User2.YHandler;
            obj.NotifyOnCell(i);//This method inturn call the Delegate.
        }
        public static void Square(int x)
        {
            Console.WriteLine(x * x);
        }
        public static void Cube(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
    class NotificationOfMethods
    {
        public Transformer transformerEvent;//This delegate obj is responsible for Notifying Subscribers.
        public void NotifyOnCell(int x)//It will call this event.
        {
            if (transformerEvent != null)//Checking "transformerEvent" obj should be Instantiated.
            {
                transformerEvent(x);//Invoking the Event
            }
        }
    }
    //Define 2 Subscribers (Classes): These have a Notification Confirm msg method.
    class User1
    {
        public static void XHandler(int x)
        {
            Console.WriteLine("Event received by User1 obj");
        }
    }
    class User2
    {
        public static void YHandler(int x)
        {
            Console.WriteLine("Event received by User2 obj");
        }
    }
}
