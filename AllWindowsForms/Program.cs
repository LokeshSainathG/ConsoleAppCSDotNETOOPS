using System;
using System.Windows.Forms;

namespace AllWindowsForms
{
    /*
    Windows Forms Projects:
    Windows Forms App (.NET Framework)
    Remaining all are different.
    Windows Forms App (.NET) VB
    Windows Forms App (.NET) C#

    How to install if it is not available:
    Google > Windows Forms app framework in VS
    In Add a new Project window > Go down in the available list > "Install more tools and features" > We will get Work loads screen > Select the ".NET Deskatop development" [Win Forms, WPF, UWP, etc.,] > Install > Restart.
    This we can do by using "Visual Studio Installer" app.

    Windows Forms Project Structure:
    Properties > Project Properties > Like console, Forms also have Properties. If you extract, you will see assembly info.
    References > Like Console app, some references req by default those are added automatically and we can also add explicitly. ///y, for Windows Forms app, what and all References req those list available here. to add a ref: Right click > Add Reference
    App.config: Application configuration file which maintains global data.

    Program.cs > Default program. Main() method is availble only once in entire Forms proj. That's why we can call Windows Forms Main() program as  "Single Threaded application [STAThread]"
      The STAThreadAttribute is essentially a requirement for the Windows message pump to communicate with COM components. Although core Windows Forms does not use COM, many components of the OS such as system dialogs do use this technology.
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
            Application.EnableVisualStyles(); //For my app, we are ENABLING VISUAL STYLES
            Application.SetCompatibleTextRenderingDefault(false); //For my app, Rendering Default is set to FALSE.
            Application.Run(new Assignment2()); //[IMP] When you running program or clicking START, which app need to run that info specified here.
            //Here we are creating an instance. Somewhere Form1 class is available in the Project and we are creating instance. Inside Form1, it calls the Default Constructor. Form1 should present in same proj.
            //We can observe Form1.cs available in the Solution.

            /*Form1.cs is a class file. Which is divided into 3 parts:
             Suppose we want to write 1 class code in multiple areas, we have to divide class physically but not logically, we use a concept called "PARTIAL".
            If you expand any .cs file you can see the classes, under that Data members, member functions.
            Expand Form1.cs > Form1.Designer.cs, Form1.resx [all are Form1 only] 
            
            Form1.cs contain UI part. Form1.cs [Design] contain code behind Form1.cs file.
            Form1.Designer.cs code written in multiple areas. It contains UI controls related designer code. The code get generated automatically when we change the controls in Form1.cs
            Form1.resx (Resources file): It shows Resource (strings, audio& video files) related info. VS Designer uses it. If you delete also, VS will recreate it. It usually contain localization strings for easier globalization and localization. But when you have ActiveX on the form, the resource also stores the ActiveX's state data.

            Form1.cs > Double click on the Form > the background Form1.cs code will open.
            We can see Form1 class is defined as "PARTIAL"
            public partial class Form1 : Form
            It means this class is implemented in some other place (Form1.Designer.cs > partial class Form1)
            Form1 is defined as PARTIAL and implemented in multiple areas to make things more understandable like Designer code at one place, Development code at one place.
            Same we can apply in our Console development also. We can place Data Members, Constructors in one file, Specific methods in one file and rest all methods in one file. File names are diff, but class names are same defined with partial. We can add three class with different file names > after adding we can make class names same and defined with "partial". Physically at different places but logically all are connected as one class. No change in obj creation and accessing.

            We are calling Form1() constructor in Main() using Application.Run(), call goes to Form1.cs class (code behind file) because it has the default constructor. In Constructor we are calling InitialiseComponent() method. But it is in the code behind file. It is defined in partial Form1 class of Form1.Designer.cs file. Which draw and designs whole UI and OUTPUT will come.
            To understand place breakpoints at [Main(), Form1 constructor where InitializeComponent() calling]
            Run > Call comes first to Main() > Run(new Form1()) > InitializeComponent() > Here actual code. How Form should display, what controls to be placed on Form, logic.
            We cover OOPS, Reflections, Collections concepts in Windows Prog.
            */
        }
    }
}
