using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class StudentLeiFeng:LeiFeng
    {
        public override void Sweep()
        {
            Console.WriteLine("大学生来洗衣服");
        }
    }
}
