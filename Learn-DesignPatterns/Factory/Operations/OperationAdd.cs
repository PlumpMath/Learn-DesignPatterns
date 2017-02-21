using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class OperationAdd:Operation
    {
        public override decimal GetResult()
        {
            return FirstNumble.Value + SecondNumble.Value;
        }
    }
}
