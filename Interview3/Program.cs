using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = GetList();
            Task.Run(() =>
            {
                myList.ForEach(i => Console.WriteLine(i++));
            });

            Task.Run(() =>
            {
                myList.RemoveRange(50, 100);
            });

            myList.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }

        static List<int> GetList()
        {
            var myList = new List<int>(1000);
            for (int i = 0; i < 1000; i++)
                myList.Add(i);

            return myList;
        }
    }
}
