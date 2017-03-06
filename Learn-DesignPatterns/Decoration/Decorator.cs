using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    /// <summary>
    /// 继承抽象接口，对抽象接口进行扩展，抽象接口无需知道它的存在
    /// </summary>
    public abstract class Decorator : Component
    {
        private Component component;
        public void SetComponent(Component _Component)
        {
            this.component = _Component;
        }
        public override void Operation()
        {
            if (this.component != null)
            {
                this.component.Operation();
            }
        }
    }
}
