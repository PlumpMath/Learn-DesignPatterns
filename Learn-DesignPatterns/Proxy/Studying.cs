using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    
    /// <summary>
    /// 具有相同方法，代理类和被代理类的公用接口
    /// </summary>
    interface Studying
    {
        void StudyEnglish();

        void StudyChinese();

        void StudyHistory();
        void StudyMath();
    }
}
