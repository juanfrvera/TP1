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
            //Una cadena A es anagrama de B, si A != B, A tiene los mismos caracteres que B, A.Length == B.Length


            Console.Write("Ingrese la primer cadena: ");
            string cadenaUno = Console.ReadLine();
            Console.Write("Ingrese la segunda cadena: ");
            string cadenaDos = Console.ReadLine();

            if ((cadenaUno.Length == cadenaDos.Length) && (cadenaUno != cadenaDos))
            {
                //Creamos un arreglo que va a tener 1s en las posiciones de los caracteres de la cadena original
                //que se encuentren en la segunda cadena
                int[] verificador = new int[cadenaUno.Length];
                int i = 0;
                int j = 0;
                for (i = 0; i < cadenaUno.Length; i++)
                {
                    for (j = 0; j < cadenaDos.Length; j++)
                    {
                        Console.WriteLine(cadenaDos);

                        if (cadenaUno[i] == cadenaDos[j])
                        {
                            verificador[i] = 1;
                            //Removemos el caracter de esta cadena para que no se encuentre nuevamente
                            cadenaDos = cadenaDos.Remove(j, 1);
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