using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class LINQDemo2_XML
    {
        /*Creating an XML doc using LINQ to XML:
         * Functional Construction: It is the ability to create an XML tree in a single statement. We can use LINQ to XML.
         * Classes that we can use to construct XML tree: All the below classes present in "System.Xml.Linq" namespace.
         * XDeclaration class: To create XML document.
         * XComment: to create an XML comment
         * XElements: To create a root element/ child elements for root element.
         * XAttribute: To create attributes for elements.
         * 
         * Some more classes:
         * XDocument: Represents an XML document.
         * XName: Represents a name of an XML element or attribute.
         * XNamespace: Represents XML Namespace. Every XName contains an XML Namespace.
         */
        static void Main()
        {
            //XDocument class has 4 overloaded Constructors. We use 2nd version which has "params" object parameter type. We can pass as many args as we want. So, we are passing all XML classes objects to this XDocument Constructor.
            XDocument xmldoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Creating an XML tree using LINQ to XML"),
                new XElement("Students",
                new XElement("Student", new XAttribute("ID", 101),
                    new XElement("Name", "Lokesh"),
                    new XElement("Gender", "Male"),
                    new XElement("TotalMarks", "900")),//Creates first Student Element.
                new XElement("Student", new XAttribute("ID", 102),
                    new XElement("Name", "Bhanu"),
                    new XElement("Gender", "Male"),
                    new XElement("TotalMarks", "950")),//Creates second Student Element.
                new XElement("Student", new XAttribute("ID", 103),
                    new XElement("Name", "Praveen"),
                    new XElement("Gender", "Male"),
                    new XElement("TotalMarks", "920")),//Creates third Student Element.
                new XElement("Student", new XAttribute("ID", 104),
                    new XElement("Name", "Kumar"),
                    new XElement("Gender", "Male"),
                    new XElement("TotalMarks", "800"))//Creates fourth Student Element.
                ));//Entire doc we created using single statement.

            //1. XML declaration has version, encoding type, standalone or not. Let's create a new XDeclaration obj.
            //2. Let's have the Comment.
            //3. Root element (Students) (XElement). Root element has Child elements, so we need to create another instance inside this. Also, the Student element has ID attribute.
            //4. Within the <Student> element we have 3 more elements. So we are not going to close <Student> Constructor.
            //To save this XML data to an XML file: Let's save it in this Proect folder.
            //XML document object has a Save() method. 
            xmldoc.Save(@"C:\Users\HP\source\repos\ConsoleAppCSDotNETOOPS\ConsoleAppOOPS\Data.xml");
            //Since '\' used for Escape sequence: We can specify Verbatim literal (@) OR double backslash (\\) to specify the Path.
            //Run --> XML doc get formed in the specified path --> To see it in Sol Exp --> Click on "Show All files" in sol explorer.
        }
    }
}


