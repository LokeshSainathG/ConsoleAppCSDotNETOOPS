using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    /*Encapsulaion:
     * Bundling or Wrapping data members (var's) & Member functions (methods) together inside a class and calling data members with help of member functions is called Encapsulation. 
       The data members are often declared as private or protected i.e. restricting direct access from the class. Access to these data members is typically through public member functions, which act as interfaces to manipulate and retrieve the encapsulated data.
     *While writing a class we should maintain basic Encapsulation rule.
     */
    class PropertiesDemo
    {
        static void Main()
        {
            PropTest obj = new PropTest();
            //We access data member outside the class. But if you declare "no" as public scope, then we can. But that is against the Encapsulation rule. Default scope of class is Internal and class members is private except static constructor.
            //obj.no = 12;//Write access
            //Console.WriteLine(obj.no);//Read access
            //It will give complete scope (Read & Write) of data members to outside.
            //To access data members with out breaking Encapsulation rule: Using properties
            //Without breaking Encapsulation rule, what scope you want to give to var's that mechanism is called Properties.

            //We can able to access properties only. Those properties access var's.
            Console.WriteLine(obj.Accno);//We can't write, bcs it is Read only property.
            obj.Name = "Lokesh"; //WriteLine() not possible, bcs it is Write only propert.
            obj.Bal = 13000;
            Console.WriteLine("Balance:" + obj.Bal);
            obj.display();
        }
    }
    class PropTest
    {
        int no;
        //public int no;
        //To access data members with out breaking Encapsulation rule: Using properties
        //Without breaking Encapsulation rule, what permission you want to give to var's that mechanism is called Properties.
        int accno;//Read Access
        string name;//Write Access
        long bal;//Both Read & Write Access
        //Declaring Properties for each data member: Always property should be public.
        public int Accno//It is good practice that var's with small letters & correspoding Property name as same that of var but 1st letter as CAPITAL. [We can give different name also, for future reference give similar name]
        {
            get 
            { 
                return accno; 
            }//Read access means set accessor.
        }
        public string Name
        {
            set 
            {
                if (value.Length > 3)
                    name = value;
                else
                    Console.WriteLine("Name should be above 3 char's! ");
            }//Write access means get accessor. value is the standard keyword. Its type is automaticlly defined by property type. For "Name" property we passed a value Lokesh. that value is assigned to "name" variable.
        }
        public long Bal
        {
            get { return bal; }
            set 
            {
                if (bal == 0)
                    bal = value;
                else
                    bal = bal + value;//Deposit functionality.
            }//type of the "value" is long
        }
        //One var > one property. For another var, another property. We can't define multiple var's in one property
        //For all variables, we can have only one Indexer. That is next concept.
        //We can simplify the properties code into single line, we see in "PropertiesDemo2.cs".
        public void display()
        {
            accno = 12000;
            Console.WriteLine("Variable accno: " + Accno);
        }
    }
}
/*
//Define the Properties Accessors  
public < type > < Property Name >   //The access modifier can be Private, Public, Protected or Internal.
{  
    //The get() and set() operations of the syntax are known as accessors.
    get  {  Return  <var > ;  }  //get accessor - to get the data from a class field
    set  {  if(Is Valid(Value))  
                <var > = Value;  }  //set accessor - to set or assign the data to a class field
}  

There are 4 types of Properties:
Read-Write Property
Read-Only Property
Static Property
Indexer Property


A read-only Property has a get accessor but does not have any set() operation. This means that you can retrieve the value of a variable using the read-only property but you cannot assign a value to the variable.

A static Property can be used to access only the static members of the class.

*/