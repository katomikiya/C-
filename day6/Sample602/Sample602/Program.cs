using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample602
{
    public class Program
    {
        static void Main()
        {
            List<string> list = new List<string>();

            list.Add("太郎");
            list.Add("次郎");
            list.Add("花子");

            list.RemoveAt(1);   // 配列1番目の要素を削除

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("list[{0}] = {1}", i, list[i]);
            }
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}