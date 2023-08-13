using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleAppOOPS
{
    public class Logging
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //OR
        /*
        static Logging()
        {
            Log = LogManager.GetLogger("logger");
        }*/
        static void Main()
        {
            try
            {
                Log.Info("This is start of DoWork()");
                DoWork();
                Log.Info("This is end of DoWork()");
            }
            catch(Exception e)
            {
                Console.WriteLine("App has encountered an Exception.");//User only get some Exception occured in the App. No details shown to user.
                Log.Error(e.Message);//The Exception will be logged in log file.
            }
        }
        private static void DoWork()
        {
            Console.WriteLine("This is DoWork() method.");
            throw new Exception("This is developer made exception.");
        }
    }
}
