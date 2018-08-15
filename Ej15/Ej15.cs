using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    /*15. Desarrolle una aplicación que defina un arreglo de 50 números enteros, lo inicialice
    y escriba ordenados ascendentemente por consola todos los números del arreglo que
    estén comprendidos entre dos números definidos a través de constantes.*/
    class Ej15
    {
        public const int COTAINFERIOR = -4000;
        public const int COTASUPERIOR = 4500;
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
                if ((numero < COTASUPERIOR) && (numero > COTAINFERIOR))
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();
        }
            
    }
}
