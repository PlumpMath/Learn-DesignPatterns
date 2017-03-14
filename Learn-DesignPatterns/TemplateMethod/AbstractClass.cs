using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /// <summary>
    /// 抽象类：实现模板方法，定义一些抽象方法放到子类去实现
    /// </summary>
    public abstract class AbstractClass
    {
        /// <summary>
        /// 像这些PrimitiveOperation，抽象行为放到子类去实现
        /// </summary>
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        
        /// <summary>
        /// 模板的方法，用抽象行为组成一组相应的操作，从而表现出特定的行为
        /// </summary>
        public void Template()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}
