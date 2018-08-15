using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
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
            Console.ReadKey();
        }
    }
}
