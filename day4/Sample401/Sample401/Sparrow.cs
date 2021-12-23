using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample401
{
    internal class Sparrow : Bird
    {
        // コンストラクタ
        public Sparrow() : base("すずめ")
        {
        }
        // オーバーライド
        public override void sing()
        {
            Console.WriteLine("ちゅんちゅん");
        }
    }
}
