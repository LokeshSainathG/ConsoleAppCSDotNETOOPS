using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //OddNoException is became as children of Exception class. Inheritance concept. 
    class OddNoException : Exception //In the Exception class except private members all other members can be accessible by the OddNoException class. Exception class has constructors, parametrized constructors, properties with various accessor types, some are virtual properties. Among all we need to override virtual property called Message in child class - public virtual string Message { get; } 
    {
        //"virtual" members in base class should be override in child class if you want to reuse.
        //The "override" keyword is used to extend or modify a virtual/abstract method, property, indexer, or event of base class into a derived class.
        public override string Message 
        { 
            get
            {
                return "Denominator should be Even number only.";
            }
        }//Now go to ExceptionHandlingDemo2.cs
        //Other virtual Members and members we can provide for Exception Handling:
        //Source - in which project causes the error
        //StackTrace - It show details, from which line the Exception message is showing all details.
        //HelpLink - to provide any Help Link if user got any Exception.
        //InnerException - More in-detailed Exception message
        //We can provide all these details if required when Exception raised. All these we can' do with "ApplicationException" type of Exceptions.
    }
}
