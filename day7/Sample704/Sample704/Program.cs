using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample704
{
    class Program
    {
        static void Main()
        {
            try
            {
                int result = getNum(4);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("配列の範囲外にアクセスしました。");
            }
        }

        static int getNum(int i)
        {
            int[] nums = { 30, 600, 900 };

            if (i < nums.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return nums[i];
        }
    }
}