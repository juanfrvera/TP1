using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16
{
    class Ej16
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese la primer cadena: ");
            string cadenaUno = Console.ReadLine();
            Console.Write("Ingrese la segunda cadena: ");
            string cadenaDos = Console.ReadLine();
            if (cadenaUno.Length == cadenaDos.Length)
            {
                int[] verificador = new int[cadenaUno.Length];
                int i = 0;
                int j = 0;
                for (i = 0; i < cadenaUno.Length; i++)
                {
                    for (j = 0; j < cadenaDos.Length; j++)
                    {
                        if (cadenaUno[i] == cadenaDos[j])
                        {
                            verificador[i] = 1;
                            cadenaDos.Remove(j, 1);
                        }
                    }
                }
                int control = 0;

                for (i = 0; i < verificador.Length; i++)
                {
                    if (verificador[i] == 1)
                    {
                        control += 1;
                    }
                }
                if (control == cadenaUno.Length)
                {
                    Console.WriteLine("Las cadenas son anagramas");

                }
                else
                {
                    Console.WriteLine("Las cadenas no son anagramas");
                }
            }
            else
            {
                Console.WriteLine("Las cadenas no son anagramas");
            }
            Console.ReadKey();
        }
    }
}