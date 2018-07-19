using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPartialClass
{
    class ChildClass : PartialClass
    {
        public ChildClass()
        {

        }
        
        public override void Method3(int val)
        {
            Console.WriteLine(val);
        }

        public override void Method2(int val)
        {
            Console.WriteLine(val);
        }

        
    }
}
