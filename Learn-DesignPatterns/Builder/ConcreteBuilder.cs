using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 具体的建造者：实现建造的具体方法
    /// </summary>
    class ConcreteBuilder : Builder
    {
        private Product p = new Product();
        public override void BuildPartA()
        {
            p.Add("建造A部件");
        }

        public override void BuildPartB()
        {
            p.Add("建造B部件");
        }

        public override Product GetResult()
        {
            return p;
        }
    }
}
