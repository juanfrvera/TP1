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
        static void Main(string[] args)
        {
            Console.Write("Ingrese limite inferior: ");
            int limInf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese limite superior: ");
            int limSup = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            while (limInf <= limSup)
            {
                suma += limInf;
                limInf++;
            }
            Console.WriteLine("La suma es {0}", suma);
            Console.ReadKey();
        }
    }
}
