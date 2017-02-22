using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ALG
{
    /// <summary>
    /// 抽象收费类
    /// </summary>
    public abstract class CashSuper
    {
        /// <summary>
        /// 抽象的收费算法
        /// </summary>
        /// <param name="totalMoney">需要进行促销价格</param>
        /// <returns>返回促销后的价格</returns>
        public abstract double AcceptCash(double totalMoney);
    }
}
