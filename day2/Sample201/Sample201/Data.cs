using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample201
{
    internal class Data
    {
        private static int num = 0; // Dataオブジェクトの数
        private int value;     // データの値

        // コンストラクタ
        public Data(int id)
        {
            value = id;
            num++;
            Console.WriteLine("値：{0} 数：{1}", value, num);
        }
        // オブジェクト数を取得
        public static void showNumber()  // 静的メソッド(static)
        {
            Console.WriteLine("Dataオブジェクトの数：{0}", num);
        }
    }
}
