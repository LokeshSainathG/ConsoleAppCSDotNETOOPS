using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllWindowsForms
{
    /*
    Windows Forms Projects:
    Windows Forms App (.NET Framework)
    Remaining all are different.
    Windows Forms App (.NET) VB
    Windows Forms App (.NET) C#

    How to install:
    Google > Windows Forms app framework in VS
    Go down in the available list > Install more tools and features > We will get Play loads screen > Select the ".NET Deskatop development" [Win Forms, WPF, UWP, etc.,] > Install > Restart. 

    Project Structure:
    Properties > Project Properties > Like console, Forms also have Properties. If you extract, you will see assembly info.
    References > Like Console app, some references req by default those are added automatically and we can also add explicitly. ///y, for Windows Forms app, what and all References req those list available here. Right click > Add Reference
    App.config: Application configuration file which maintains global data.

    Program.cs > Default program. Main() method is availble only once in entire Forms proj. That's why we can call Windows Forms Main() program as  "Single Threaded application [STAThread]"
      The STAThreadAttribute is essentially a requirement for the Windows message pump to communicate with COM components. Although core Windows Forms does not use COM, many components of the OS such as system dialogs do use this technology


    */
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Button > ButtonBase > Control
            //Text > TextBase > Control
            //Control is the Grand parent of all these.
            Application.EnableVisualStyles(); //For my app, I am ENABLING VISUAL STYLES
            Application.SetCompatibleTextRenderingDefault(false); //For my app, Rendering Default is set to FALSE.
            Application.Run(new AnonymousMethod_Form()); //[IMP] When you running program or clicking START, which app need to run that info specified here.
            //Here we are creating an instance. Somewhere Form1 class is available in the Project and we are creating instance. So, it calls the Defult Constructor.
            //We can observe Form1.cs available in the Solution.
            /*Form1 is class file. Which is divided into 3 parts:
             Suppose we want to write 1 class code in multiple areas, we have to divide class physically but not logically, we use a concept called "PARTIAL".
            If you expand any .cs file you can see the classes, under that Data members, member functions.
            Expand Form1.cs > Form1.Designer.cs, Form1.resx
            Form1.cs contain UI part.
            Form1.Designer.cs code written in multiple areas. It contains UI controls related designer code. The code generated automatically when change the controls in Form1.cs
            Form1.resx (Resources file): It shows Resource (strings, audio& video files) related info. VS Designer uses it. f you delete also, VS will recreate it. It usually contain localization strings for easier globalization and localization. But when you have ActiveX on the form, the resource also stores the ActiveX's state data.

            Form1.cs > Double click on the Form > the background Form1.cs code will open.
            We can see Form1 class is defined as "PARTIAL"
            public partial class Form1 : Form
            It means this class is implemented in some other place (Form1.Designer.cs > partial class Form1)
            Form1 is defined as PARTIAL and implemented in multiple areas to make things more understandable like Designer code at one place, Development code at one place.
            Same we can apply in our Console development also. We can place Data Members, Constructors in one file, Specific methods in one file and rest all methods in one file. File names are diff, class names are same with partial. Physically at different places but logically all are connected as one class. No change in obj creation and accessing.

            We are calling Form1() constructor, call goes to Form1.cs class which has a default constructor. It is calling InitialiseComponent() method in partial Form1 class of Form1.Designer.cs file. Which draw and designs whole UI and OUTPUT will come.  
            We cover OOPS, Reflections, Collections concepts in Windows Prog.
            */
        }
    }
}
