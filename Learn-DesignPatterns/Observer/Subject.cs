using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 抽象通知者
    /// </summary>
    abstract class Subject
    {
        //观察者列表
        private IList<Observer> observers = new List<Observer>();

        /// <summary>
        /// 增加观察者
        /// </summary>
        /// <param name="observer"></param>
        public virtual void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 删除观察者
        /// </summary>
        /// <param name="observer"></param>
        public virtual void Detach(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 通知观察者
        /// </summary>
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
