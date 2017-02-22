using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ALG
{
    /// <summary>
    /// 打折算法
    /// </summary>
    public class CashRebate : CashSuper
    {
        public double MoneyRebate
        {
            get;

            private set;
        }

        /// <summary>
        /// 打折算法
        /// </summary>
        /// <param name="moneyRebate">折扣(必须在0-1之间，否则没有折扣)</param>
        public CashRebate(string moneyRebate)
        {
            this.MoneyRebate = double.Parse(moneyRebate);
        }
        public override double AcceptCash(double totalMoney)
        {
            return totalMoney * this.MoneyRebate;
        }
    }
}
