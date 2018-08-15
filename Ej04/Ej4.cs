using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    /*4. Desarrolle la misma aplicación del ejercicio 3 pero utilice la estructura while.*/
    class Ej4
    {
        public const int LIMINF = 50;
        public const int LIMSUP = 87;
        static void Main(string[] args)
        {
            int suma = 0;
            int numero = LIMINF;
            while (numero <= LIMSUP)
            {
                suma += numero;
                numero++;
            }
            Console.WriteLine("La suma es {0}", suma);
            Console.WriteLine("El primedio es {0}", (LIMINF + LIMSUP) / 2);
            Console.ReadKey();
        }
    }
}
