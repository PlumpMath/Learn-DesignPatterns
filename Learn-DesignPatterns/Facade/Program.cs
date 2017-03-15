using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        /// <summary>
        /// 客户端
        /// 门面模式（外观模式）：为子系统的方法提供统一的界面，让客户端不需要知道子类的具体操作。松耦合
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Facade facade=new Facade();
            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }
}
