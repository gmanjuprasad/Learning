using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPartialClass
{
    public partial class PartialClass
    {
        public PartialClass()
        {

        }

        partial void Method0(int val);

        public void Method1(int val)
        {
            Console.WriteLine(val);
        }


    }
}
