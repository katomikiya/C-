using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample103
{
    public class Program
    {
        static void Main()
        {
            Dummy dummy = new Dummy();
            GC.Collect();
        }
    }
}