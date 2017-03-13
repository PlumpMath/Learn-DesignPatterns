using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 懒汉式单例模式：使用的时候才实例化
    /// </summary>
    public class Singleton
    {
        public static Singleton instance = null;
        //创建一个静态只读的进程辅助对象
        private static object Obj = new object();
        /// <summary>
        /// 私有构造函数，不让外界对Singleton在实例化
        /// </summary>
        private Singleton()
        {
            
        }

        /// <summary>
        /// 用GetInstance方法返回Singleton实例
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            //先做判断，再进行加锁，锁是为影响性能的
            if (instance != null) return instance;
            //lock是保证一个线程位于代码的临界区时，另一个线程不进入临界区。
            //如果其他线程试图进入锁定的代码，它将一直等待（线程就阻塞了），知道对象释放。
            lock (Obj)
            {
                if (instance == null)
                {
                    //这里一定是把新实例赋值给instance，不能直接返回new Singleton()，本人就是错在这里了。呜呜呜
                    instance = new Singleton();

                }
            }

            return instance;
        }
    }

    /// <summary>
    /// 饿汉式单利模式：再程序一运行就实例化
    /// </summary>
    public sealed class SingletonTest
    {
        private static readonly SingletonTest test = new SingletonTest();

        private SingletonTest()
        {
            
        }

        public static SingletonTest GetSingletonTest()
        {
            return test;
        }
    }
}
