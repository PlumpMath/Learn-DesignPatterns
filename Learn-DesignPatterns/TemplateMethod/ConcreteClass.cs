using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ConcreteClass : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("我是第一个来的PrimitiveOperation1方法");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("我是第一个来的PrimitiveOperation2方法");
        }
    }
}
