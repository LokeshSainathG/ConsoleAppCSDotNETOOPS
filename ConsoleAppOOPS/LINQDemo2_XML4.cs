using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class LINQDemo2_XML4
    {
        static void Main()
        {
            //Get the path of the XML document.
            string path = @"C:\Users\HP\source\repos\ConsoleAppCSDotNETOOPS\ConsoleAppOOPS\Data.xml";
            
            XDocument xmlDocument = XDocument.Load(path);
            //• Inserting or adding new xml elements to the xml document: The following code adds the student element at the end of the xml document.
            xmlDocument.Element("Students").Add(
                    new XElement("Student", new XAttribute("Id", 105),
                        new XElement("Name", "Todd"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", 980)
                        ));
            xmlDocument.Save(path);
            //• To add the xml element as the first element use AddFirst() method in above case.


            //• To add the xml element in a specific location in the XML Document, use AddBeforeSelf() or AddAfterSelf()
            /*xmlDocument.Element("Students")
                .Elements("Student")
                .Where(x => x.Attribute("Id").Value == "103").FirstOrDefault()
                .AddBeforeSelf(
                    new XElement("Student", new XAttribute("Id", 106),
                        new XElement("Name", "Todd"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", 980)));*/
            /*Elements() will return IEnumerable of XElement list*/
            //• To disable formatting the XML document use SaveOptions.DisableFormatting
            //xmlDocument.Save(path, SaveOptions.DisableFormatting);



            //• Updating xml element in the xml document:
            //The following code updates student(with Id = 101) TotalMarks to 999
            /*
            xmlDocument.Element("Students")
                                    .Elements("Student")
                                    .Where(x => x.Attribute("Id").Value == "101").FirstOrDefault()
                                    .SetElementValue("TotalMarks", 999);
            xmlDocument.Save(path);*/
            //OR

            xmlDocument.Element("Students")
                .Elements("Student")
                .Where(x => x.Attribute("Id").Value == "101")
                .Select(x => x.Element("TotalMarks")).FirstOrDefault().SetValue(999);
            xmlDocument.Save(path);
            /*
            //• Updating xml comment in the xml document:
            xmlDocument.Nodes().OfType<XComment>().FirstOrDefault().Value = "Comment Updated";
            xmlDocument.Save(path);

            //• Deleting xml elements from the xml document
            xmlDocument.Root.Elements().Where(x => x.Attribute("Id").Value == "106").Remove();
            xmlDocument.Save(path);

            //The following code removes all "Student" elements that are present under root node "Students"
            xmlDocument.Root.Elements().Remove();
            xmlDocument.Save(path);
            //• Deleting xml comments from the xml document
            xmlDocument.Nodes().OfType<XComment>().Remove();
            */
        }
    }
}
