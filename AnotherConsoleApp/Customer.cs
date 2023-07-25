using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherConsoleApp
{
    class Customer
    {
        int cid;
        string cname;
        public Customer()
        {
            cid = 0;
            cname = "NoName";
        }
        public Customer(int cid, string cname)
        {
            this.cid = cid;
            this.cname = cname;
        }
        //Properties:
        public int Cid { get; set; }
        public string Cname { get; set; }
        public void GetData() { }
        public void display() { }


    }
}
