using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample202
{
    public class Program
    {
        private static int s_num = 100;
        private int i_num = 200;
        public static void foo()
        {
            Console.WriteLine("静的fooメソッド");
        }
        public void bar()
        {
            Console.WriteLine("インスタンスbarメソッド");
        }

        static void Main()
        {
            Program program = new Program();

            Console.WriteLine("programのインスタンスフィールド：i_sum = {0}", program.i_num);
            program.bar();

            Console.WriteLine();

            Console.WriteLine("Programのクラスフィールド：s_sum = {0}", s_num);   // 静的メンバ変数ん
            foo();  // 静的メンバ関数
        }

    }
}