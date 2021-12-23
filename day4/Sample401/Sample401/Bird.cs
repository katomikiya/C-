using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample401
{
    // 抽象クラス
    abstract class Bird
    {
        private string name;
        // コンストラクタ
        public Bird(string name)
        {
            this.name = name;
        }
        // プロパティ
        public string Name
        {
            get { return name; }
        }
        // 抽象メソッド
        public abstract void sing();
    }
}
