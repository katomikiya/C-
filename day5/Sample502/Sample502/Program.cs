using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample502
{
    class Program
    {
        static void Main()
        {
            Dummy dummy = new Dummy(); // Dummyクラスのインスタンス生成

            IFunc1 i1 = (IFunc1)dummy;  // インスタンスをインターフェースIFunc1型へキャスト
            IFunc2 i2 = (IFunc2)dummy;

            i1.Func1();
            i1.Func2();
            // インターフェースはメソッドの重複ができる
            i2.Func2();
            i2.Func3();
        }
    }
}