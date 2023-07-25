using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class LINQDemo2_XML2
    {
        static void Main()
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Creating an XML Tree using LINQ to XML"),
                new XElement("Students",//Root element. Code is same still here in Example-1.
                    //LINQ query:
                    from student in XStudent.GetAllStudents()//GetAllStudents method gives Array of Student objects, that we capture in "student" variable.
                    select new XElement("Student", new XAttribute("Id", student.Id),//We get student ID from student obj, Id property.
                                new XElement("Name", student.Name),
                                new XElement("Gender", student.Gender),
                                new XElement("TotalMarks", student.TotalMarks))
                            ));
            //This LINQ query take each student object and then cretes <Student> element under <Students> root element.
            xmlDocument.Save(@"C:\Demo\Demo\Data.xml");
        }
    }

    public class XStudent
    {
        //XStudent class has 4 Properties and GetAllStudents() method which returns array XStudent class objects.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int TotalMarks { get; set; }
        public static XStudent[] GetAllStudents()
        {
            XStudent[] students = new XStudent[4];//To store 4 Student objects.

            students[0] = new XStudent { Id = 101, Name = "Mark", Gender = "Male", TotalMarks= 800 };
            students[1] = new XStudent { Id = 102, Name = "Rosy", Gender = "Female",TotalMarks= 900 };
            students[2] = new XStudent { Id = 103, Name = "Pam", Gender = "Female", TotalMarks= 850 };
            students[3] = new XStudent {Id = 104, Name = "John", Gender = "Male", TotalMarks = 950};
            return students;//Finally returning the Student array of Student class objects.
        }
    }
    //In real applications, we have ADO.NET/ LINQ to SQL/ Entity Framework or some set of Data Access code here to retrieve the data from DB. To keep things simple, we hardcoded students data within this method.
}
