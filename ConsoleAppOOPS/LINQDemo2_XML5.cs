using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppOOPS
{
    class LINQDemo2_XML5
    {
        static void Main()
        {
            var xml = @"<A>
            <X>
            <B  id=""ABC"">
            <C name=""A"" />
            <C name=""B"" />
            <C name=""C"" />
            <C name=""G"" />
            </B>
            <B id=""ZYZ"">
            <C name=""A"" />
            <C name=""B"" />
            <C name=""C"" />
            <C name=""D"" />
            </B>
            </X>
            </A>";
            var doc = XDocument.Parse(xml);

            var newDoc = new XElement("Result", doc.Root.Element("X").Elements());//Adding new element: Result is the Name, another parameter is the Value.
            Console.WriteLine(newDoc.ToString());

            var result = new XElement("Result", doc.Descendants("B"));//Starting all B nodes.
            Console.WriteLine(result.ToString());
        }
    }
}
