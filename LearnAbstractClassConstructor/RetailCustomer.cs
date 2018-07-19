using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAbstractClassConstructor
{
    class RetailCustomer: Customer
    {
        public RetailCustomer()
        {
            
        }

        public override Guid getCustomerID()
        {
            return CustomerID;
        }
    }
}
