using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11
{
    //11. Desarrolle una aplicación donde el usuario ingrese por teclado un número real,
    //y a partir de éste calcule y escriba por consola el área del círculo y el perímetro de su circunferencia,
    //donde el radio es el número ingresado.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese radio: ");
            Double rad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del circulo es: {0}", Math.PI * Math.Pow(rad, 2));
            Console.WriteLine("El perimetro es: {0}", Math.PI * rad * 2);
            Console.ReadKey();
        }
    }
}
