using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    class Program
    {
        public const int cotaInferior = -4000;
        public const int cotaSuperior = 4500;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arreglo = new int[50];
            for (int i = 0; i <= 49; i++)
            {
                arreglo[i] = rnd.Next(-6001, 6001);
            }
            Array.Sort(arreglo);
            foreach(int numero in arreglo)
            {
                if ((numero < cotaSuperior) && (numero > cotaInferior))
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();
        }
            
    }
}
