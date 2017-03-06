using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    class Program
    {
        /// <summary>
        /// 装饰模式就是对现有功能，动态的添加额外功能的一种方式
        /// 
        /// 如果一个功能是为满足一个特定的行为，就可以用装饰模式，他有效的把单个功能放到单独的类中，
        /// 并让这个包装他要装饰的对象，当需要这个特殊功能的时候，客户端只需要有选择的去使用。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ImageComponent imageComponent = new ImageComponent();

            ImageDecoratorZoomIn idzi = new ImageDecoratorZoomIn();

            ImageDecoratorZoomOut idzo = new ImageDecoratorZoomOut();

            ImageDecoratorWaterMark idwm = new ImageDecoratorWaterMark();

            idzi.SetComponent(imageComponent);

            idzo.SetComponent(idzi);

            idwm.SetComponent(idzo);

            idwm.Operation();

            Console.ReadKey();
        }
    }
}
