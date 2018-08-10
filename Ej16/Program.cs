using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
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
                int h = 0;
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

                for (h = 0; h < verificador.Length; h++)
                {
                    if (verificador[h] == 1)
                    {
                        control += 1;
                    }
                }
                if (control == cadenaUno.Length)
                {
                    Console.WriteLine("Exito");

                }
                else
                {
                    Console.WriteLine("Fracaso");
                }
            }
            else
            {
                Console.WriteLine("Fracaso");
            }
            Console.ReadKey();
        }
    }
}