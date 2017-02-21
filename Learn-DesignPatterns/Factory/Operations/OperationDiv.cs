using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class OperationDiv:Operation
    {
        public override decimal GetResult()
        {
            if(SecondNumble.Value == 0)
            {
                throw new Exception("除数不能为0");
            }
            return FirstNumble.Value / SecondNumble.Value;
        }
    }
}
