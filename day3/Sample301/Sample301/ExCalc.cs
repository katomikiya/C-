using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample301
{
    // 親クラスを継承
    internal class ExCalc : Calc  
    {
        public void mul()
        {
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }
        public void div()
        {
            Console.WriteLine("{0} / [1] = {2}", num1, num2, num1 / num2 );
        }
    }
}
