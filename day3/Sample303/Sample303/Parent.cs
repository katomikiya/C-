using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample303
{
    internal class Parent
    {
        public virtual void foo()   // 仮想関数としてサブクラスのメソッドが実行される
        {
            Console.WriteLine("親クラスのfoo()メソッド");
        }
    }
}
