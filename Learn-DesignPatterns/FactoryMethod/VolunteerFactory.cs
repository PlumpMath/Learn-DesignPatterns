using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class VolunteerFactory : ILeiFeng
    {
        public LeiFeng CreateLeiFeng()
        {
            return new VolunteerLeiFeng();
        }
    }
}
