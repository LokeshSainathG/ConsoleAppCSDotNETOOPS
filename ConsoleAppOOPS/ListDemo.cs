using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class ListDemo
    {
        /*When it comes to collections, generics make it possible to avoid boxing/unboxing by utilizing actual T[] arrays internally. List<T> for example uses a T[] array to store its contents.
         * In C#, we have pre-defined Generic classes like List<T>, Dictionary<T>, Stack<T>, Queue<T>
         */
        static void Main()
        {
            List<int> intLi = new List<int>();//List is Generic class.
            //List provides compile-time type checking and doesn't perform boxing-unboxing because it is generic.
            intLi.Add(23);
            intLi.Add(34);
            intLi.Add(45);//intLi.Add("Lokesh");//Error
            foreach (int item in intLi)
                Console.WriteLine(item);

            List<string> stringLi = new List<string>();
            stringLi.Add("Lokesh");//Based on List type, item type will decide.
            stringLi.Add("Praveen");
            stringLi.Add("Bhanu");
            foreach (string item in stringLi)
                Console.WriteLine(item);

            //If you go to def of List class, you can observer all methods defined in it are Generic methods. What ever type you are specifying in List instance creation, same type carried to its Generic methods. Also all are instance methods. We use Collections/ Generic collections by creating instance only.
            List<Dept> DeptLi = new List<Dept>();//Only Dept type of data. User-defined type.
            //Dept is class type, instance we need to pass. we can create outside or directly we can. 
            DeptLi.Add(new Dept() { Deptno=10, Dname="RnD", location="Bang"});//Dept obj we need to pass
            DeptLi.Add(new Dept() { Deptno = 20, Dname = "RnD", location = "Bang" });
            foreach (var item in DeptLi)//Or foreach (Dept item in DeptLi)
                Console.WriteLine(item.Deptno+" - "+item.Dname+" - "+item.location);
            //To hold Hetrogeneous data in Generic List, we can use user-defined types.
            //These are useful if you are fetching List of data from DB, that list of data we can store here.

            //Actually while instantiating, we are calling a Constructor can be implicit default or explicit default, purpose is to initialise the data members. We can also instantiate directly like:
            Dept d = new Dept() { Deptno = 10, Dname = "RnD", location = "Hyd" };//Same concept we used above.
        }
    }
    class Dept
    {
        //Auto properties
        public int Deptno { get; set; }
        public string Dname { get; set; }
        public string location { get; set; }
    }
}
