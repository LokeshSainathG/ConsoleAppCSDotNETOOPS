using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    /*Banking Transactions:
    Acc no
    Name
    Balance

    Fuctionalaities
    Deposit
    Withdraw 
    Get data

    We can do same activities by connecting DB efficiently. 
    For now let's create 2 classes - Main class, Bank Class.
    */
    class Bank
    {
        int accno;
        string name;
        long balance;

        public int openaccount(string name, long amt)//First we have an account. For that we should provide details & minimal amount. We have generate and return acc no. So, return type should be int.
        {
            this.name = name;
            balance = amt;
            //To genarate acc no: Bank follows some rules like they use branch code, IFSC number and last 4 are user identification number.
            //Here we use "Random" pre-deifned class to generate that acc no.

            Random rad = new Random();
            accno=rad.Next(1000,5000);//3 overloaded versions are there. We use (min, max). It generate a random number b/w (1000, 5000)

            //In real time projs we might have many parameters like 30/ 40 parameters. In those situations mostly they use class data members & parameters as same names. 
            //But we have one problem with that. First priority is Parameter scope. To differentiate: We use "this" keyword to specify that as a class variable.
            //Note: Inside a class if you see "this" (for a variable/ method) it represent current class member.
            //If you give "this" unnecessaly (when class var is only one having that name), compiler won't show error. But "this" will greyed out.
            return accno;
        }
        public void deposit(int accno, int amt)
        {
            if (accno == this.accno)
                balance = balance + amt;
            else
                Console.WriteLine("Invalid acc no! ");
            Console.WriteLine("Current balance: " + getBalance(accno));
        }
        internal void withdraw(int accno, int amt)//Identity, amount want to withdraw
        {
            //We have to validate the details using accno. Verify the withdraw amount is available in acc or not.
            if (accno == this.accno)
            {
                if (balance - amt > 0)
                    balance = balance - amt;
                else
                    Console.WriteLine("Insufficient balance! ");
            }
            else
                Console.WriteLine("Invalid acc no! ");
            Console.WriteLine("Current balance: " + getBalance(accno));
        }

        public long getBalance(int accno)//To fetch the balance, we need to give details like accno
        {
            if (accno == this.accno)
                return balance;
            else
            { 
                Console.WriteLine("Invalid acc no! ");
                return 0;
            }

        }

        public void display(int accno)
        {
            if (accno == this.accno)
                Console.WriteLine("Account no: {0}\nName: {1}\nBalance: {2}",accno, name, balance);
            else
                Console.WriteLine("Invalid acc no! ");
        }
    }
}
