using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong f1 = 0;
            ulong f2 = 1;
            ulong f3 = 0;
            Console.WriteLine("Primeros 50 elementos de la serie de Fibonacci: ");
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (int i = 3; i<=50; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                Console.WriteLine(f3);
            }
            Console.ReadKey();
        }
    }
}
