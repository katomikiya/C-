using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample401
{
    public class Program
    {
        static void Main()
        {
            Crow crow = new Crow();
            Sparrow sparrow = new Sparrow();

            Console.Write(crow.Name + "：");
            crow.sing();

            Console.Write(sparrow.Name + "：");
            sparrow.sing();
        }
    }
}