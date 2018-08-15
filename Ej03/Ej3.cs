using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /*3. Desarrolle una aplicación que imprima por pantalla la suma de los números de un
    límite inferior (por ejemplo 5) hasta el límite superior (ejemplo 100). Muestre por
    pantalla el promedio de los números ingresados. Los límites deben ser constantes.
    Utilice la sentencia for.    */
    class Ej3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese limite inferior: ");
            int limInf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese limite superior: ");
            int limSup = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            for (int i = limInf; i <= limSup; i++)
            {
                suma += i;
            }
            Console.WriteLine("La suma es {0}", suma);
            Console.WriteLine("El primedio es {0}", (limInf + limSup) / 2);
            Console.ReadKey();
        }
    }
}
