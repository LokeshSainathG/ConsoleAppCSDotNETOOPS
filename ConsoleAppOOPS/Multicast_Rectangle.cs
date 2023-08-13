using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    public delegate void RectDeleagte(double w, double h);//Defining 
    class Multicast_Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine(width*height);
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine(2 * (width + height));
        }
        static void Main()
        {
            Multicast_Rectangle rect = new Multicast_Rectangle();
            rect.GetArea(12.33, 18.89);
            rect.GetPerimeter(12.33, 18.89);

            //Delegate instantiating:
            RectDeleagte rd = rect.GetArea;//Directly binding method with delegate with out creating constructor. Compiler creates implicit constructor.
            rd += rect.GetPerimeter;
            //One single delegate instance call will invoke both methods.
            rd.Invoke(12.33, 18.89);
            Console.WriteLine();
            rd.Invoke(100, 56.7);

        }
        //Let's call these methods using a delegate:
        //Since signature (retun type, parameters) of both methods are similar. One deleate is enough.
    }
}
