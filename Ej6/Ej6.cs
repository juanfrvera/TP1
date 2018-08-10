using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    class Ej6
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (byte i = 1; i <= 100; i++)
            {
                if(i % 2 == 1)
                    suma += i;
            }
            Console.WriteLine("La suma es {0}", suma);
            Console.ReadKey();
        }
    }
}
