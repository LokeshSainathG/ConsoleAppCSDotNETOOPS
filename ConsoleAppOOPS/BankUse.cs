using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleAppOOPS
{
    //class scope is "internal" by default, so we can use that class template where required in the project or namespace.
    //To use the Bank class in different project, first it should be public then we have to import namespace first & use
    class BankUse
    {
        static void Main()
        {
            Bank b = new Bank();
            //For each person (real time entity) we have to create object.
            //3 data members which has default scope as private.
            int accno = 0, amt=0;
            Console.WriteLine("Enter your Name to create your Account: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the initial balance to maintain: ");
            int bal = Convert.ToInt32(Console.ReadLine());
            accno = b.openaccount(name, bal);//openaccount() generate a random account number.
            if (accno > 0)
            { 
                Console.WriteLine("Account successfully created. Account number: "+accno);
                choice:
                Console.WriteLine("1. Deposit\t2.Withdraw\t3.Get Balance\t4. Display Acc Details\nEnter your choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)//Based on the choice, corresponding case gets executed.
                {
                    case 1://The value for a case must be constant. Variables are not allowed.
                        Console.WriteLine("Enter your acc no: ");
                        accno= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the amount you want to Deposit: ");
                        amt=Convert.ToInt32(Console.ReadLine());
                        b.deposit(accno, amt);
                        break;
                    case 2:
                        Console.WriteLine("Enter your acc no: ");
                        accno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the amount you want to Withdraw: ");
                        amt = Convert.ToInt32(Console.ReadLine());
                        b.withdraw(accno, amt);
                        break;
                    case 3:
                        Console.WriteLine("Enter your acc no: ");
                        accno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Current balance: "+b.getBalance(accno));
                        break;
                    case 4:
                        Console.WriteLine("Enter your acc no: ");
                        accno = Convert.ToInt32(Console.ReadLine());
                        b.display(accno);
                        break;
                    default:
                            Console.WriteLine("Invalid choice! \nPlease Enter choice again.\a"); MessageBox.Show("Select valid option");
                            goto choice;
                }
            }
            else
            {
                Console.WriteLine("Account creation failed!");
            }
            Console.WriteLine("Program Execution done. Give enter to return.");
            Console.ReadKey();//In Debug mode it won't wait for the key.
        }
    }
}
