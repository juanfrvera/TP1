using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10
{
    /*10.Desarrolle una aplicación que liste por consola los años bisiestos comprendidos entre 1900 y 2015,
     * utilizando constantes para contener el valor de los dos años indicados.
    */
    class Program
    {
        public const UInt16 INICIO = 1900;
        public const UInt16 FINAL = 2015;
        static void Main(string[] args)
        {
            UInt16 i = INICIO;
            while(DateTime.DaysInMonth(i, 2) != 29)
            {
                i++;
            }
            while(i <= FINAL)
            {
                Console.WriteLine(i);
                i += 4;
            }
            Console.ReadKey();
        }
    }
}
