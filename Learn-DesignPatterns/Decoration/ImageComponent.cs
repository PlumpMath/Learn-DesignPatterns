using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    /// <summary>
    /// 具体的操作对象
    /// </summary>
    public class ImageComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("对图片开始修正！！！");
        }
    }
}
