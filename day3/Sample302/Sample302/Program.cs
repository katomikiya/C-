using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample302
{
    class Program
    {
        static void Main()
        {
            Sub sub1 = new Sub();
            sub1.showParam();

            Sub sub2 = new Sub(100);
            sub2.showParam();
        }
    }
}