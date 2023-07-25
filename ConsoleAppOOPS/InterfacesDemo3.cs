using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Explicit Interface: 
    //If two or more interfaces having same method signature, then implement the interface members in class using Explicit Interface syntax. No need to give access specifier, give Interface-name.Method-name(){}
    interface ISavingAcc { void Deposit(); }
    interface ICurrentAcc { void Deposit(); }
    //How to implement the method in Child class? both think that it is their method
    class Banking : ISavingAcc, ICurrentAcc
    {
        void ISavingAcc.Deposit()//Explicitly we are specifyinh the interface method.
        {

        }
        void ICurrentAcc.Deposit()
        {

        }
        //Access specifier is not allowed in Explicit interface method implementation.
    }

    class InterfacesDemo3
    {
        static void Main()
        {
            Banking obj = new Banking();
            ((ISavingAcc)obj).Deposit(); //We can't access any Deposit method. Bcs these are explicit interface members.
            ((ISavingAcc)obj).Deposit();//Type casting obj as Interface and calling the method

            //
            ISavingAcc obj1 = new Banking();
            ICurrentAcc obj2 = new Banking();
            obj1.Deposit();
            obj2.Deposit();
        }
    }
}
