using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample403
{
    class Program
    {
        static void Main()
        {
            VectorBase vector = new VectorSub();

            vector.X = 0.1;
            vector.Y = 0.5;

            Console.WriteLine("vector = ({0}, {1})", vector.X, vector.Y);
        }
    }
}