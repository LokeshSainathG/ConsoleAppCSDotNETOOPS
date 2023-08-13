using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class LambdaExpressions_Demo
    {
        public class EmployeeNew //Since we already used "Employee" class, let's use EmployeeNew
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        static void Main()
        {
            List<EmployeeNew> listEmployees = new List<EmployeeNew>()
            {
                new EmployeeNew{ ID=101, Name = "Mark"},
                new EmployeeNew{ ID=102, Name = "John"},
                new EmployeeNew{ ID=103, Name = "Mary"},
            };
            EmployeeNew employee = listEmployees.Find(x => x.ID == 102);//Emp is EmployeeNew class type automatically. 'x' is i/p parameter name. x.ID==102 is expression.
            Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);



            //Another example:
            Func<int, int> square = x => x * x;//Func is built-in delegate.
            Console.WriteLine(square(2));//Func delegate can include 0 to 16 i/p parameters of diff types which must include OUT parameter. In above delegate: first int is i/p parameter, last int is OUT parameter. Always last parameter is OUT parameter.
            //Func, Action, Predicate are Built-int delegates.

            //Func with an Anonymous Method:
            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());

            //Func with lambda expression:
            Func<int> getRandomNumber1 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber1());
            //Or
            Func<int, int, int> Sum = (x, y) => x + y;
            Console.WriteLine(Sum(1, 2));
            //https://www.tutorialsteacher.com/csharp/csharp-func-delegate


            //Let's find no.of Employees whose name starts with letter 'M': In this case Count() which returns integer.
            int count = listEmployees.Count(x=>x.Name.StartsWith("M"));//2 overloads, second one expecting a Func Predicate. we use Lambda Expression.
            Console.WriteLine("Number of EMP whose Name starts with 'M':"+count);
        }
    }
}
/*Lambda expressions in C# are used to create anonymous functions:
Lambda operator (=>) is used in all lambda expressions and it is divided into 2 parts: LHS to => & RHS to =>.
λ Expressions are of two types:
1. Expression Lambda: Consists of the input and the expression. [input-parameters => expression;]
2. Statement Lambda: Consists of the input and a set of statements to be executed. 
[input-parameters => 
{ 
    sequence of statements 
};]
*/
