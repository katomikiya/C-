using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample401
{
    internal class Crow : Bird
    {
        // コンストラクタ
        public Crow() :base("カラス")
        {
        }
        // オーバーライド
        public override void sing()
        {
            Console.WriteLine("カーカー");
        }
    }
}
