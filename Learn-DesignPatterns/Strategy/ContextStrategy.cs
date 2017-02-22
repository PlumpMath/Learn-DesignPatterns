using Strategy.ALG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ContextStrategy
    {

        CashSuper CS;
        /// <summary>
        /// 通过构造的方式，创建出用哪种策略对象
        /// </summary>
        /// <param name="type"></param>
        public ContextStrategy(string type)
        {
            //工厂和策略的结合
            switch (type)
            {
                case "正常收费":
                    CS = new CashNormal();
                    break;
                case "打8折":
                    CS = new CashRebate("0.8");
                    break;
                default:
                    CS = new CashNormal();
                    break;
                    
            }
            
        }

        /// <summary>
        /// 根据不同策略对象，使用不同的策略，获得不一样的值
        /// </summary>
        /// <param name="totalMoney"></param>
        /// <returns></returns>
        public double GetPayment(double totalMoney)
        {
            return CS.AcceptCash(totalMoney);
        }
    }
}
