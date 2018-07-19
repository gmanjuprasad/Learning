using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAbstractClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            RetailCustomer rCus = new RetailCustomer();
            Console.WriteLine(rCus.getCustomerID());

            OnlineCutomer oCus = new OnlineCutomer();
            Console.WriteLine(oCus.getCustomerID());
        }
    }
}
