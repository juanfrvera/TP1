using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    class Ej7
    {
        static void Main(string[] args)
        /*{
            double suma = 0;
            double n = 0;
            while (Math.Abs((Math.PI) - suma) > (0.000001f))
            {
                suma += 4*((Math.Pow(-1, n)) / (2 * n + 1));
            
                n++;
            }
            Console.Write("Math.Pi = {0} ; Aproximacion de Pi con error menor a 0.0001% : {1}", Math.PI, suma);
            Console.ReadKey();
        }*/

        {
            Console.Write("Ingrese numero de iteraciones: ");
            double iteraciones = Convert.ToDouble(Console.ReadLine());
            double suma = 0;
            for (double n = 0; n < iteraciones; n++)
            {
                suma += ((Math.Pow(-1, n)) / (2 * n + 1));

            }
            Console.WriteLine("Aproximacion a PI: {0}", suma * 4);
            Console.Write("Error Porcentual {0}", (Math.Abs(Math.PI - suma * 4) / Math.PI) * 100);
            Console.ReadKey();
        }
    }
}
