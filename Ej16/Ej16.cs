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
                //Creamos un arreglo que llenaremos con 1s por cada caracter en comun entre las cadenas
                int[] verificador = new int[cadenaUno.Length];
                int i = 0;
                int j = 0;
                //recorremos ambas cadenas a verificar si poseen caracteres en comun
                for (i = 0; i < cadenaUno.Length; i++)
                { 
                    for (j = 0; j < cadenaDos.Length; j++)
                    {
                        //Si existe el caracter en comun marcamos en nuestro arreglo 
                        //y removemos dicho caracter para que no se encuentre nuevamente
                        if (cadenaUno[i] == cadenaDos[j])
                        {
                            verificador[i] = 1;
                            cadenaDos = cadenaDos.Remove(j, 1);
                        }
                    }
                }

                //Creamos un control que contara los elementos del verificador que sean 1. En caso que esta cantidad
                //sea igual a la longitud de la cadenaUno, entonces las cadenas son anagramas.
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