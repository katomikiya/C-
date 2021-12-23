using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample302
{
    internal class Super
    {
        private int param = 0;
        //コンストラクタ
        public Super()
        {
            Console.WriteLine("Superクラスのコンストラクタ（引数無し）");
        }
        public Super(int num)
        {
            Console.WriteLine("Superクラスのコンストラクタ（引数：param = {0}）", param);
            param = num;
        }
        // デストラクタ
        ~Super()
        {
            Console.WriteLine("Superクラスのデストラクタ");
        }

        public void showParam()
        {
            Console.WriteLine("param = {0}", param);
        }
    }
}
