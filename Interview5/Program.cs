using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview2
{
    class Program
    {
        class MyClass
        {
            public int Value { get; set; } = 100;
            public override string ToString() { return Value.ToString(); }
        }
        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }
        static void ChangeValue(MyClass x)
        {
            x.Value = 200;
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            int i = 100;
            MyClass mine = new MyClass();

            Console.WriteLine(i + " " + mine.Value);
            ChangeValue(i); 
            ChangeValue(mine);
            Console.WriteLine(i + " " + mine.Value);
            Console.ReadKey();
        }
    }
}
