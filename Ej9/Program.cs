using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt32 suma = 0;
            for (UInt16 i = 35; i <= 1977; i+=2)
            {
                UInt16 n = 0;
                UInt16 h = 3;
                while (n == 0 && h <= Convert.ToUInt16(i / 2))
                {
                    if (i % h == 0)
                    {
                        n++;
                    }
                    h++;
                }
                if (n == 0)
                {
                    suma += i;
                }
            }
            Console.Write("La suma de los numeros primos es: {0}",suma);
            Console.ReadKey();
        }
    }
}