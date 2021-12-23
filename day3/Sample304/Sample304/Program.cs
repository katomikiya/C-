using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample304
{
    class Program
    {
        public void Foo()
        {
            Console.WriteLine("foo");
        }

        static void Main()
        {
            Program p = new Program();

            Console.WriteLine(p.ToString());    // ToString()メソッド・・・オブジェクトを表す文字列を返す
        }
    }
}