using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample102
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[10000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new string('M', 1000);
            }

            Console.WriteLine("メモリ使用量（GC発動前）:" + GC.GetTotalMemory(false));
            // arrayの参照を解放
            array = null;
            Console.WriteLine("メモリ使用量（参照解除後）：" + GC.GetTotalMemory(false));
            // ガレージコレクション
            GC.Collect();
            Console.WriteLine("メモリ使用量（GC発動後）：" + GC.GetTotalMemory(false));
        }
    }
}