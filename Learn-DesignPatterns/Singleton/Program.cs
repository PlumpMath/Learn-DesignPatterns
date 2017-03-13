using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //问题：单例类和静态类的区别
            //1、静态类不能控制其初始化，
            //2、单例类已创建就不会被GC回收（静态属性变量不会被GC清除）
            //3、静态类不能继承类也不能实现接口
            //4、单例类可以实现多态性

            var single1 = Singleton.GetInstance();

            var single2 = Singleton.GetInstance();

            Console.WriteLine(single1 == single2 ? "我是相同的" : "我是不同的");


            var singletest1=SingletonTest.GetSingletonTest();
            var singletest2 = SingletonTest.GetSingletonTest();

            Console.WriteLine(singletest1 == singletest2 ? "我是相同的" : "我是不同的");
            Console.ReadKey();
        }
    }
}
