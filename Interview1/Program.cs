using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = new int[1];
                Console.WriteLine("Hello");
                Console.WriteLine(a[1]);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("A");
            }
            catch (Exception)
            {
                Console.WriteLine("B");
            }
            finally
            {
                Console.WriteLine("C");
            }
            Console.ReadKey();
        }
    }
}
