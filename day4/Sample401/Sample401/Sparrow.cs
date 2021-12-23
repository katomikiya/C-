using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample401
{
    internal class Sparrow
    {
        private string name = "すずめ";

        public void sing()
        {
            Console.WriteLine("ちゅんちゅん");
        }
        // プロパティ
        public string Name
        {
            get { return name; }
        }
    }
}
