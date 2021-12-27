using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample702
{
    public class Program
    {
        // デリゲートを宣言
        delegate void Action(int a);

        static void Func1(int a)
        {
            Console.WriteLine("a = {0}", a);
        }

        static void Func2(int a)
        {
            Console.WriteLine("a * 2 = {0}", a * 2);
        }

        static void Func3(int a)
        {
            Console.WriteLine("a * 3 = {0}", a * 3);
        }

        static void Main()
        {
            // デリゲートオブジェクトを生成し、メソッドを設定
            Action act = new Action(Func1);
            
            act += new Action(Func2);   // メソッドを追加
            act += new Action(Func3);

            act(3);
        }
    }
}