using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    // デリゲートの宣言
    delegate void Operation(int a, int b);

    class Calc
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
    }

    class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        static void Main()
        {
            Calc calc = new Calc();

            // デリゲート型にメソッドを設定
            Operation obj1 = new Operation(Add);
            Operation obj2 = new Operation(calc.Sub);

            obj1(5, 2);
            obj2(10, 7);


        }
    }

}