using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample302
{
    internal class Sub : Super
    {
        public Sub()
        {
            Console.WriteLine("Subクラスのコンストラクタ（引数無し）");
        }
        public Sub(int num) : base(num) // 引数有の親クラスコンストラクタを呼び出し
        {
            Console.WriteLine("Subクラスのコンストラクタ（引数：num = {0}）", num);
        }
        
        ~Sub()
        {
            Console.WriteLine("Subクラスのデストラクタ");
        }
    }
}
