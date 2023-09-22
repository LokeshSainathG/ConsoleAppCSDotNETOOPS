using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleAppOOPS;//we are importing another project


namespace AnotherConsoleApp
{
    //go through InheritanceDemo1.cs
    class Third : First
    {
        public void Demo()
        {
            Method1();
            //Method2();//Private members can't access in derived classes also
            //Method3();//internal
            Method4();
            //Method5();//private protected
            Method6();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            First obj = new First();
            obj.Method1();
        }
    }
}
