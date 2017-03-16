using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        /// <summary>
        /// 建造者模式：主要用于创建一个复杂的对象，这些对象的内部构建顺序一般是稳定的，
        /// 但是这些对象内部结构通常面临着复杂的变化（也就是说抽象建造者类里的抽闲方法的实现是复杂变化的）
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //先创建一个指挥者
            Director director = new Director();
            //在创建一个具体的建造者
            ConcreteBuilder concreteBuilder = new ConcreteBuilder();
            ConcreteBuilderIpad concreteBuilderiapIpad = new ConcreteBuilderIpad();
            //指挥者开始指挥来
            //指挥concreteBuilder开始构建产品
            director.Construct(concreteBuilder);
            //指挥concreteBuilder得到产品
            Product p1 = concreteBuilder.GetResult();
            p1.Show();

            //第二次指挥
            director.Construct(concreteBuilderiapIpad);
            Product p2 = concreteBuilderiapIpad.GetResult();
            p2.Show();
            Console.ReadKey();
        }
    }
}
