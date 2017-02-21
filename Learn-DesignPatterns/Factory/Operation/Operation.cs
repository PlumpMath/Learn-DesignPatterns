using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Operation
    {
        public decimal? FirstNumble { get; set; }
        
        public decimal? SecondNumble { get; set; }
        
        public virtual decimal GetResult()
        {
            return 0;
        }
    }
}
