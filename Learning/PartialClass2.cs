using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPartialClass
{
    abstract partial class PartialClass
    {
        public abstract void Method2(int val);
        public virtual void Method3(int val)
        {
            throw new NotImplementedException();
        }

        partial void Method0(int val)
        {
            Console.WriteLine(val);
        }

    }
}
