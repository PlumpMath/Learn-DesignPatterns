using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ConcreteBuilderIpad : Builder
    {
        Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("给你屏幕");
        }

        public override void BuildPartB()
        {
            product.Add("给你合格证");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
