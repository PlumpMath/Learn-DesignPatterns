using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 具体的通知者：可以有多个，将有关状态存入具体观察者
    /// </summary>
    class ConcreteSubject :Subject
    {
        /// <summary>
        /// 状态
        /// </summary>
        public string SubjectState { get; set; }
    }
}
