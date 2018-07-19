using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass obj = new ChildClass();
            obj.Method1(10);
            obj.Method2(10);
            obj.Method3(10);
            
        }
    }
}
