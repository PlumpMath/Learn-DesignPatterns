using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //先创建通知者
            ConcreteSubject subject = new ConcreteSubject();
            //在创建观察者
            ConcreteObserver observer1 = new ConcreteObserver(subject, "学生小明");
            //通知者添加观察者
            subject.Attach(observer1);
            //改状态
            //subject.SubjectState = "学习";
            //通知
            subject.Notify();
            Console.ReadKey();
        }
    }
}
