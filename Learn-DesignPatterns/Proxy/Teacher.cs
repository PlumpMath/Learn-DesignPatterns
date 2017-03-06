using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// 被代理对象，真正的实体对象
    /// </summary>
    public class Teacher : Studying
    {
        public LiSi liSi;
        public Teacher(LiSi _liSi)
        {
            this.liSi = _liSi;
        }

        public void StudyChinese()
        {
            Console.WriteLine(liSi.Name + "开始学习语文");
        }

        public void StudyEnglish()
        {
            Console.WriteLine(liSi.Name + "开始学习英语");
        }

        public void StudyHistory()
        {
            Console.WriteLine(liSi.Name + "开始学习历史");
        }

        public void StudyMath()
        {
            Console.WriteLine(liSi.Name + "开始学习数学");
        }
    }
}
