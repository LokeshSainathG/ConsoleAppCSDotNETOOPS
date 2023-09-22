using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    /*Encapsulaion:
     * Bundling or Wrapping up data members (var's) & member functions (methods) that operate on data together inside a block called class and calling data members with help of member functions is called Encapsulation. And outside members to the class can't access, this way we are protecting the data. 
       The data members are often declared as private or protected i.e. restricting direct access outside the class. Access to these data members is typically through public member functions, which act as interfaces to manipulate and retrieve the encapsulated data.
     *While writing a class we should maintain this basic Encapsulation rule.
     */
    
    class PropTest
    {
        int no;
        //public int no;
        //Problem is to access 'no' outside this class / Main(), we need to make it as public, but it breaks Encapsulation rule of OOPS ad we are giving complete scope to outers.

        //To access data members in class with out breaking Encapsulation rule: Solution is by using properties
        //Without breaking Encapsulation rule, what permission you want to give to var's that mechanism is called Properties.
        int accno;//need to give Read Access
        string name;//need to give Write Access
        long bal;//need to give both Read & Write Access, same as public way variable

        //Declaring Properties for each data member: Always property should be public.
        public int Accno//It is good coding practice that var's with small letters & correspoding Property name as same that of var but 1st letter as CAPITAL. [We can give different name also, for future reference give similar name] return type should be same as that of variable data type.
        { get { return accno;} } //Read access means only get accessor.

        public string Name
        {
            //set{ name = value; }
            //To add some conditions or bussiness logics to the data members like 'name' should be > 3 chars, we no need to write separate methods, in set accessors itself we can write conditions.
            set
            {
                if (value.Length > 3)//let's add some condition also
                    name = value;//'value' type is string.
                else
                    Console.WriteLine("Name should be above 3 char's! ");
            }//Write-access means only set accessor. value is the standard keyword. Its type is automaticlly defined by property type which we are specifying. For "Name" property we passed a value Lokesh in Main() tat will be captured by 'value' first then that 'value' we are assigning to actual "name" variable.
        }

        public long Bal
        {
            get { return bal; }
            //Bussiness req is if bal is 0 then assign directly, else add.
            set
            {
                if (bal == 0)
                    bal = value;
                else
                    bal = bal + value;//Deposit functionality.
            }//type of the "value" is long
        }
        //One var -> one property. For another var, another property. We can't define multiple var's in one property
        //For all variables, we can have only one Indexer. That is next concept.
        //We can simplify the properties code into single line, we see in "PropertiesDemo2.cs".
        public void display()
        {
            accno = 12000;
            Console.WriteLine("Variable accno: " + Accno);
        }
    }
    //For information hiding we use encapsulation and making class attributes inaccessible from the outside. Further we can use getter and/or setter methods for attributes to be readable or updatable by other classes. These are called properties.
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

    //Abstraction is related to both encapsulation and data hiding. [Abstraction is a process of exposing necessary functionality to external objects and hiding implementation details.] In Inheritance concept we will see.
}
/*
//Define the Properties Accessors  
public < type > < Property Name >   //The access modifier can be Private, Public, Protected or Internal.
{  
    //The get() and set() operations of the syntax are known as accessors.
    //Think about get, set from outside class point of view, then we can get terminology.
    get  {  Return  <var > ;  }  //get accessor - to get the data from a class field
    set  {  if(Is Valid(Value))  
                <var > = Value;  }  //set accessor - to set or assign the data to a class field
}  

There are 6 types of Properties:
Read-Write Property [get accessor, set accessor]
Read-Only Property [get accessor]
Write-Onlt Property [set accessor]
Static Property
Indexer Property
Auto implemented properties [no need of separate var declaration, property declaration]
        public string Name { get; set; } both read, write
        public string Name { get; }          public string Name {private get;  set; }//Without get accessor, we can't use set in auto properties

A read-only Property has a get accessor but does not have any set() operation. This means that you can retrieve the value of a variable using the read-only property but you cannot assign a value to the variable.

A static Property can be used to access only the static members of the class.
*/