using log4net;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    public static class Logger//Static CLass
    {
        private static readonly ILog log;//Static object
        static Logger()//Static Constructor
        {
            log = LogManager.GetLogger("logger");

        }

        ///////////////// Static methods: /////////////////

        public static void configureLogFileName(string fileNamePath)
        {
            GlobalContext.Properties["LogFileName"] = fileNamePath;
            log4net.Config.XmlConfigurator.Configure();
        }
        //Debug(), Info(), Warn(), Error(), Fatal():
        //https://stackoverflow.com/questions/2031163/when-to-use-the-different-log-levels

        public static void Debug(string msg, [CallerMemberName] string MemberName = "", [CallerLineNumber] int SourceLineNumber = 0)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            log.Debug(assembly + "." + MemberName + " [Line: " + SourceLineNumber + "] - " + msg);
        }
        public static void Debug(string msg, Exception ex, [CallerMemberName] string MemberName = "", [CallerLineNumber] int SourceLineNumber = 0)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            log.Debug(assembly + "." + MemberName + " [Line: " + SourceLineNumber + "] - " + msg, ex);
        }
        public static void Info(string msg, [CallerMemberName] string MemberName = "", [CallerLineNumber] int SourceLineNumber = 0)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            log.Info(assembly + "." + MemberName + " [Line: " + SourceLineNumber + "] - " + msg);
        }
        public static void Info(string msg, Exception ex, [CallerMemberName] string MemberName = "", [CallerLineNumber] int SourceLineNumber = 0)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            log.Info(assembly + "." + MemberName + " [Line: " + SourceLineNumber + "] - " + msg, ex);
        }
        public static void Warn(string msg, [CallerMemberName] string MemberName = "", [CallerLineNumber] int SourceLineNumber = 0)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            log.Warn(assembly + "." + MemberName + " [Line: " + SourceLineNumber + "] - " + msg);
        }
        public static void Warn(string msg, Exception ex, [CallerMemberName] string MemberName = "", [CallerLineNumber] int SourceLineNumber = 0)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            log.Warn(assembly + "." + MemberName + " [Line: " + SourceLineNumber + "] - " + msg, ex);
        }
        public static void Error(string msg, [CallerMemberName] string MemberName = "", [CallerLineNumber] int SourceLineNumber = 0)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            log.Error(assembly + "." + MemberName + " [Line: " + SourceLineNumber + "] - " + msg);
        }
        public static void Error(string msg, Exception ex, [CallerMemberName] string MemberName = "", [CallerLineNumber] int SourceLineNumber = 0)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            log.Error(assembly + "." + MemberName + " [Line: " + SourceLineNumber + "] - " + msg, ex);
        }
        public static void Fatal(string msg, [CallerMemberName] string MemberName = "", [CallerLineNumber] int SourceLineNumber = 0)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            log.Fatal(assembly + "." + MemberName + " [Line: " + SourceLineNumber + "] - " + msg);
        }
        public static void Fatal(string msg, Exception ex, [CallerMemberName] string MemberName = "", [CallerLineNumber] int SourceLineNumber = 0)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            log.Fatal(assembly + "." + MemberName + " [Line: " + SourceLineNumber + "] - " + msg, ex);
        }
    }
}