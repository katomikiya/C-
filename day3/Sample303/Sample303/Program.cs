using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample303
{
    public class Program
    {
        static void Main()
        {
            Parent parent = new Parent();   // 親クラスのインスタンス生成
            Parent child = new Child();     // 子クラスのインスタンス生成


            parent.foo();
            child.foo();    // 親クラスのfooメソッドが実行される
        }
    }
}