using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    public class ImageDecoratorZoomOut:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            ZoomOut();
        }

        private void ZoomOut()
        {
            Console.WriteLine("对图片做缩小处理");
        }
    }
}
