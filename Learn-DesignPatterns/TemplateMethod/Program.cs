using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        /// <summary>
        /// 模板方法：把不变的行为放到模板抽象类中，去除子类中重复的代码
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //利用多态性：声明的是父类，实例化子类。
            AbstractClass cc1 = new ConcreteClass();

            cc1.Template();
            cc1=new ConcreteClass2(); 
            cc1.Template();

            Console.ReadKey();
        }
    }
}
