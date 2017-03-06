using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// 代理类，保存一个引用使得代理可以访问实体，和被代理对象实现相同接口，这样代理类就可以替代实体
    /// </summary>
    public class ZhangSan : Studying
    {
        public Teacher teacher;
        public ZhangSan(LiSi _liSi)
        {
            this.teacher = new Teacher(_liSi);
        }

        public void StudyChinese()
        {
            teacher.StudyChinese();
        }

        public void StudyEnglish()
        {
            teacher.StudyEnglish();
        }

        public void StudyHistory()
        {
            teacher.StudyHistory();
        }

        public void StudyMath()
        {
            teacher.StudyMath();
        }
    }
}
