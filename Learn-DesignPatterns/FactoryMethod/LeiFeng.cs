using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class LeiFeng
    {
        public virtual void Wash()
        {
            Console.WriteLine("洗衣服");
        }

        public virtual void Sweep()
        {
            Console.WriteLine("打扫");
        }

        
    }
}
