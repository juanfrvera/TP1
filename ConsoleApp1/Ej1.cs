using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
