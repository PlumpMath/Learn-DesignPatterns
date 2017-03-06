using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    /// <summary>
    /// 具体的装饰对象，起到给Compontent添加职责的功能
    /// </summary>
    public class ImageDecoratorZoomIn: Decorator
    {
        private void ZoomIn()
        {
            Console.WriteLine("对图片做放大处理");
        }
        public override void Operation()
        {
            base.Operation();
            ZoomIn();
        }
    }
}
