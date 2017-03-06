using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    public class ImageDecoratorWaterMark:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddWaterMark();

        }
        private void AddWaterMark()
        {
            Console.WriteLine("对图片加水印");
        }
    }
}
