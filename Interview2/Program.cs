using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview3
{
    class Program
    {
        public static bool test(int i)
        {
            int reversed = 0;
            int j = i;
            while (j != 0)
            {
                reversed *= 10;
                reversed += j % 10;
                j /= 10;
            }
            return reversed == i;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(test(737));
            Console.ReadKey();
        }
    }
}
