using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;

            int b = --a + 2;

            int c = b;

            a += b + c;

            c = b++ + a;

            b -= a;

            int x = a + b + c;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
