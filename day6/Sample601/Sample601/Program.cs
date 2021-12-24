using System;
using System.Collections.Generic;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    public class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();

            list.Add(3);
            list.Add(2);
            list.Add(1);

            list.Insert(1, 100);    // 配列1番目に要素を追加

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("list[{0}] = {1}", i, list[i]);
            }
        }
    }
}