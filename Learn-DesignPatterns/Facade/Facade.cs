using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// 门面类：负责把子系统的操作呈现给客户端
    /// MethodA和MethodB是高层接口：其中组装了子类的操作
    /// </summary>
    class Facade
    {
        private SubSystemOne sso;
        private SubSystemTwo sst;
        private SubSystemThree ssth;
        private SubSystemFour ssf;

        public Facade()
        {
            sso=new SubSystemOne();
            sst=new SubSystemTwo();
            ssth=new SubSystemThree();
            ssf=new SubSystemFour();
        }

        public void MethodA()
        {
            sso.MethodOne();
            sst.MethodTwo();
            ssth.MethodThree();
            ssf.MethodFour();
            Console.WriteLine("");
        }

        public void MethodB()
        {
            sso.MethodOne();
            ssf.MethodFour();
            Console.WriteLine("");
        }
    }
}
