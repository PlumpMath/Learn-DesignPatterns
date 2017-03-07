using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class StudentFactory : ILeiFeng
    {
        public LeiFeng CreateLeiFeng()
        {
            return new StudentLeiFeng();
        }
    }
}
