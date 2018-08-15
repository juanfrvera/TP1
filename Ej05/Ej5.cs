using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    /*5. Desarrolle la misma aplicación del ejercicio 3 pero utilice la estructura do while*/
    class Ej5
    {
        public const int LIMINF = 50;
        public const int LIMSUP = 87;
        static void Main(string[] args)
        {
            int suma = 0;
            int numero = LIMINF;
            do
            {
                suma += numero;
                numero++;
            } while (numero <= LIMSUP);
            Console.WriteLine("La suma es {0}", suma);
            Console.WriteLine("El primedio es {0}", (LIMINF + LIMSUP) / 2);
            Console.ReadKey();
        }
    }
}
