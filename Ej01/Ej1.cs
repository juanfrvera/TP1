using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*1. Desarrolle una aplicación que imprima por pantalla “UNO”, “DOS”, “TRES”...
    “NUEVE”, “OTROS” si la variable numero es igual a 1, 2, 3 … 9 ó mayor
    respectivamente.Utilice la estructura if-else para resolver el ejercicio.*/

    class Ej1
    {
        static String Uno(Byte numero)
        {
            string retornado = "otro";
            if (numero == 1)
                retornado = "uno";
            else
            if (numero == 2)
                retornado = "dos";
            else
            if (numero == 3)
                retornado = "tres";
            else
            if (numero == 4)
                retornado = "cuatro";
            else
            if (numero == 5)
                retornado = "cinco";
            else
            if (numero == 6)
                retornado = "seis";
            else
            if (numero == 7)
                retornado = "siete";
            else
            if (numero == 8)
                retornado = "ocho";
            else
            if (numero == 9)
                retornado = "nueve";
            
            return retornado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Uno(3));
            Console.ReadKey();
        }
    }
}
