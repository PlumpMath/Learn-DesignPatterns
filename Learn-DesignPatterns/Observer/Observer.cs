using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 抽象观察者：把具体的观察者抽象出来，再收到通知者的通知时更新自己状态
    /// </summary>
    abstract class Observer
    {
        /// <summary>
        /// 观察者更新状态
        /// </summary>
        public abstract void Update();
    }
}
