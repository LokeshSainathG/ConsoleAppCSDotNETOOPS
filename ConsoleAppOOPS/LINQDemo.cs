using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
 /*
 LINQ: Language Intefrated Query. It is a new Query language designed by MS in .NET framework 3.5. It is similar to SQL. Before LINQ, if you want to search data from Arrays/ Collections it is very complex process. Since SQL simplefies the retrival of data from Relational DB table with simple queries instead of complex logic. Similarly, LINQ simplifies writing simple logic for appliccation development.

 LINQ in C# is used to work with data access from variety of Data sources like Arrays, collections, objects, Data sets, SQL Server (DB Tables), and XML data. LINQ is a data querying API with SQL like query syntaxes. LINQ provides functions to query cached data from all kinds of data sources. The data source could be a collection of objects, database or XML files. We can easily retrieve data from any object that implements the IEnumerable<T> interface.
LINQ offers an object-based, language-integrated way to query over data. Through LINQ we can query database, XML as well as collections. 



LINQ to Object:
LINQ to Object provides functionality to query in-memory objects and collections. Any class that implements the IEnumerable<T> interface (in the System.Collections.Generic namespace) can be queried with SQO.
 
LINQ to ADO.NET:
LINQ to ADO.NET deals with data from external sources, basically anything ADO.NET can connect to. Any class that implements IEnumerable<T> or IQueryable<T> (in the System.Query namespace) can be queried with SQO.  
• LINQ to SQL (DLinq) {Queries performed against the relation database only Microsoft SQL Server Supported} 
• LINQ to DataSet {Supports queries by using ADO.NET data sets and data tables} 
• LINQ to Entities 

LINQ to XML (XLinq):
LINQ to XML is used to query XML data sources.
*/

 //For Array, if you want to retrieve data which is >40 and store in another array in Ascending order: With normal syntax, we need to write loop to get size of new array where no.of elements that are >40 in original-arrray. Declare array. Write a loop to store elements that are >40. Use Array.sort() method. This much of logic.
 //SQL query on normal Relational Tables: To retrieve data from table which >40. We can write simple queries.
 /*SELECT <col-list> FROM <table1> [AS <alias>] [<clauses>]
  * Clauses in SQL (4): WHERE, GROUP BY, HAVING, ORDER BY.
  * If you are using clauses, sequence is very imp. W > G > H > O
  * Clauses are always optional.
  * These queries can be applied to Relational DB tables.
  */
 /* Similarly, we have LINQ Query statements that can be write upon Array/ Collections:
  * from <alias> in <Collection | Array> [<Clauses>] SELECT <alias>
  * It is very much similar to SQL query. Keywords are different. In SQL query starts with SELECT, here in LINQ, query ends with "select"
  */
    class LINQDemo
    {
        static void Main()
        {
            int[] arr = { 12, 45, 23, 89, 120, 78, 99, 87, 56, 45, 100 };

            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] > 40)
                    count++;
            }
            int[] brr = new int[count];
            int index = 0;
            for(int i=0; i<arr.Length;i++)
            {
                if (arr[i] > 40)
                {
                    brr[index] = arr[i];
                    index++;
                }
            }
            Array.Sort(brr);//Ascending order
            foreach (var item in brr)
                Console.Write(item + "  - ");
            Console.WriteLine();
            Array.Reverse(brr);//Descending order
                        //OR

            var brr1 = from i in arr select i; //i - alias
            //We have to capture the o/p of query.
            //var is implicitly typed local variable. It can't be global/ class variable.

            var brr2 = from i in arr where i > 40 select i;//to get all values >40
            var brr3 = from i in arr where i > 40 orderby i select i;//to get all values >40 in sorted Ascending order
            var brr4 = from i in arr where i > 40 orderby i descending select i;
            foreach (var item in brr3)
                Console.Write(item + "  - ");

            //LINQ with List of numbers
            List<int> num = new List<int> { 1, 2, 3 };
            //to retrieve numbers that are >1: We can use normal approach using for/ foreach loop. other using LINQ syntax:
            var filteredNos = from n in num where n > 1 select n;
            
            //Difference b/w First & FirstOrDefault methods in LINQ:

        }
    }
    /*      SQL                    LINQ
     *No Case sensitive        Case sensitive
     *ORDER BY                  orderby
     *DESC                      descending
     *
     */
}
