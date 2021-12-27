using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample604
{
    public class Program
    {
        static void Main()
        {
            HashSet<int> t = new HashSet<int>();
            t.Add(1);
            t.Add(2);
            t.Add(3);
            t.Add(1);   // 重複はできない

            foreach(int i in t)
            {
                Console.WriteLine(i);
            }
        }
    }
}