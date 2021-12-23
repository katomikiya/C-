using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample201
{ 
    public class Program
    {
        static void Main()
        {
            Data[] d_arr = new Data[2];
            Data.showNumber();  // staticメソッドを呼び出す

            for (int i = 0; i < d_arr.Length; i++)
            {
                d_arr[i] = new Data(i * 100);
                Data.showNumber();
            }
        }
    }
}