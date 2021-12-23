using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample301
{
    public class Program
    {
        static void Main()
        {
        /* 親クラスCalcのインスタンス生成 */
            Calc calc = new Calc();
            // セッターで値を代入
            calc.Num1 = 10;
            calc.Num2 = 3;

            calc.add();
            calc.sub();

        /* 子クラスExCalcのインスタンス生成 */
            ExCalc ex_calc = new ExCalc();
            ex_calc.Num1 = 20;
            ex_calc.Num2 = 5;

            ex_calc.add();
            ex_calc.sub();
            ex_calc.mul();
            ex_calc.div();
        }
    }
}