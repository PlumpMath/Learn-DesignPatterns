using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        /// <summary>
        /// 工厂方法模式：是对简单工厂的进一步抽象和推广，他克服了简单工厂违反OCP原则
        /// 工厂方法使得实例化延迟到了子类，
        /// 工厂方法就是把简单工厂的实例化业务放到了他的子类中
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //如果这里想要用社区志愿者的话StudentFactory变成VolunteerFactory
            ILeiFeng student = new StudentFactory();

            LeiFeng lf = student.CreateLeiFeng();

            lf.Sweep();

            lf.Wash();

            Console.ReadKey();
        }
    }
}
