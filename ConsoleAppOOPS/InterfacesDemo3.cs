using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //Explicit Interface members implementation: 
    //If two or more interfaces having same method signature, then implement the interface members in class using Explicit Interface syntax. No need to give access specifier, give Interface-name.Method-name(){}

    interface ISavingAcc { void Deposit(); }
    interface ICurrentAcc { void Deposit(); }
    //How to implement the common method in Child class? both think that it is their method
    class Banking : ISavingAcc, ICurrentAcc
    {
        void ISavingAcc.Deposit()//Explicitly we are specifying the interface method. These are not class members, these become explicit interface members (interface members only), that's why no access modifier.
        {

        }
        void ICurrentAcc.Deposit()
        {

        }
        //Access specifier is not allowed in Explicit interface method implementation.
        //means
        //public void ISavingAcc.Deposit()
        //public not allowed.
    }

    class InterfacesDemo3
    {
        static void Main()
        {
            Banking obj = new Banking();
            //We can't access any Deposit method. Bcs these are explicit interface members.
            //We have to type cast the child class obj:
            ((ISavingAcc)obj).Deposit(); 
            ((ICurrentAcc)obj).Deposit();//Type casting obj as Interface and calling the method

            //OR
            ISavingAcc obj1 = new Banking();
            ICurrentAcc obj2 = new Banking();
            obj1.Deposit();//w.k.t Interface method is Abstract type, override to child class implemented method.
            obj2.Deposit();
        }
    }
}