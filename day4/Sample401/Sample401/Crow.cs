using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample401
{
    internal class Crow
    {
        private string name = "カラス";

        public void sing()
        {
            Console.WriteLine("カーカー");
        }
        // プロパティ
        public string Name
        {
            get { return name; }
        }
    }
}
