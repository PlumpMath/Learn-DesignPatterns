using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// 深复制需要引用类型也实现ICloneable接口
    /// </summary>
    class WorkExperience:ICloneable
    {
        public string WorkDate { get; set; }

        public string Company { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
