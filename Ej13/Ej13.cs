using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    /* 13. Desarrolle una aplicación que obtenga cinco cadenas de caracteres de los
    parámetros de la aplicación, invierta cada una de ellas y escriba por consola las cadenas invertidas ordenadas descendentemente. 
    Para el desarrollo de la aplicación se deben tener las siguientes consideraciones:
    1. Se debe indagar el uso del parámetro args del método Main de la aplicación.
    2. Para ordenar las cadenas de caracteres no deben utilizarse otras herramientas 
    que ofrezca el framework más allá de las vistas hasta el momento en la cátedra.
     */
    class Ej13
    {
        static void Main(string[] args)

        {
            int i = 0;
            //Creamos un arreglo de cadenas que contendra las cinco cadenas ingresadas
            string[] cadenas = new string[5];
            //invertimos cada cadena
            for ( i=4; i>=0; i--)
            {
                cadenas[i] = "";
                for (int j = args[i].Length - 1; j >= 0; j--)
                {
                    cadenas[i] += args[i][j];
                }

            }
            //Comparamos las cadenas de a pares y utilizamos un buffer para ordenarlas en orden decreciente
            string buffer;
            i = 0;
            while (i < 4)
            {
                int orden = String.Compare(cadenas[i], cadenas[i + 1], true);
                if (orden == -1)
                {
                    buffer = cadenas[i];
                    cadenas[i] = cadenas[i + 1];
                    cadenas[i + 1] = buffer;
                    i = 0; //Tluego de reordenarlas, tenemos que volver al principio para asegurar que
                           //todas se encuentren en el orden correcto
                }
                else
                {
                    i++;
                }
                    
                
            }
            for (i=0;i<=cadenas.Length-1;i++)
            {
                Console.WriteLine(cadenas[i]);
            }

            Console.ReadKey();
                
        }
    }
}
