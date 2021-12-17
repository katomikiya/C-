using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("太田隆", 15);

            person1.Name = "斎藤花子";
            person1.Age = 18;

            Console.WriteLine("名前：{0} 年齢：{1}", person1.Name, person1.Age);
            person2.showAgeAndName();
        }
    }
}