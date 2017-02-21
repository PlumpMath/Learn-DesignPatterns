using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("请输入第一个操作数字：");
            string first = Console.ReadLine();
            
            Console.WriteLine("请输入+、-、*、/中一个操作：");
            string operate = Console.ReadLine();
            
            Console.WriteLine("请输入第二个操作数字：");
            string second = Console.ReadLine();

            Operation oper = OperationFactory.CreatOperation(operate == null ? "+" : operate.Trim());
            oper.FirstNumble = Convert.ToDecimal(first ?? "0");
            oper.SecondNumble = decimal.Parse(second ?? "0");
            Console.WriteLine("结果为：{0}", oper.GetResult());

            Console.ReadKey();
        }


    }
}
