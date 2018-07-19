using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAbstractClassConstructor
{
    abstract class Customer
    {
        public Guid CustomerID { get; }

        public Customer()
        {
            CustomerID = Guid.NewGuid();
        }

        public abstract Guid getCustomerID();
    }
}
