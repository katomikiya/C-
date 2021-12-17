using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample101
{
    internal class Person
    {
        private string name = "";
        private int age = 0;

        // コンストラクタ
        public Person() : this("名前なし", 0)  
        {
            Console.WriteLine("引数無しコンストラクタ");
        }
        // コンストラクタのオーバーロード
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("引数ありコンストラクタ name: {0}, age: {1}", name, age);
        }

        public void showAgeAndName()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", name, age);
        }
        // プロパティ
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}
