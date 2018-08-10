using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12
{
    //12.Desarrolle una aplicación que calcule el factorial de un 
    //número ingresado por teclado y lo escriba en la consola.
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Ingrese un numero: ");
           UInt64 numero = Convert.ToUInt64(Console.ReadLine());
            UInt64 f = 1;
            for (UInt64 i = 2; i <= numero; i++)
                f *= i;
            Console.WriteLine("El resultado del factorial es: {0}", f);
            Console.ReadKey();
        }
    }
}
