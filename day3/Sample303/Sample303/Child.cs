using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample303
{
    internal class Child : Parent
    {
        public void foo()
        {
            Console.WriteLine("子クラスのfoo()メソッド");
        }
    }
}
