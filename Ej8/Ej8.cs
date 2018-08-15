using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej8
{
    class Ej8
    {
        static void Main(string[] args)
        {
            ulong fibo1 = 0;
            ulong fibo2 = 1;
            ulong fiboSig = 0;
            Console.WriteLine("Primeros 50 elementos de la serie de Fibonacci: ");
            Console.WriteLine(fibo1);
            Console.WriteLine(fibo2);
            for (int i = 3; i<=50; i++)
            {
                fiboSig = fibo1 + fibo2;
                fibo1 = fibo2;
                fibo2 = fiboSig;
                Console.WriteLine(fiboSig);
            }
            Console.ReadKey();
        }
    }
}
