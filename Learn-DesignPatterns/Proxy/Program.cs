using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        /// <summary>
        /// 代理模式就是为其他对象提供一种代理以控制对这个对象的访问
        /// 特点：被代理类在客户端就没有出现
        /// 
        /// 老师让张三帮助李四学习
        /// 1、老师是被代理对象，
        /// 2、张三是代理
        /// 3、代理和被代理都有相同的方法
        /// 4、李四是美女
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            LiSi lisi = new LiSi() { Name = "李四美女" };
            ZhangSan zs = new ZhangSan(lisi);
            zs.StudyChinese();
            zs.StudyEnglish();
            zs.StudyHistory();
            zs.StudyMath();
            Console.ReadKey();
        }
    }
}
