using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class StaticClassesDemo
    {
        static void Main()
        {
        }
    }
    //We discuss Static classes detailed in later sessions.
    //Console, Convert classes are static classes.
    static class StaticDemo5
    {
        //We can't declare normal variable/ constructor/ method. Inside a static class everything should be static only.
        static int no;
        static StaticDemo5()
        {
            //Will see later in extension methods
        }
        public static void display()
        {
            //Will see later in extension methods
        }


    }
}
