using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 指挥者：建造过程的指挥者，一般来决定构建产品的顺序
    /// </summary>
    class Director
    {
        /// <summary>
        /// 建造产品
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
