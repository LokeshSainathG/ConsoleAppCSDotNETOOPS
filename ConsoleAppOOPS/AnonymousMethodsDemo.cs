using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class AnonymousMethodsDemo
    {
        //Class inside class is nested class which improves Encapsulation.
        public class EmployeeNew //Since we already used "Employee" class, let's use EmployeeNew

        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        static void Main()
        {
            List<EmployeeNew> listEmployees = new List<EmployeeNew>()//We have a List pf Objects, with 3 Employees. We have to find the EMP whose ID is 102. To do this we have "Find()". [go to def of Find() > Def of Predicate > ] It expects Predicate of EMP. Predicate<T> is actually a Delegate.
              //public delegate bool Predicate<in T>(T obj);
            {
                new EmployeeNew{ ID=101, Name = "Mark"},
                new EmployeeNew{ ID=102, Name = "John"},
                new EmployeeNew{ ID=103, Name = "Mary"},
            };
            //Step-2: Creating an instance of Delegate which points to the FindEMP().
            Predicate<EmployeeNew> empPredicate = new Predicate<EmployeeNew>(FindEMP);
            //Step-3: We passed the delegate instance as a parameter to pre-defined Find().
            //To the constructor of Delegate we need to pass name of the function.
            EmployeeNew employee = listEmployees.Find(emp => FindEMP(emp));//Pass the delegate to Find(). We are going to pass each EMP obj to this method. "emp" is obj here.
            //Find() method return employee obj, so store it in an object of that class type.
            Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);
            //Same Step-1,2,3 using Anonymous function:
            
            EmployeeNew employee2 = listEmployees.Find(delegate (EmployeeNew emp)
            {
                return emp.ID == 102;
            });
            Console.WriteLine("ID = {0}, Name = {1}", employee2.ID, employee2.Name);
        }
        //Step-1
        public static bool FindEMP(EmployeeNew e)
        {
            //req is to Find an EMP with ID 102:
            return e.ID == 102;// This Expression return T/ F
        }//Let's create an instance of predicate delecate
    }
        
}
/*Anonymous method is a method without name. It provides a way of creating delegate instances without having to write a separate method.
*/
/*Delegates:
Delegates are nothing but function pointers. They point a function. In order to point a delegate to a function. In order for a Delegate to point to a function: We create an instance of a Delegate to its Constructor and pass the name of the function. 
First we need to create a functon that we want the delegate point to. IMP point is what should be the signature of that method? The signature of that method should match with the signature of the delegate. That's why delegates are called as Type safe function pointers. 
//public delegate bool Predicate<in T>(T obj);
Step-1: Let's write method with bool as return type as 'bool': FindEmployee() and pass Employee class obj as parameter.
Step-2: After that create an instance of a delecate (predicate) that delegate points to that method.
Step-3: After that pass the delegate instance as an argument to pre-defined Find() method which expecting Predicate (delegate) as an argument.

Instead of these many Steps, we can write in one line using an Anonymous method:
How we made use of Anonymous method: Find(emp => FindEMP(emp))
Instead of creating an instance for Delegate, We can do this directly by using "delegate" keyword and Anonymous function which return Employee obj with property ID directly.
We create Anonymous methods using "delegate" keyword.
delegate (EmployeeNew emp) 
{
    return emp.ID == 102;
}
It is an Anonymous function which has only body, no name

*/
/*In real time, we get Employee data from a Database/ XML/ txt file. e can use LINQ and do.
*/

//https://www.youtube.com/watch?v=4trl43Ycksg