using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class LINQDemo2_XML3
    {
        static void Main()
        {
            //We are trying to get list of Student names whose marks > 800: 
            //That is we are getting IEnumerable string object: It will present in using System.Collections.Generic; namespace.
            IEnumerable<string> names = from student in XDocument.Load(@"C:\Users\HP\source\repos\ConsoleAppCSDotNETOOPS\ConsoleAppOOPS\Data.xml")
                                        .Descendants("Student")//This can be re-write as below: 
                where (int)student.Element("TotalMarks") > 800
                orderby (int)student.Element("TotalMarks") descending
                select student.Element("Name").Value;

            foreach (string name in names)
                Console.WriteLine(name);
            //Alternate way of writing the above query:
            /*Instead of writing:
             .Descendants("Student")    we can write:
             .Element("Students").Elements("Student")
            */
            IEnumerable<string> names2 = from student in XDocument.Load(@"C:\Users\HP\source\repos\ConsoleAppCSDotNETOOPS\ConsoleAppOOPS\Data.xml")
                                         .Element("Students").Elements("Student")
                        where (int)student.Element("TotalMarks") > 800
                        orderby (int)student.Element("TotalMarks") descending
                        select student.Element("Name").Value;
            foreach (string name in names2)
                Console.WriteLine(name);
            //For filtering we can make use "where" keyword.
        }
    }
}
/*Descendant: Instead of Descendant, Start from Root element <Students> and from there we want Elements (Student) 
 Ancestor x Descendant/ Successor

• Elements finds only those elements that are direct descendents, i.e. immediate children.
• Descendants finds children at any level, i.e. children, grand-children, etc
• Descendants will search the entire subtree of the current element for the specified name (or will return a flattened version of the tree if no name is provided), whereas Elements searches only the immediate children of the current element.
 */