using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 具体的观察者：实现抽象观察者的更新接口,可以有多个
    /// </summary>
    class ConcreteObserver : Observer
    {
        /// <summary>
        /// 观察者名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 观察者状态
        /// </summary>
        public string State { get; set; } = "看电视";

        /// <summary>
        /// 接受通知者的状态
        /// </summary>
        public ConcreteSubject Subject { get; set; }

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            Subject = subject;
            Name = name;
        }

        public override void Update()
        {
            State = Subject.SubjectState ?? State;
            Console.WriteLine($"观察者{this.Name}的新状态是{this.State}");
        }
    }
}
