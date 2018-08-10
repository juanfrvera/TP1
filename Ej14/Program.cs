using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14
{
    class Program
    {

        static int suma(int[] array)
        {
            int sum = 0;
            foreach (int numero in array)
            {
                sum += numero;
            }
            return (sum);

        }

        static float promedio(int[] array)
        {
            float prom = Convert.ToSingle(suma(array)) /30;
            return(prom);
        }

        static int minimo(int[] array)
        {
           int min = array[0];
                for (int i = 1; i <= 29; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }

            }
            return(min);

        }

        static int maximo(int[] array)
        {
            int max = array[0];
            for (int i = 1; i <= 29; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }

            }
            return (max);

        }
            static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arreglo = new int[30];
            for (int i = 0; i <= 29; i++)
            {
                arreglo[i] = rnd.Next(-5001,5001);
            Console.WriteLine(arreglo[i]); }
            Console.WriteLine();
            Console.WriteLine("El valor minimo es: {0}",minimo(arreglo));
            Console.WriteLine("El valor maximo es: {0}",maximo(arreglo));
            Console.WriteLine("La sumatoria es: {0}",suma(arreglo));
            Console.WriteLine("El promedio es: {0}",promedio(arreglo));
            Console.ReadKey();
        }
    }
}
