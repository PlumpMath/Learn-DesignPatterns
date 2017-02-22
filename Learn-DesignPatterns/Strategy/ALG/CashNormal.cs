using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ALG
{
    /// <summary>
    /// 正常收费
    /// </summary>
    public class CashNormal : CashSuper
    {
        public override double AcceptCash(double totalMoney)
        {
            return totalMoney;
        }
    }
}
