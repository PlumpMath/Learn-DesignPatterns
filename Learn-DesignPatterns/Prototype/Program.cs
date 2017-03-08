using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        /// <summary>
        /// 原型模式:从一个对象创建另一个可定制的对象，不需要知道创建的细节，不用new关键字提高了性能，作为原型的类必须时间ICloneable接口
        /// 这里有浅复制和深复制的概念
        /// 浅复制：被clone的对象所有值类型变量都和原来的对象的值相同，但是引用类型(string除外，不变性)是复制的其引用，clone的对象的引用类型还指向原来对象的引用
        /// 深复制：就是不管是引用类型还是值类型，完完全全把clone过来一份，修改引用类型的值不会影响到原来的对象；
        /// 
        /// 怎么进行深度复制：在clone方法里复制的时候不能有引用类型
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ResumePrototype rp = new ResumePrototype("lizejia");
            rp.SetPersonalInfo(20, "nan", "nsdaidniands");
            rp.SetWorkExperience("newegg", "2015-2016");
            rp.Display();

            ResumePrototype rp1 = (ResumePrototype)rp.Clone();
            rp1.SetWorkExperience("huawei", "2014-2015");
            rp1.Display();


            Console.ReadKey();
        }
    }
}
